"""
  @title        MI PROGRAMA EN PYTHON v1.0
  @description  Operaciones de asignación de tarjetas
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import pandas
from decimal import Decimal
from datetime import date

ARCHIVO_TARJETAS = 'tarjetas.csv'
ARCHIVO_TITULARES = 'titulares.csv'


# ─── MÉTODOS ESTÁTICOS ───────────────────────────────────────────────────────
def agregar_years(desde, years):
    """
    Agrega años a una fecha y devuelve la fecha resultante.
    No nombro "años" al método por el error "non-ASCII character".
    """
    try:
        return desde.replace(year=desde.year + years)
    except ValueError:
        # Para el caso de febrero 29
        return desde.replace(year=desde.year + years, day=28)


class Asignacion:
    """ Clase que representa una asignación de tarjeta de crédito a un titular. """

    def __init__(self):
        """ Constructor """
        self.tarjetas = pandas.read_csv(ARCHIVO_TARJETAS)
        self.titulares = pandas.read_csv(ARCHIVO_TITULARES)

    # ─── MÉTODOS DE INSTANCIA ────────────────────────────────────────────────
    def asignar_tarjeta(self, id_tarjeta, id_titular, saldo_pesos, saldo_dolares):
        """ Asigna una tarjeta a un titular """

        # Valida si el titular existe
        if self.titulares[self.titulares['DocumentoNumero'] == int(id_titular)].empty:
            print('El titular no existe.')
            return

        # Valida si la tarjeta existe
        if self.tarjetas[self.tarjetas['TarjetaNumero'] == int(id_tarjeta)].empty:
            print('La tarjeta no existe.')
            return

        # Valida si la tarjeta ya está asignada
        campo = self.tarjetas[self.tarjetas['TarjetaNumero'] == int(id_tarjeta)]['TitularDocumento']
        if campo.values[0] != 0:
            print('La tarjeta ya está asignada.')
            return

        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'TitularDocumento'] = int(id_titular)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'SaldoPesos'] = Decimal(saldo_pesos)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'SaldoDolares'] = Decimal(
            saldo_dolares)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaOtorgamiento'] = date.today()
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaVencimiento'] = agregar_years(
            date.today(), 4)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'Activa'] = 1
        self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)
        print('Tarjeta asignada correctamente.')

    def desasignar_tarjeta(self, id_tarjeta):
        """ Desasigna una tarjeta a un titular """
        if self.tarjetas[self.tarjetas['TarjetaNumero'] == int(id_tarjeta)].empty:
            print('La tarjeta no existe.')
            return

        pesos = self.tarjetas[self.tarjetas['TarjetaNumero'] == int(id_tarjeta)]['SaldoPesos']
        dolares = self.tarjetas[self.tarjetas['TarjetaNumero'] == int(id_tarjeta)]['SaldoDolares']

        if pesos.values[0] == 0 and dolares.values[0] == 0:
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'TitularDocumento'] = 0
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaOtorgamiento'] = 0
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaVencimiento'] = 0
            self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)
            print('Tarjeta desasignada correctamente.')
        else:
            print('No se puede desasignar la tarjeta porque tiene saldo.')
