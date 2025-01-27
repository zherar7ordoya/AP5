"""
  @title        CAJERO BANCARIO
  @description  Ejercicio del banco con Programación Estructurada
  @author       Gerardo Tordoya
  @date         2022-08-26
  @credits      * * [] * *
"""

# ┌──────────────────────────────────────────────────────────────────────────┐
# │ PROCEDIMIENTOS                                                           │
# └──────────────────────────────────────────────────────────────────────────┘

def detallar_cuenta():
    """ Imprime los datos de la cuenta """
    os.system('CLS')
    print_center("SALDOS DE LA CUENTA\n")
    print(cliente[0], "\n")
    for i in range(2):
        print("\tSaldo cuenta", i, "en $", cuentas[i])
    print("")
    print("Seleccione Opción")

def pausar_pantalla():
    """ Pausa la pantalla """
    print("Presione una tecla para continuar...")
    input()
    os.system('CLS')


# ─── Clientes ─────────────────────────────────────────────────────────────────

def alta_cliente():
    """ Alta de un nuevo cliente """
    print("Usted ya está dado de alta.")
    pausar_pantalla()

def baja_cliente():
    """ Baja de un cliente """
    print("No es posible aún realizar esa operación.")
    pausar_pantalla()

def modificacion_cliente(cadena):
    """ stackoverflow.com/a/55992372/14009797 """
    print(cliente[0], "ingrese su nuevo nombre:")
    cadena[0] = input()
    print("Operación exitosa.")
    pausar_pantalla()


# ─── Cuentas ──────────────────────────────────────────────────────────────────

def alta_cuenta():
    """ Alta de una nueva cuenta """
    print("No es posible aún realizar esa operación.")
    pausar_pantalla()

def baja_cuenta():
    """ Baja de una cuenta """
    print("No es posible aún realizar esa operación.")
    pausar_pantalla()

def modificacion_cuenta():
    """ Modificación de datos de una cuenta """
    print("Solo puede modificar los saldos de sus cuentas.")
    print("Para ello, elija una operación del menú principal.")
    pausar_pantalla()


# ─── Operaciones ──────────────────────────────────────────────────────────────

def depositar():
    """ Deposito de dinero en una cuenta """
    importe = int()
    print("Ingrese importe a depositar:")
    importe = int(input())
    cuentas[cuenta] += importe
    print("Operación exitosa.")
    pausar_pantalla()

def retirar():
    """ Retiro de dinero de una cuenta """
    importe = int()
    print("Ingrese importe a retirar:")
    importe = int(input())
    if cuentas[cuenta]>importe:
        cuentas[cuenta] = cuentas[cuenta]-importe
        print("Operación exitosa.")
    else:
        print("Saldo insuficiente para hacer un retiro.")
    pausar_pantalla()

def transferir():
    """ Transferencia entre cuentas del mismo cliente """
    importe = int()
    print("Ingrese importe a transferir:")
    importe = int(input())
    if cuentas[cuenta]>importe:
        if cuenta==0:
            cuentas[cuenta] = cuentas[cuenta]-importe
            cuentas[1] = cuentas[1]+importe
            print("Operación exitosa.")
        else:
            cuentas[cuenta] = cuentas[cuenta]-importe
            cuentas[0] = cuentas[0]+importe
            print("Operación exitosa.")
    else:
        print("Saldo insuficiente para hacer esa transferencia.")
    pausar_pantalla()


# ─── Herramientas ─────────────────────────────────────────────────────────────

def print_center(texto):
    """ Método genérico de consola para imprimir texto centrado. """
    print(
        "\n" +
        Fore.GREEN +
        ' ' * ((os.get_terminal_size().columns - len(texto))//2) +
        texto
        )


# ┌──────────────────────────────────────────────────────────────────────────┐
# │ PROGRAMA PRINCIPAL                                                       │
# └──────────────────────────────────────────────────────────────────────────┘

if __name__ == '__main__':

    import os
    import colorama
    from colorama import Fore

    os.system('CLS')
    colorama.init(autoreset = True)

    print_center("BANCO DE LA NACIÓN ARGENTINA\n")
    print("Ingrese su nombre (y apellido):\n")
    cliente = [input()]
    print("")
    cuentas = [int() for idx in range(2)]
    cuentas[0] = 0
    cuentas[1] = 0

    while True:
        detallar_cuenta()
        print("""
        1) Alta de Cliente
        2) Baja de Cliente
        3) Modificación de Cliente
        4) Alta de Cuenta
        5) Baja de Cuenta
        6) Modificación de Cuenta
        7) Depositar
        8) Retirar
        9) Transferir
        10) Salir
        """)

        operacion = int(input())

        if operacion == 1:
            alta_cliente()
        elif operacion == 2:
            baja_cliente()
        elif operacion == 3:
            modificacion_cliente(cliente)
        elif operacion == 4:
            alta_cuenta()
        elif operacion == 5:
            baja_cuenta()
        elif operacion == 6:
            modificacion_cuenta()
        elif operacion == 7:
            print("Ingrese cuenta sobre la que operar (0 ó 1):")
            cuenta = int(input())
            depositar()
        elif operacion == 8:
            print("Ingrese cuenta sobre la que operar (0 ó 1):")
            cuenta = int(input())
            retirar()
        elif operacion == 9:
            print("Ingrese cuenta sobre la que operar (0 ó 1):")
            cuenta = int(input())
            transferir()
        elif operacion == 10:
            os.system('CLS')
            print_center("Gracias por utilizar nuestros servicios.\n")
            break
        else:
            print("Opción inválida.")
            pausar_pantalla()


        # match operacion:
        #     case 1:
        #         alta_cliente()
        #     case 2:
        #         baja_cliente()
        #     case 3:
        #         modificacion_cliente(cliente)
        #     case 4:
        #         alta_cuenta()
        #     case 5:
        #         baja_cuenta()
        #     case 6:
        #         modificacion_cuenta()
        #     case 7:
        #         print("Ingrese cuenta sobre la que operar (0 ó 1):")
        #         cuenta = int(input())
        #         depositar()
        #     case 8:
        #         print("Ingrese cuenta sobre la que operar (0 ó 1):")
        #         cuenta = int(input())
        #         retirar()
        #     case 9:
        #         print("Ingrese cuenta sobre la que operar (0 ó 1):")
        #         cuenta = int(input())
        #         transferir()
        #     case 10:
        #         os.system('CLS')
        #         print_center("Gracias por utilizar nuestros servicios.\n")
        #         break
        #     case _:
        #         print("Opción inválida.")
        #         pausar_pantalla()
