"""
  @title        Gestor de Tarjetas de Crédito
  @description  Implementación ABM archivo CSV para tarjetas
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import pandas
from decimal import Decimal
from datetime import date

ARCHIVO_TARJETAS = 'tarjetas.csv'


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


class ABMTarjetas:
    """ CRUD para leer y escribir el archivo CSV de tarjetas """
    def __init__(self):
        """ Constructor """
        self.tarjetas = pandas.read_csv(ARCHIVO_TARJETAS)

    # ─── PERSISTENCIA ────────────────────────────────────────────────────────
    def guardar_tarjeta(self):
        """ Guarda las tarjetas en el archivo CSV """
        self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)

    # ─── MÉTODOS DE INSTANCIA ────────────────────────────────────────────────
    def asignar_tarjeta(self, id_tarjeta, id_titular, saldo_pesos, saldo_dolares):
        """ Asigna una tarjeta a un titular """
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'TitularDocumento'] = int(id_titular)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'SaldoPesos'] = Decimal(saldo_pesos)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'SaldoDolares'] = Decimal(saldo_dolares)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaOtorgamiento'] = date.today()
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaVencimiento'] = agregar_years(
            date.today(), 4)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'Activa'] = 1
        self.guardar_tarjeta()

    def desasignar_tarjeta(self, id_tarjeta):
        """ Desasigna una tarjeta a un titular """
        if self.tarjetas[(self.tarjetas['TarjetaNumero'] == int(id_tarjeta)) & (self.tarjetas['SaldoPesos'] == 0) & (
                self.tarjetas['SaldoDolares'] == 0)].empty:
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'TitularDocumento'] = 0
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaOtorgamiento'] = 0
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaVencimiento'] = 0
            self.guardar_tarjeta()
        else:
            print('No se puede desasignar la tarjeta porque tiene saldo.')

    # ─── (C) CREAR ───────────────────────────────────────────────────────────
    def crear_tarjeta(self, tarjeta_numero, tarjeta_tipo):
        """ Crea una nueva tarjeta """

        # Validación pedida por el ejercicio.
        largo_tarjeta = len(str(tarjeta_numero))
        prefijo_tarjeta = str(tarjeta_numero)[:5]
        if largo_tarjeta != 16:
            print('El número de tarjeta no es válido.')
            return
        if prefijo_tarjeta == '9999' and tarjeta_tipo != 'Platinum':
            print('El número de tarjeta no es válido.')
            return
        if prefijo_tarjeta == '8888' and tarjeta_tipo != 'Gold':
            print('El número de tarjeta no es válido.')
            return
        if prefijo_tarjeta == '7777' and tarjeta_tipo != 'Plata':
            print('El número de tarjeta no es válido.')
            return
        # Fin validación pedida por el ejercicio.

        tarjeta = {
            'TarjetaNumero': tarjeta_numero,
            'TarjetaTipo': tarjeta_tipo,
            'TitularDocumento': '0',
            'SaldoPesos': '0',
            'SaldoDolares': '0',
            'FechaOtorgamiento': '0',
            'FechaVencimiento': '0',
            'Activa': '0'
        }
        self.tarjetas = self.tarjetas.append(tarjeta, ignore_index=True)
        self.guardar_tarjeta()

    # ─── (R) LEER ────────────────────────────────────────────────────────────
    def leer_tarjeta(self, id_tarjeta):
        """
        Devuelve la tarjeta con el ID especificado.
        A los fines de este ejercicio, el ID es el número de tarjeta.
        """
        return self.tarjetas[self.tarjetas['TarjetaNumero'] == int(id_tarjeta)]

    def leer_tarjetas_activas(self):
        """ Devuelve todas las tarjetas activas en un DataFrame """
        return self.tarjetas[self.tarjetas['Activa'] == 1]

    def leer_tarjetas_inactivas(self):
        """ Devuelve todas las tarjetas inactivas en un DataFrame """
        return self.tarjetas[self.tarjetas['Activa'] == 0]

    def leer_tarjetas_asignadas(self):
        """ Devuelve todas las tarjetas asignadas en un DataFrame """
        return self.tarjetas[self.tarjetas['TitularDocumento'] != 0]

    def leer_tarjetas_no_asignadas(self):
        """ Devuelve todas las tarjetas no asignadas en un DataFrame """
        return self.tarjetas[self.tarjetas['TitularDocumento'] == 0]

    def leer_tarjetas_titular(self, id_titular):
        """ Devuelve el titular de la tarjeta con el ID especificado """
        return self.tarjetas[self.tarjetas['TitularDocumento'] == int(id_titular)]

    def leer_tarjetas_activas_titular(self, id_titular):
        """ Devuelve todas las tarjetas activas del titular """
        return self.tarjetas[(self.tarjetas['TitularDocumento'] == int(id_titular)) & (self.tarjetas['Activa'] == 1)]

    def leer_tarjetas_inactivas_titular(self, id_titular):
        """ Devuelve todas las tarjetas inactivas del titular """
        return self.tarjetas[(self.tarjetas['TitularDocumento'] == int(id_titular)) & (self.tarjetas['Activa'] == 0)]

    def leer_tarjetas(self):
        """ Devuelve todas las tarjetas en un DataFrame """
        return self.tarjetas

    # ─── (U) ACTUALIZAR ──────────────────────────────────────────────────────
    def actualizar_tarjeta(self, id_tarjeta, tarjeta_numero, tarjeta_tipo, titular_documento, saldo_pesos,
                           saldo_dolares, fecha_otorgamiento, fecha_vencimiento, activa):
        """ Actualiza los datos de la tarjeta """
        for index in self.tarjetas.index:
            if self.tarjetas.loc[index, 'TarjetaNumero'] == int(id_tarjeta):
                self.tarjetas.loc[index, 'TarjetaNumero'] = tarjeta_numero
                self.tarjetas.loc[index, 'TarjetaTipo'] = tarjeta_tipo
                self.tarjetas.loc[index, 'TitularDocumento'] = titular_documento
                self.tarjetas.loc[index, 'SaldoPesos'] = saldo_pesos
                self.tarjetas.loc[index, 'SaldoDolares'] = saldo_dolares
                self.tarjetas.loc[index, 'FechaOtorgamiento'] = fecha_otorgamiento
                self.tarjetas.loc[index, 'FechaVencimiento'] = fecha_vencimiento
                self.tarjetas.loc[index, 'Activa'] = activa
        self.guardar_tarjeta()

    # ─── (D) BORRAR ──────────────────────────────────────────────────────────
    def borrar_tarjeta(self, id_tarjeta):
        """ Borra la tarjeta con el ID especificado """
        for index in self.tarjetas.index:
            if self.tarjetas.loc[index, 'TarjetaNumero'] == int(id_tarjeta):
                self.tarjetas.loc[index, 'Activa'] = '0'
        self.guardar_tarjeta()
