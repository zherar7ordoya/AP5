"""
  @title        Gestor de Tarjetas de Crédito
  @description  Lógica de negocio para el ABM de tarjetas de crédito
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import archivo_csv


class Gestor:
    def __init__(self):
        self.titulares = archivo_csv.ABM()
        self.tarjetas = archivo_csv.ABM()

    def asignar_tarjeta(self, tarjeta_numero: str, titular_documento: str) -> None:
        self.tarjetas.asignar_tarjeta(tarjeta_numero, titular_documento)