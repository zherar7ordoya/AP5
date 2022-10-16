"""
  @title        PARCIAL 1
  @description  Gestor de tarjetas de crédito
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import archivo_csv

# ─── PRUEBAS PRELIMINARES ────────────────────────────────────────────────────
# import os
# print(os.getcwd())

# df = pandas.read_csv(ARCHIVO_TITULARES)
# print(df)

# print(len(df.columns))    ES 4
# print(len(df.index))      ES 6

# AGREGAR REGISTRO
# registro = ['Claudia', 'Tordoya', 'DNI', '32724632', '1']
# df.loc[len(df.index)] = registro  # type: ignore

# MODIFICAR REGISTRO
# for index in df.index:
#    if df.loc[index, 'DocumentoNumero'] == int('33777420'):
#        df.loc[index, 'DocumentoNumero'] = '22777420'

# GUARDAR REGISTRO
# df.to_csv(ARCHIVO_TITULARES, index=False)

# LEER REGISTRO
# df = pandas.read_csv(ARCHIVO_TITULARES)

# MOSTRAR REGISTRO
# print(df)
# ─────────────────────────────────────────────────────────────────────────────

titulares = archivo_csv.ABM()
tarjetas = archivo_csv.ABM()

# --- C -----------------------------------------------------------------------
# print(tarjetas.leer_tarjetas())
# print(titulares.leer_titulares())

siguiente_tarjeta = len(tarjetas.leer_tarjetas().index)

tarjetas.crear_tarjeta(str(9999000000000000 + siguiente_tarjeta), 'Platinum')
# titulares.crear_titular('Rodolfo', 'Tordoya', 'LE', '8123999', '1')


# --- R -----------------------------------------------------------------------
# print(tarjetas.leer_tarjetas())
# print(titulares.leer_titulares())

# print(tarjetas.leer_tarjeta('9999000000000000'))
# print(titulares.leer_titular('22777420'))

# --- U -----------------------------------------------------------------------
# print(tarjetas.leer_tarjetas())
# print(titulares.leer_titulares())
#
# print("\nACTUALIZANDO... \n")
#
# tarjetas.actualizar_tarjeta('9999000000000000', '9999000000000000', 'Platinum', '22777420',
#                             '66444.12', '259.23', '2021-09-18', '2025-09-18', '1')
# tarjetas.actualizar_tarjeta('8888000000000001', '8888000000000001', 'Gold', '22777420',
#                             '53019.34', '574.45', '2021-05-09', '2025-05-09', '1')
# tarjetas.actualizar_tarjeta('7777000000000002', '7777000000000002', 'Plata', '22777420',
#                             '42400.56', '793.67', '2022-07-15', '2026-07-15', '1')
# titulares.actualizar_titular('22777420', 'Gerardo', 'Tordoya', 'DNI', '22777420', '1')
# --- D -----------------------------------------------------------------------
# print(tarjetas.leer_tarjetas())
# print(titulares.leer_titulares())

# Está hecho en UPDATE (ya que se actualiza el estado a 0): borrado lógico.

# tarjetas.borrar_tarjeta('8888000000000001')
# titulares.borrar_titular('22777420')

# --- TESTS -------------------------------------------------------------------
print(tarjetas.leer_tarjetas())
print(titulares.leer_titulares())
