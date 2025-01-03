"""
  @title        MI PROGRAMA EN PYTHON v1.0
  @description  Implementación ABM archivo CSV para titulares
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import pandas

ARCHIVO_TITULARES = 'titulares.csv'


class ABMTitulares:
    """ CRUD para leer y escribir el archivo CSV de titulares """

    def __init__(self):
        """ Constructor """
        self.titulares = pandas.read_csv(ARCHIVO_TITULARES)

    # ─── PERSISTENCIA ────────────────────────────────────────────────────────
    def guardar_titular(self):
        """ Guarda los titulares en el archivo CSV """
        self.titulares.to_csv(ARCHIVO_TITULARES, index=False)

    # ─── (C) CREAR ───────────────────────────────────────────────────────────
    def crear_titular(self, nombre, apellido, documento_tipo, documento_numero):
        """ Crea un nuevo titular """
        titular = {
            'Nombre': nombre,
            'Apellido': apellido,
            'DocumentoTipo': documento_tipo,
            'DocumentoNumero': int(documento_numero),
            'Activo': 1
        }
        if self.titulares[self.titulares['DocumentoNumero'] == int(documento_numero)].empty:
            self.titulares = self.titulares.append(titular, ignore_index=True)
            self.guardar_titular()
            print('Titular creado con éxito')
        else:
            print('El titular ya existe.')

    # ─── (R) LEER ────────────────────────────────────────────────────────────
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
    def actualizar_titular(self, id_titular, nombre, apellido, documento_tipo):
        """ Actualiza los datos del titular """
        conteo = 0
        for index in self.titulares.index:
            if self.titulares.loc[index, 'DocumentoNumero'] == int(id_titular):
                self.titulares.loc[index, 'Nombre'] = nombre
                self.titulares.loc[index, 'Apellido'] = apellido
                self.titulares.loc[index, 'DocumentoTipo'] = documento_tipo
                conteo += 1
        self.guardar_titular()
        if conteo == 0:
            print('No se encontró el titular.')
        else:
            print('Titular actualizado con éxito.')

    # ─── (D) BORRAR ──────────────────────────────────────────────────────────
    def borrar_titular(self, id_titular):
        """ Borra el titular con el ID especificado """
        conteo = 0
        for index in self.titulares.index:
            if self.titulares.loc[index, 'DocumentoNumero'] == int(id_titular):
                if self.titulares.loc[index, 'Activo'] == 0:
                    print('El titular ya ha sido eliminado con anterioridad.')
                    return
                self.titulares.loc[index, 'Activo'] = '0'
                conteo += 1
        self.guardar_titular()
        if conteo == 0:
            print('No se encontró el titular.')
        else:
            print('Titular borrado con éxito.')
