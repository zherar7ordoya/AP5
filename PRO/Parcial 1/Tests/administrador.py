"""
  @title        GESTOR DE TARJETAS DE CRÉDITO
  @description  Lógica de la aplicación
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import csv_abm_tarjetas
import csv_abm_titulares


class Administrador:
    def __init__(self):
        self.titulares = csv_abm_titulares.ABMTitulares()
        self.tarjetas = csv_abm_tarjetas.ABMTarjetas()

    # ─── CRUD TARJETAS ───────────────────────────────────────────────────────
    def crear_tarjeta(self):
        tarjeta_numero = input("Número de Tarjeta: ")
        tarjeta_tipo = input("Tipo de Tarjeta: ")
        self.tarjetas.crear_tarjeta(tarjeta_numero, tarjeta_tipo)

    def leer_tarjeta(self, numero):
        return self.tarjetas.leer_tarjeta(numero)

    def leer_tarjetas(self):
        return self.tarjetas.leer_tarjetas()

    def actualizar_tarjeta(self, numero, tipo):
        self.tarjetas.actualizar_tarjeta(numero, tipo)

    # ─── CRUD TITULARES ──────────────────────────────────────────────────────
    def crear_titular(self, nombre, apellido, documento_tipo, documento_numero, tarjeta_id):
        self.titulares.crear_titular(nombre, apellido, documento_tipo, documento_numero, tarjeta_id)

    def leer_titular(self, documento_numero):
        return self.titulares.leer_titular(documento_numero)

    def leer_titulares(self):
        return self.titulares.leer_titulares()

    def actualizar_titular(self, documento_numero, nombre, apellido, documento_tipo, tarjeta_id):
        self.titulares.actualizar_titular(documento_numero, nombre, apellido, documento_tipo, tarjeta_id)


    # ─── ASIGNACIONES ────────────────────────────────────────────────────────

    # ─── CONSUMOS ────────────────────────────────────────────────────────────

    # ─── PAGOS ───────────────────────────────────────────────────────────────









