"""
  @title        MI PROGRAMA EN PYTHON v1.0
  @description  Lógica de la aplicación
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import csv_abm_tarjetas
import csv_abm_titulares
import csv_asignaciones
import csv_consumos
import csv_pagos


class Operacion:
    def __init__(self):
        self.titulares = csv_abm_titulares.ABMTitulares()
        self.tarjetas = csv_abm_tarjetas.ABMTarjetas()
        self.asignaciones = csv_asignaciones.Asignacion()
        self.consumos = csv_consumos.Consumo()
        self.pagos = csv_pagos.Pago()

    # ─── CRUD TARJETAS ───────────────────────────────────────────────────────
    def alta_tarjeta(self):
        tarjeta_tipo = input("Tipo de Tarjeta: ")
        siguiente_tarjeta = len(self.tarjetas.leer_tarjetas().index)
        if tarjeta_tipo == "Platinum":
            self.tarjetas.crear_tarjeta(str(9999000000000000 + siguiente_tarjeta), 'Platinum')
            print(f"Tarjeta {9999000000000000 + siguiente_tarjeta} creada con éxito.")
        elif tarjeta_tipo == "Gold":
            self.tarjetas.crear_tarjeta(str(8888000000000000 + siguiente_tarjeta), 'Gold')
            print(f"Tarjeta {8888000000000000 + siguiente_tarjeta} creada con éxito.")
        elif tarjeta_tipo == "Plata":
            self.tarjetas.crear_tarjeta(str(7777000000000000 + siguiente_tarjeta), 'Plata')
            print(f"Tarjeta {7777000000000000 + siguiente_tarjeta} creada con éxito.")
        else:
            print("Tipo de tarjeta no válido.")

    def baja_tarjeta(self):
        pass

    def modifica_tarjeta(self):
        pass

    # ─── CRUD TITULARES ──────────────────────────────────────────────────────
    def alta_titular(self):
        pass

    def baja_titular(self):
        pass

    def modifica_titular(self):
        pass

    # ─── ASIGNACIONES ────────────────────────────────────────────────────────
    def asignar_tarjeta(self):
        pass

    def desasignar_tarjeta(self):
        pass

    # ─── CONSUMOS ────────────────────────────────────────────────────────────
    def consumo_pesos(self):
        pass

    def consumo_dolares(self):
        pass

    # ─── PAGOS ───────────────────────────────────────────────────────────────
    def pago_pesos(self):
        pass

    def pago_dolares(self):
        pass
