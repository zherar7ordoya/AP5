"""
  @title        MI PROGRAMA EN PYTHON v1.0
  @description  Implementación ABM archivo CSV para tarjetas
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import pandas
import datetime

ARCHIVO_TARJETAS = 'tarjetas.csv'


class ABMTarjetas:
    """ CRUD para leer y escribir el archivo CSV de tarjetas """

    def __init__(self):
        """ Constructor """
        self.tarjetas = pandas.read_csv(ARCHIVO_TARJETAS)

    # ─── PERSISTENCIA ────────────────────────────────────────────────────────
    def guardar_tarjeta(self):
        """ Guarda las tarjetas en el archivo CSV """
        self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)

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
        print('Tarjeta creada con éxito.')

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
        return self.tarjetas[(self.tarjetas['TitularDocumento'] == 0) & (self.tarjetas['Activa'] == 1)]

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
    def actualizar_tarjeta(self, id_tarjeta, titular_documento, saldo_pesos,
                           saldo_dolares, fecha_otorgamiento, fecha_vencimiento):
        """ Actualiza los datos de la tarjeta """

        # Validación pedida por el ejercicio.
        try:
            desde = datetime.datetime.strptime(fecha_otorgamiento, '%Y-%m-%d')
            hasta = datetime.datetime.strptime(fecha_vencimiento, '%Y-%m-%d')
        except ValueError:
            print('Las fechas no son válidas.')
            return

        if desde >= hasta:
            print('La fecha de vencimiento no puede ser anterior/igual a la fecha de otorgamiento.')
            return
        # Fin validación pedida por el ejercicio.

        conteo = 0
        for index in self.tarjetas.index:
            if self.tarjetas.loc[index, 'TarjetaNumero'] == int(id_tarjeta):
                self.tarjetas.loc[index, 'TitularDocumento'] = titular_documento
                self.tarjetas.loc[index, 'SaldoPesos'] = saldo_pesos
                self.tarjetas.loc[index, 'SaldoDolares'] = saldo_dolares
                self.tarjetas.loc[index, 'FechaOtorgamiento'] = fecha_otorgamiento
                self.tarjetas.loc[index, 'FechaVencimiento'] = fecha_vencimiento
                conteo += 1
        self.guardar_tarjeta()
        if conteo == 0:
            print('No se encontró la tarjeta especificada.')
        else:
            print('Tarjeta actualizada con éxito.')

    # ─── (D) BORRAR ──────────────────────────────────────────────────────────
    def borrar_tarjeta(self, id_tarjeta):
        """ Borra la tarjeta con el ID especificado """
        conteo = 0
        for index in self.tarjetas.index:
            if self.tarjetas.loc[index, 'TarjetaNumero'] == int(id_tarjeta):
                if self.tarjetas.loc[index, 'Activa'] == 0:
                    print('La tarjeta ya ha sido eliminada con anterioridad.')
                    return
                self.tarjetas.loc[index, 'Activa'] = '0'
                conteo += 1
        self.guardar_tarjeta()
        if conteo == 0:
            print('No se encontró la tarjeta especificada.')
        else:
            print('Tarjeta borrada con éxito.')
