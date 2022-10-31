"""
  @title        MI PROGRAMA EN PYTHON v1.0
  @description  Información en pantalla pedida por el ejercicio
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

import csv_abm_tarjetas
import csv_abm_titulares


# ─── MÉTODO ESTÁTICO ─────────────────────────────────────────────────────────

def mostrar():
    tarjetas = csv_abm_tarjetas.ABMTarjetas()
    titulares = csv_abm_titulares.ABMTitulares()

    print()

    for index in titulares.titulares.index:
        apellido = titulares.titulares.loc[index, "Apellido"]
        nombre = titulares.titulares.loc[index, "Nombre"]
        documento_tipo = titulares.titulares.loc[index, "DocumentoTipo"]
        documento_numero = titulares.titulares.loc[index, "DocumentoNumero"]
        print(
            f"\t{BColors.OKGREEN}{BColors.BOLD}Titular:{BColors.ENDC} {apellido}, {nombre} ({documento_tipo} {documento_numero})")

        for index_tarjeta in tarjetas.tarjetas.index:
            if tarjetas.tarjetas.loc[index_tarjeta, "TitularDocumento"] == int(documento_numero):
                tarjeta_numero = tarjetas.tarjetas.loc[index_tarjeta, "TarjetaNumero"]
                otorgamiento = tarjetas.tarjetas.loc[index_tarjeta, "FechaOtorgamiento"]
                vencimiento = tarjetas.tarjetas.loc[index_tarjeta, "FechaVencimiento"]
                tipo = tarjetas.tarjetas.loc[index_tarjeta, "TarjetaTipo"]
                saldo_pesos = tarjetas.tarjetas.loc[index_tarjeta, "SaldoPesos"]
                saldo_dolares = tarjetas.tarjetas.loc[index_tarjeta, "SaldoDolares"]
                print(
                    f"\t\t{BColors.OKCYAN} Tarjeta:{BColors.ENDC} {tarjeta_numero} ({otorgamiento} a {vencimiento}) {tipo} \t$ {saldo_pesos} \tU$S {saldo_dolares}")

        print("")


# ─── CLASE MOTORA ────────────────────────────────────────────────────────────

class BColors:
    HEADER = '\033[95m'
    OKBLUE = '\033[94m'
    OKCYAN = '\033[96m'
    OKGREEN = '\033[92m'
    WARNING = '\033[93m'
    FAIL = '\033[91m'
    ENDC = '\033[0m'
    BOLD = '\033[1m'
    UNDERLINE = '\033[4m'
