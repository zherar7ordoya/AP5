"""
  @title        Gestor de Tarjetas de Crédito
  @description  Implementación de ABM contra archivo CSV
  @author       Gerardo Tordoya
  @date         2022-10-16
  @remark       Por una cuestión de practicidad, se implementa en una sola clase
                tanto métodos genéricos como específicos para cada entidad.
"""

import pandas
from decimal import Decimal
from datetime import date
import fechas

ARCHIVO_TARJETAS = 'tarjetas.csv'
ARCHIVO_TITULARES = 'titulares.csv'


class ABM:
    """ Herramienta para leer y escribir archivos CSV """

    def __init__(self):
        """ Constructor """
        self.tarjetas = pandas.read_csv(ARCHIVO_TARJETAS)
        self.titulares = pandas.read_csv(ARCHIVO_TITULARES)

    def guardar_tarjeta(self):
        """ Guarda las tarjetas en el archivo CSV """
        self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)

    def guardar_titular(self):
        """ Guarda los titulares en el archivo CSV """
        self.titulares.to_csv(ARCHIVO_TITULARES, index=False)

    def asignar_tarjeta(self, id_tarjeta, id_titular, saldo_pesos, saldo_dolares):
        """ Asigna una tarjeta a un titular """
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'TitularDocumento'] = int(id_titular)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'SaldoPesos'] = Decimal(saldo_pesos)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'SaldoDolares'] = Decimal(saldo_dolares)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaOtorgamiento'] = date.today()
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaVencimiento'] = fechas.agregar_years(date.today(), 4)
        self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'Activa'] = 1
        self.guardar_tarjeta()

    def desasignar_tarjeta(self, id_tarjeta, id_titular):
        """ Desasigna una tarjeta a un titular """
        if self.tarjetas[(self.tarjetas['TarjetaNumero'] == int(id_tarjeta)) & (self.tarjetas['SaldoPesos'] == 0) & (self.tarjetas['SaldoDolares'] == 0)].empty:
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'TitularDocumento'] = 0
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaOtorgamiento'] = 0
            self.tarjetas.loc[self.tarjetas['TarjetaNumero'] == int(id_tarjeta), 'FechaVencimiento'] = 0
            self.guardar_tarjeta()
        else:
            print('No se puede desasignar la tarjeta porque tiene saldo.')


    # ─── (C) CREAR ───────────────────────────────────────────────────────────
    def crear_tarjeta(self, tarjeta_numero, tarjeta_tipo):
        """ Crea una nueva tarjeta """
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

    def crear_titular(self, nombre, apellido, documento_tipo, documento_numero, activo):
        """ Crea un nuevo titular """
        titular = {
            'Nombre': nombre,
            'Apellido': apellido,
            'DocumentoTipo': documento_tipo,
            'DocumentoNumero': documento_numero,
            'Activo': activo
        }
        self.titulares = self.titulares.append(titular, ignore_index=True)
        self.guardar_titular()

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

    def leer_titular(self, id_titular):
        """
        Devuelve el titular con el ID especificado.
        A los fines de este ejercicio, el ID es el número de documento.
        """
        return self.titulares[self.titulares['DocumentoNumero'] == int(id_titular)]

    def leer_titulares_activos(self):
        """ Devuelve todos los titulares activos en un DataFrame """
        return self.titulares[self.titulares['Activo'] == 1]

    def leer_titulares_inactivos(self):
        """ Devuelve todos los titulares inactivos en un DataFrame """
        return self.titulares[self.titulares['Activo'] == 0]

    def leer_titulares(self):
        """ Devuelve todos los titulares en un DataFrame """
        return self.titulares

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

    def actualizar_titular(self, id_titular, nombre, apellido, documento_tipo, documento_numero, activo):
        """ Actualiza los datos del titular """
        for index in self.titulares.index:
            if self.titulares.loc[index, 'DocumentoNumero'] == int(id_titular):
                self.titulares.loc[index, 'Nombre'] = nombre
                self.titulares.loc[index, 'Apellido'] = apellido
                self.titulares.loc[index, 'DocumentoTipo'] = documento_tipo
                self.titulares.loc[index, 'DocumentoNumero'] = documento_numero
                self.titulares.loc[index, 'Activo'] = activo
        self.guardar_titular()

    # ─── (D) BORRAR ──────────────────────────────────────────────────────────
    def borrar_tarjeta(self, id_tarjeta):
        """ Borra la tarjeta con el ID especificado """
        for index in self.tarjetas.index:
            if self.tarjetas.loc[index, 'TarjetaNumero'] == int(id_tarjeta):
                self.tarjetas.loc[index, 'Activa'] = '0'
        self.guardar_tarjeta()

    def borrar_titular(self, id_titular):
        """ Borra el titular con el ID especificado """
        for index in self.titulares.index:
            if self.titulares.loc[index, 'DocumentoNumero'] == int(id_titular):
                self.titulares.loc[index, 'Activo'] = '0'
        self.guardar_titular()
