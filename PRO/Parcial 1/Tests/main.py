"""
  @title        PARCIAL 1
  @description  Gestor de tarjetas de crédito
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import pandas

ARCHIVO_TARJETAS = 'tarjetas.csv'
ARCHIVO_TITULARES = 'titulares.csv'


class ArchivoCSV:
    """
    Herramienta para leer y escribir archivos CSV
    """

    def __init__(self):
        self.tarjetas = pandas.read_csv(ARCHIVO_TARJETAS)
        self.titulares = pandas.read_csv(ARCHIVO_TITULARES)

    # ─── (C) CREAR ───────────────────────────────────────────────────────────
    # ─── (R) LEER ────────────────────────────────────────────────────────────
    def leer_tarjeta(self, id_tarjeta):
        """
        Devuelve la tarjeta con el ID especificado
        """
        return self.tarjetas[self.tarjetas['TarjetaNumero'] == id_tarjeta]

    def leer_tarjetas(self):
        """
        Devuelve todas las tarjetas en un DataFrame
        """
        return self.tarjetas

    def leer_titular(self, id_titular):
        """
        Devuelve el titular con el ID especificado
        """
        return self.titulares[self.titulares['DocumentoNumero'] == id_titular]

    def leer_titulares(self):
        """
        Devuelve todos los titulares en un DataFrame
        """
        return self.titulares


    # ─── (U) ACTUALIZAR ──────────────────────────────────────────────────────
    # ─── (D) BORRAR ──────────────────────────────────────────────────────────




    def guardar_tarjetas(self):
        """
        Guarda las tarjetas en el archivo CSV
        """
        self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)

    def guardar_titulares(self):
        """
        Guarda los titulares en el archivo CSV
        """
        self.titulares.to_csv(ARCHIVO_TITULARES, index=False)




df = pandas.read_csv(ARCHIVO_TITULARES)
print(df)

# print(len(df.columns))    ES 4
# print(len(df.index))      ES 6

# registro = ['Claudia', 'Tordoya', 'DNI', '32724632', '1']
# df.loc[len(df.index)] = registro  # type: ignore

for index in df.index:
    if df.loc[index, 'DocumentoNumero'] == int('33777420'):
        df.loc[index, 'DocumentoNumero'] = '22777420'

df.to_csv(ARCHIVO_TITULARES, index=False)
df = pandas.read_csv(ARCHIVO_TITULARES)
print(df)
