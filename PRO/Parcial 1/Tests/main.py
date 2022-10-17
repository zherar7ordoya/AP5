"""
  @title        PARCIAL 1
  @description  Gestor de tarjetas de crédito
  @author       Gerardo Tordoya
  @date         2022-10-16
"""

# ─── UNICODE BLOCKS -----------------------------------------------------------
#          Box Drawing      => www.compart.com/en/unicode/block/U+2500         #
#          Block Elements   => www.compart.com/en/unicode/block/U+2580         #
#          Geometric Shapes => www.compart.com/en/unicode/block/U+25A0         #

import os
import sys
import info_pantalla
# import administrador


# ─── HERRAMIENTAS DE INTERFAZ ────────────────────────────────────────────────
def limpiar_pantalla():
    """ Limpia la pantalla de la consola usando CLS en Windows y CLEAR en Linux. """
    os.system('cls' if os.name == 'nt' else 'clear')


def linea_horizontal():
    """ Imprime una línea horizontal decorativa. """
    print("───────────────────────────────────────────────")


# ─── MENU ────────────────────────────────────────────────────────────────────

def mostrar_menu():
    """ Muestra el menú principal de la aplicación, la cual actúa como interfaz. """

    limpiar_pantalla()
    print()
    print("""
        ┌────────────────┐  ╭───────────────────────────────╮
        │                │  │ ► 1 ABM Tarjetas              │
        │   FINANCIERA   │  ├───────────────────────────────┤
        │                │  │ ► 2 ABM Titulares             │
        │      ╭┼┼╮      │  ├───────────────────────────────┤
        │      ╰┼┼╮      │  │ ► 3 Asignaciones de Tarjetas  │
        │      ╰┼┼╯      │  ├───────────────────────────────┤
        │                │  │ ► 4 Ingreso de Consumos       │
        │ ADMINISTRACIÓN │  ├───────────────────────────────┤
        │    TARJETAS    │  │ ► 5 Ingreso de Pagos          │
        │   DE CRÉDITO   │  ├───────────────────────────────┤
        │                │  │ ► 6 Salir                     │
        └────────────────┘  ╰───────────────────────────────╯
    """)
    respuesta = int(input("         Ingrese su respuesta ► "))
    limpiar_pantalla()

    if respuesta == 1:
        print("─── Altas/Bajas/Modificaciones de Tarjetas ────")
        # administrador.Administrador.

    if respuesta == 2:
        print("─── Altas/Bajas/Modificaciones de Titulares ───")
        # sender = input("Sender's Account Number:    ")
        # receiver = input("Recipient's Account Number: ")
        # amount = float(input("Transaction Amount: "))
        # perform_transaction(sender, receiver, amount)

    if respuesta == 3:
        print("─── Asignaciones de Tarjetas a Titulares ──────")
        # account_number = input("Account Number To Change: ")
        # update_information(account_number)

    if respuesta == 4:
        print("─── Ingresos de Consumos ──────────────────────")
        # account_number = input("Account number to delete: ")
        # delete_account(account_number)

    if respuesta == 5:
        print("─── Ingresos de Pagos ─────────────────────────")
        # query = input("Searching for: ")
        # limpiar_pantalla()
        # search_account("full_name", query)

    if respuesta == 6:
        print("─── Saliendo ──────────────────────────────────")
        print("\nGracias por utilizar nuestros servicios.\n")
        sys.exit()

    # ÁREA DE PRUEBAS:
    # if respuesta == 7:
    #     info_pantalla.mostrar_info()

    print()
    linea_horizontal()
    input("Pulse ENTER para continuar...")
    print()


# ─── MAIN ─────────────────────────────────────────────────────────────────────
while True:
    mostrar_menu()
