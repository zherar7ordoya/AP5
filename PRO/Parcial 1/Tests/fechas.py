"""
  @title        Gestor de Tarjetas de Crédito
  @description  Herramientas para trabajar con fechas
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

from datetime import date


# Pongo "años" en el nombre del método para que no tire error (non-ASCII character)
def agregar_years(desde, years):
    """ Agrega años a una fecha y devuelve la fecha resultante """
    try:
        return desde.replace(year=desde.year + years)
    except ValueError:
        # Para el caso de febrero 29
        return desde.replace(year=desde.year + years, day=28)


# --- TESTS -------------------------------------------------------------------

# # Indicando el año
# inicia = date(2023, 9, 7)
# print(inicia)  # 2023-09-07
# hasta = agregar_years(inicia, 4)
# print(hasta)   # 2027-09-07
#
# # Con fecha actual
# inicia = date.today()
# print(inicia)  # 2022-10-16
# hasta = agregar_years(inicia, 4)
# print(hasta)   # 2026-10-16
