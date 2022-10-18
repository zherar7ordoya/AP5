"""
  @title        MI PROGRAMA EN PYTHON v1.0
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
import informacion
import gestor


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
    operacion = gestor.Operacion()
    limpiar_pantalla()
    print()
    print("""
        ┌────────────────┐  ╭───────────────────────────────╮
        │                │  │ ► 1 ABM Tarjetas              │
        │   FINANCIERA   │  ├───────────────────────────────┤
        │                │  │ ► 2 ABM Titulares             │
        │                │  ├───────────────────────────────┤
        │      ╭┼┼╮      │  │ ► 3 Asignaciones de Tarjetas  │
        │      ╰┼┼╮      │  ├───────────────────────────────┤
        │      ╰┼┼╯      │  │ ► 4 Ingreso de Consumos       │
        │                │  ├───────────────────────────────┤
        │                │  │ ► 5 Ingreso de Pagos          │
        │ ADMINISTRACIÓN │  ├───────────────────────────────┤
        │    TARJETAS    │  │ ► 6 Salir                     │
        │   DE CRÉDITO   │  ├───────────────────────────────┤
        │                │  │ ► 7 (Consultas)               │
        └────────────────┘  ╰───────────────────────────────╯
    """)
    opcion = input("         Ingrese su respuesta ► ")
    limpiar_pantalla()

    if opcion == '1':
        print("─── Altas/Bajas/Modificaciones de Tarjetas ────")
        print("1. Crear Tarjeta")
        print("2. Borrar Tarjeta")
        print("3. Modificar Tarjeta")
        respuesta = input("Opción: ")
        if respuesta == "1":
            operacion.alta_tarjeta()
        elif respuesta == "2":
            operacion.baja_tarjeta()
        elif respuesta == "3":
            operacion.modifica_tarjeta()
        else:
            print("Opción incorrecta")
            input("Pulse ENTER para continuar...")
            return
        informacion.mostrar()

    if opcion == '2':
        print("─── Altas/Bajas/Modificaciones de Titulares ───")
        print("1. Crear Titular")
        print("2. Borrar Titular")
        print("3. Modificar Titular")
        respuesta = input("Opción: ")
        if respuesta == "1":
            operacion.alta_titular()
        elif respuesta == "2":
            operacion.baja_titular()
        elif respuesta == "3":
            operacion.modifica_titular()
        else:
            print("Opción incorrecta")
            input("Pulse ENTER para continuar...")
            return
        informacion.mostrar()

    if opcion == '3':
        print("─── Asignaciones de Tarjetas a Titulares ──────")
        print("1. Asignar Tarjeta a Titular")
        print("2. Desasignar Tarjeta a Titular")
        respuesta = input("Opción: ")
        if respuesta == "1":
            operacion.asignar_tarjeta()
        elif respuesta == "2":
            operacion.desasignar_tarjeta()
        else:
            print("Opción incorrecta")
            input("Pulse ENTER para continuar...")
            return
        informacion.mostrar()

    if opcion == '4':
        print("─── Ingresos de Consumos ──────────────────────")
        print("1. Ingresar Consumo en Pesos")
        print("2. Ingresar Consumo en Dólares")
        respuesta = input("Opción: ")
        if respuesta == "1":
            operacion.consumo_pesos()
        elif respuesta == "2":
            operacion.consumo_dolares()
        else:
            print("Opción incorrecta")
            input("Pulse ENTER para continuar...")
            return
        informacion.mostrar()

    if opcion == '5':
        print("─── Ingresos de Pagos ─────────────────────────")
        print("1. Ingresar Pago en Pesos")
        print("2. Ingresar Pago en Dólares")
        respuesta = input("Opción: ")
        if respuesta == "1":
            operacion.pago_pesos()
        elif respuesta == "2":
            operacion.pago_dolares()
        else:
            print("Opción incorrecta")
            input("Pulse ENTER para continuar...")
            return
        informacion.mostrar()

    if opcion == '6':
        print("─── Saliendo ──────────────────────────────────")
        print("\nGracias por utilizar nuestros servicios.\n")
        sys.exit()

    if opcion == '7':
        informacion.mostrar()

    print()
    linea_horizontal()
    input("Pulse ENTER para continuar...")
    print()


# ─── MAIN ─────────────────────────────────────────────────────────────────────
while True:
    mostrar_menu()
