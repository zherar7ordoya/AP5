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
        input("Pulse ENTER para continuar...")

    def baja_tarjeta(self):
        tarjeta_numero = input("Número de Tarjeta: ")
        self.tarjetas.borrar_tarjeta(tarjeta_numero)
        input("Pulse ENTER para continuar...")

    def modifica_tarjeta(self):
        tarjeta_numero = input("Número de Tarjeta: ")
        titular_documento = input("Documento del Titular: ")
        saldo_pesos = input("Saldo en Pesos: ")
        saldo_dolares = input("Saldo en Dólares: ")
        fecha_otorgamiento = input("Fecha de Otorgamiento: ")
        fecha_vencimiento = input("Fecha de Vencimiento: ")
        self.tarjetas.actualizar_tarjeta(
            tarjeta_numero,
            titular_documento,
            saldo_pesos,
            saldo_dolares,
            fecha_otorgamiento,
            fecha_vencimiento)
        input("Pulse ENTER para continuar...")

    # ─── CRUD TITULARES ──────────────────────────────────────────────────────
    def alta_titular(self):
        nombre = input("Nombre: ")
        apellido = input("Apellido: ")
        documento_tipo = input("Tipo de Documento: ")
        documento_numero = input("Número de Documento: ")
        self.titulares.crear_titular(nombre, apellido, documento_tipo, documento_numero)
        input("Pulse ENTER para continuar...")

    def baja_titular(self):
        titular_documento = input("Documento del Titular: ")
        self.titulares.borrar_titular(titular_documento)
        input("Pulse ENTER para continuar...")

    def modifica_titular(self):
        id_titular = input("Número de Documento del Titular: ")
        nombre = input("Nombre: ")
        apellido = input("Apellido: ")
        documento_tipo = input("Tipo de Documento: ")
        self.titulares.actualizar_titular(id_titular, nombre, apellido, documento_tipo)
        input("Pulse ENTER para continuar...")

    # ─── ASIGNACIONES ────────────────────────────────────────────────────────
    def asignar_tarjeta(self):
        print()
        print(self.tarjetas.leer_tarjetas_no_asignadas())
        print()
        print(self.titulares.leer_titulares_activos())
        print()
        id_tarjeta = input("Número de Tarjeta: ")
        id_titular = input("Número de Documento del Titular: ")
        saldo_pesos = input("Saldo en Pesos: ")
        saldo_dolares = input("Saldo en Dólares: ")
        self.asignaciones.asignar_tarjeta(id_tarjeta, id_titular, saldo_pesos, saldo_dolares)
        input("Pulse ENTER para continuar...")

    def desasignar_tarjeta(self):
        print(self.tarjetas.leer_tarjetas_asignadas())
        tarjeta_numero = input("Número de Tarjeta: ")
        self.asignaciones.desasignar_tarjeta(tarjeta_numero)
        input("Pulse ENTER para continuar...")

    # ─── CONSUMOS ────────────────────────────────────────────────────────────
    def consumo_pesos(self):
        tarjeta_numero = input("Número de Tarjeta: ")
        pesos = input("Pesos: ")
        if int(pesos) > 10000:
            print("El monto máximo de consumo en pesos es de $10.000")
            return
        else:
            self.consumos.consumo_pesos(tarjeta_numero, pesos)
        input("Pulse ENTER para continuar...")

    def consumo_dolares(self):
        tarjeta_numero = input("Número de Tarjeta: ")
        dolares = input("Dólares: ")
        if int(dolares) > 100:
            print("El monto máximo de consumo en dólares es de $100")
            return
        else:
            self.consumos.consumo_dolares(tarjeta_numero, dolares)
        input("Pulse ENTER para continuar...")

    # ─── PAGOS ───────────────────────────────────────────────────────────────
    def pago_pesos(self):
        tarjeta_numero = input("Número de Tarjeta: ")
        pesos = input("Pesos: ")

        prefijo = tarjeta_numero[:4]
        if prefijo == "9999":       # Platinum
            pesos = int(pesos) * 1.1
        elif prefijo == "8888":     # Gold
            pesos = int(pesos) * 1.2
        elif prefijo == "7777":     # Plata
            pesos = int(pesos) * 1.3

        self.pagos.pago_pesos(tarjeta_numero, pesos)
        input("Pulse ENTER para continuar...")

    def pago_dolares(self):
        tarjeta_numero = input("Número de Tarjeta: ")
        dolares = input("Dólares: ")

        prefijo = tarjeta_numero[:4]
        if prefijo == "9999":       # Platinum
            dolares = int(dolares) * 1.01
        elif prefijo == "8888":     # Gold
            dolares = int(dolares) * 1.02
        elif prefijo == "7777":     # Plata
            dolares = int(dolares) * 1.03

        self.pagos.pago_dolares(tarjeta_numero, dolares)
        input("Pulse ENTER para continuar...")
