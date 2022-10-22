"""
  @title        MI PROGRAMA EN PYTHON v1.0
  @description  Lógica de la aplicación
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

from dateutil import parser

import csv_abm_tarjetas
import csv_abm_titulares
import csv_asignaciones
import csv_consumos
import csv_pagos
import informacion


class Operacion:
    def __init__(self):
        self.titulares = csv_abm_titulares.ABMTitulares()
        self.tarjetas = csv_abm_tarjetas.ABMTarjetas()
        self.asignaciones = csv_asignaciones.Asignacion()
        self.consumos = csv_consumos.Consumo()
        self.pagos = csv_pagos.Pago()

    # ─── CRUD TARJETAS ───────────────────────────────────────────────────────
    def alta_tarjeta(self):
        print()

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
        input("\nPulse ENTER para continuar...")

    def baja_tarjeta(self):
        print()
        print(self.tarjetas.leer_tarjetas_activas())
        print()
        tarjeta_numero = input("Número de Tarjeta: ")

        if tarjeta_numero == "":
            print("El número de tarjeta ingresado no es válido.")
            input("\nPulse ENTER para continuar...")
            return

        if not tarjeta_numero.isdigit():
            print("El número de tarjeta no es válido.")
            input("\nPulse ENTER para continuar...")
            return

        self.tarjetas.borrar_tarjeta(tarjeta_numero)
        input("\nPulse ENTER para continuar...")

    def modifica_tarjeta(self):
        print()
        print(self.tarjetas.leer_tarjetas_activas())
        print()

        tarjeta_numero = input("Número de Tarjeta: ")
        titular_documento = input("Documento del Titular: ")
        saldo_pesos = input("Saldo en Pesos: ")
        saldo_dolares = input("Saldo en Dólares: ")
        fecha_otorgamiento = input("Fecha de Otorgamiento (AAAA-MM-DD): ")
        fecha_vencimiento = input("Fecha de Vencimiento (AAAA-MM-DD): ")

        if tarjeta_numero == "" or titular_documento == "" or saldo_pesos == "" or saldo_dolares == "" or fecha_otorgamiento == "" or fecha_vencimiento == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not tarjeta_numero.isdigit() and not titular_documento.isdigit() and not saldo_pesos.isdigit() and not saldo_dolares.isdigit():
            print("Los datos ingresados no son válidos.")
            input("\nPulse ENTER para continuar...")
            return

        if not bool(parser.parse(fecha_otorgamiento)) and not bool(parser.parse(fecha_vencimiento)):
            print("Las fechas ingresadas no son válidas.")
            input("\nPulse ENTER para continuar...")
            return

        self.tarjetas.actualizar_tarjeta(
            tarjeta_numero,
            titular_documento,
            saldo_pesos,
            saldo_dolares,
            fecha_otorgamiento,
            fecha_vencimiento)
        input("\nPulse ENTER para continuar...")

    # ─── CRUD TITULARES ──────────────────────────────────────────────────────
    def alta_titular(self):
        print()
        nombre = input("Nombre: ")
        apellido = input("Apellido: ")
        documento_tipo = input("Tipo de Documento: ")
        documento_numero = input("Número de Documento: ")

        if nombre == "" or apellido == "" or documento_tipo == "" or documento_numero == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not documento_numero.isdigit():
            print("El número de documento no es válido.")
            input("\nPulse ENTER para continuar...")
            return

        self.titulares.crear_titular(nombre, apellido, documento_tipo, documento_numero)
        input("\nPulse ENTER para continuar...")

    def baja_titular(self):
        print()
        print(self.titulares.leer_titulares_activos())
        print()

        titular_documento = input("Documento del Titular: ")

        if titular_documento == "":
            print("El número de documento ingresado no es válido.")
            input("\nPulse ENTER para continuar...")
            return

        if not titular_documento.isdigit():
            print("El documento ingresado no es válido.")
            input("\nPulse ENTER para continuar...")
            return

        self.titulares.borrar_titular(titular_documento)
        input("\nPulse ENTER para continuar...")

    def modifica_titular(self):
        print()
        print(self.titulares.leer_titulares_activos())
        print()

        id_titular = input("Número de Documento del Titular: ")
        nombre = input("Nombre: ")
        apellido = input("Apellido: ")
        documento_tipo = input("Tipo de Documento: ")

        if id_titular == "" or nombre == "" or apellido == "" or documento_tipo == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not id_titular.isdigit():
            print("El número de documento no es válido.")
            input("\nPulse ENTER para continuar...")
            return

        self.titulares.actualizar_titular(id_titular, nombre, apellido, documento_tipo)
        input("\nPulse ENTER para continuar...")

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

        if id_tarjeta == "" or id_titular == "" or saldo_pesos == "" or saldo_dolares == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not id_tarjeta.isdigit() and not id_titular.isdigit() and not saldo_pesos.isdigit() and not saldo_dolares.isdigit():
            print("Los datos ingresados no son válidos.")
            input("\nPulse ENTER para continuar...")
            return

        self.asignaciones.asignar_tarjeta(id_tarjeta, id_titular, saldo_pesos, saldo_dolares)
        input("\nPulse ENTER para continuar...")

    def desasignar_tarjeta(self):
        print()
        print("\tHistórico de Asignaciones")
        print("\t-------------------------\n")
        print(self.tarjetas.leer_tarjetas_asignadas())
        print()

        tarjeta_numero = input("Número de Tarjeta: ")

        if tarjeta_numero == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not tarjeta_numero.isdigit():
            print("El número de tarjeta no es válido.")
            input("\nPulse ENTER para continuar...")
            return

        self.asignaciones.desasignar_tarjeta(tarjeta_numero)
        input("\nPulse ENTER para continuar...")

    # ─── CONSUMOS ────────────────────────────────────────────────────────────
    def consumo_pesos(self):
        print()
        print(self.tarjetas.leer_tarjetas_activas())
        print()

        tarjeta_numero = input("Número de Tarjeta: ")
        pesos = input("Pesos: ")

        if tarjeta_numero == "" or pesos == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not tarjeta_numero.isdigit() and not pesos.isdigit():
            print("Error: Ingrese un número de tarjeta y un monto válido.")
            input("\nPulse ENTER para continuar...")
            return

        if int(pesos) > 15000:
            print(
                f"\n{informacion.BColors.FAIL}\t El monto máximo de consumo en pesos es de $ 15.000 {informacion.BColors.ENDC}\n")
            input("\nPulse ENTER para continuar...")
            return
        else:
            self.consumos.consumo_pesos(tarjeta_numero, pesos)
        input("\nPulse ENTER para continuar...")

    def consumo_dolares(self):
        print()
        print(self.tarjetas.leer_tarjetas_activas())
        print()

        tarjeta_numero = input("Número de Tarjeta: ")
        dolares = input("Dólares: ")

        if tarjeta_numero == "" or dolares == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not tarjeta_numero.isdigit() and not dolares.isdigit():
            print(f"\n{informacion.BColors.FAIL}\t Los datos ingresados no son válidos {informacion.BColors.ENDC}\n")
            input("\nPulse ENTER para continuar...")
            return

        if int(dolares) > 150:
            print(
                f"\n{informacion.BColors.FAIL}\t El monto máximo de consumo en dólares es de U$S 150 {informacion.BColors.ENDC}\n")
            input("\nPulse ENTER para continuar...")
            return
        else:
            self.consumos.consumo_dolares(tarjeta_numero, dolares)
        input("\nPulse ENTER para continuar...")

    # ─── PAGOS ───────────────────────────────────────────────────────────────
    def pago_pesos(self):
        print()
        print(self.tarjetas.leer_tarjetas_activas())
        print()

        tarjeta_numero = input("Número de Tarjeta: ")
        pesos = input("Pesos: ")

        if tarjeta_numero == "" or pesos == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not tarjeta_numero.isdigit() and not pesos.isdigit():
            print(
                f"\n{informacion.BColors.FAIL}\t El número de tarjeta y el monto deben ser numéricos {informacion.BColors.ENDC}\n")
            input("\nPulse ENTER para continuar...")
            return

        prefijo = tarjeta_numero[:4]
        if prefijo == "9999":  # Platinum
            pesos = int(pesos) * 1.1
        elif prefijo == "8888":  # Gold
            pesos = int(pesos) * 1.2
        elif prefijo == "7777":  # Plata
            pesos = int(pesos) * 1.3
        else:
            print(
                f"\n{informacion.BColors.FAIL}\t Se ha detectado una anomalía. Verifique los datos ingresados. {informacion.BColors.ENDC}\n")
            input("\nPulse ENTER para continuar...")
            return

        print(f"\nTotal con recargo: $ {pesos}\n")
        self.pagos.pago_pesos(tarjeta_numero, pesos)
        input("\nPulse ENTER para continuar...")

    def pago_dolares(self):
        print()
        print(self.tarjetas.leer_tarjetas_activas())
        print()

        tarjeta_numero = input("Número de Tarjeta: ")
        dolares = input("Dólares: ")

        if tarjeta_numero == "" or dolares == "":
            print("No se ingresaron datos.")
            input("\nPulse ENTER para continuar...")
            return

        if not tarjeta_numero.isdigit() and not dolares.isdigit():
            print(
                f"\n{informacion.BColors.FAIL}\t El número de tarjeta y el monto deben ser numéricos {informacion.BColors.ENDC}\n")
            input("\nPulse ENTER para continuar...")
            return

        prefijo = tarjeta_numero[:4]
        if prefijo == "9999":  # Platinum
            dolares = int(dolares) * 1.01
        elif prefijo == "8888":  # Gold
            dolares = int(dolares) * 1.02
        elif prefijo == "7777":  # Plata
            dolares = int(dolares) * 1.03
        else:
            print(
                f"\n{informacion.BColors.FAIL}\t Se ha detectado una anomalía. Verifique los datos ingresados. {informacion.BColors.ENDC}\n")
            input("\nPulse ENTER para continuar...")
            return

        print(f"\nTotal con recargo: U$S {dolares}\n")
        self.pagos.pago_dolares(tarjeta_numero, dolares)
        input("\nPulse ENTER para continuar...")
