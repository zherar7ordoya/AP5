"""
  @title        Gestor de Tarjetas de Crédito
  @description  Implementación de ABM contra archivo CSV
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import pandas

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

    def leer_tarjetas(self):
        """ Devuelve todas las tarjetas en un DataFrame """
        return self.tarjetas

    def leer_titular(self, id_titular):
        """
        Devuelve el titular con el ID especificado.
        A los fines de este ejercicio, el ID es el número de documento.
        """
        return self.titulares[self.titulares['DocumentoNumero'] == int(id_titular)]

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
