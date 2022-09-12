#!/usr/bin/env python

""" *------------------>= [DESCRIPCIÓN DE ESTE MÓDULO] <=----------------------*
Ejercicio del banco (en estructurada) en Python.
"""
__author__ = "Gerardo Tordoya"
__date__ = "2022/09/12"

# *------------------------->= [Run Forest, run!] <=---------------------------*

import sys

SALDO_COMPROBADO = 2000
SALDO_AHORRO = 500

while 1:
    print("""
    ________________________________
    Press 1--> Para retiro
    Press 2--> Para depósito
    Press 3--> Para transferencia
    Press 4--> Para estado de cuenta
    press 5--> Para salir
    ________________________________
    """)
    ingreso = input("Ingrese opción: ")


    match ingreso:
        case "1":
            amt = int (input("Enter amount to be withdraw_from_checking account"))
            SALDO_COMPROBADO -= amt
        case "2":
            amt = int (input("Enter amount to be deposit_in_checking account"))
            SALDO_COMPROBADO += amt
        case "3":
            amt = int (input("Enter amount to be transfer_frm_checking_to_saving account"))
            SALDO_AHORRO += amt
            SALDO_COMPROBADO -= amt
        case "4":
            print ("\nChecking Balance--> ", SALDO_COMPROBADO)
            print ("Saving Balance--> ", SALDO_AHORRO)
        case "5":
            print ("\nSaliendo...\n")
            sys.exit(0)
        case _:
            print ("\nIngrese una opción válida.\n")


    # if ingreso == '1':
    #     amt = int (input("Enter amount to be withdraw_from_checking account"))
    #     SALDO_COMPROBADO -= amt

    # elif ingreso == '2':
    #     amt = int (input("Enter amount to be deposit_in_checking account"))
    #     SALDO_COMPROBADO += amt

    # elif ingreso == '3':
    #     amt = int (input("Enter amount to be transfer_frm_checking_to_saving account"))
    #     SALDO_AHORRO += amt
    #     SALDO_COMPROBADO -= amt
    # elif ingreso == '4':
    #     print ("Checking Balance--> ", SALDO_COMPROBADO)
    #     print ("Saving Balance--> ", SALDO_AHORRO)
    # elif ingreso == '5':
    #     print ("Exiting...")
    #     sys.exit(0)
    # else:
    #     print ("Please Enter valid choice    Try again...")
