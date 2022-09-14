#!/usr/bin/env python
""" *------------------>= [DESCRIPCIÓN DE ESTE MÓDULO] <=----------------------*
Ejercicio del banco (usando estructurada).
Archivos consultados:
                    Menu.psc
                    Mayores.psc
                    Sucursales.psc
                    Subprocesos.psc
NOTA: Recordar configurar arreglos a base 0.
"""
__author__ = "Gerardo Tordoya"
__date__ = "2022-09-XX"

# *------------------------->= [Run Forest, run!] <=---------------------------*



# """ *------------------------>= [PROCEDIMIENTOS] <=----------------------------*
# En python no hay forma de elegir como pasar una variable a una
# funcion (por referencia o por valor). Las variables "inmutables"
# (str, int, float, bool) se pasan siempre por copia mientras que
# las demas (listas, objetos, etc.) se pasan siempre por referencia.
# Esto coincide con el comportamiento por defecto en pseint, pero
# cuando utiliza las palabras clave "Por Referencia" para
# alterarlo la traducción no es correcta.

# INFORMAR

def detallar_cuenta():
    """ Imprime los datos de la cuenta """
    print("")
    print("Datos de la Cuenta")
    print("------------------")
    print(cliente[0], " su saldo es: ")
    for i in range(2):
        print("En la cuenta ",i," hay $ ",cuentas[i])
    print("")

# CLIENTES
def alta_cliente():
    """ Alta de un nuevo cliente """
    print("Usted ya está dado de alta.")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

def baja_cliente():
    """ Baja de un cliente """
    print("No es posible aún realizar esa operación.")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

def modificacion_cliente(cadena):
    """ Modificación de datos del cliente
        stackoverflow.com/a/55992372/14009797
        Mañoso!
    """
    print(cliente[0], "ingrese su nuevo nombre (y apellido): ")
    cadena[0] = input()
    print("Operación exitosa.")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

# CUENTAS
def alta_cuenta():
    """ Alta de una nueva cuenta """
    print("No es posible aún realizar esa operación.")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

def baja_cuenta():
    """ Baja de una cuenta """
    print("No es posible aún realizar esa operación.")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

def modificacion_cuenta():
    """ Modificación de datos de una cuenta """
    print("Solo puede modificar los saldos de sus cuentas.")
    print("Para ello, elija una operación del menú principal.")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

# OPERACIONES
def depositar():
    """ Deposito de dinero en una cuenta """
    importe = int()
    print("Ingrese importe a depositar: ")
    importe = int(input())
    cuentas[CUENTA] = importe
    print("Operación exitosa.")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

def retirar():
    """ Retiro de dinero de una cuenta """
    importe = int()
    print("Ingrese importe a retirar: ")
    importe = int(input())
    if cuentas[CUENTA]>importe:
        cuentas[CUENTA] = cuentas[CUENTA]-importe
        print("Operación exitosa.")
    else:
        print("Saldo insuficiente para hacer un retiro")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

def transferir():
    """ Transferencia entre cuentas del mismo cliente """
    importe = int()
    print("Ingrese importe a transferir: ")
    importe = int(input())
    if cuentas[CUENTA]>importe:
        if CUENTA==0:
            cuentas[CUENTA] = cuentas[CUENTA]-importe
            cuentas[1] = cuentas[1]+importe
            print("Operación exitosa.")
        else:
            cuentas[CUENTA] = cuentas[CUENTA]-importe
            cuentas[0] = cuentas[0]+importe
            print("Operación exitosa.")
    else:
        print("Saldo insuficiente para hacer un retiro")
    print("Presione un tecla para continuar...")
    input() # a diferencia del pseudocódigo, espera un Enter, no cualquier tecla
    print("") # no hay forma directa de borrar la pantalla con Python estandar

################################################################################


if __name__ == '__main__':

    import os
    os.system('CLS')

    # GLOBALES
    CUENTA = int()
    cuentas = [int() for ind0 in range(2)]

    # INICIALIZACIÓN
    print("")
    print("Ingrese su nombre (y apellido): ")
    nya = input()
    cliente = [nya]
    CUENTA = 0
    cuentas[0] = 0
    cuentas[1] = 0

    detallar_cuenta()

    while True: # no hay 'repetir' en python
        print("Operatoria Bancaria")
        print("-------------------")
        print("Seleccione una opción:")
        print("1) Alta de Cliente")
        print("2) Baja de Cliente")
        print("3) Modificación de Cliente")
        print("4) Alta de Cuenta")
        print("5) Baja de Cuenta")
        print("6) Modificación de Cuenta")
        print("7) Realizar Depósito")
        print("8) Realizar Retiro")
        print("9) Realizar Transferencia")
        print("10) Salir")
        operacion = float(input())
        if operacion==1:
            # Alta de Cliente
            alta_cliente()
            detallar_cuenta()
        elif operacion==2:
            # Baja de Cliente
            baja_cliente()
            detallar_cuenta()
        elif operacion==3:
            # Modificación de Cliente
            modificacion_cliente(cliente)
            detallar_cuenta()
        elif operacion==4:
            # Alta de Cuenta
            alta_cuenta()
            detallar_cuenta()
        elif operacion==5:
            # Baja de Cuenta
            baja_cuenta()
            detallar_cuenta()
        elif operacion==6:
            # Modificación de Cuenta
            modificacion_cuenta()
            detallar_cuenta()
        elif operacion==7:
            # Realizar Depósito
            print("Ingrese CUENTA sobre la que operar (0 ó 1): ")
            CUENTA = int(input())
            depositar()
            detallar_cuenta()
        elif operacion==8:
            # Realizar Retiro
            print("Ingrese CUENTA sobre la que operar (0 ó 1): ")
            CUENTA = int(input())
            retirar()
            detallar_cuenta()
        elif operacion==9:
            # Realizar Transferencia
            print("Ingrese CUENTA sobre la que operar (0 ó 1): ")
            CUENTA = int(input())
            transferir()
            detallar_cuenta()
        elif operacion==10:
            # Salir
            print("Gracias y vuelva pronto.")
            print("Saliendo...")
            print("Ahora puede cerrar esta ventana.")
        else:
            print("Ingrese una opción válida")
        if operacion==10:
            break
