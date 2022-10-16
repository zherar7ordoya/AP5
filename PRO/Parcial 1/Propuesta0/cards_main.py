#! /usr/bin/python3

"""
Indica agregar una etiqueta sheban, puede iniciar el programa directamente
"""

import cards_tools

while True:
    cards_tools.show_menu()
    action_str = input("Por favor seleccione la acción que desea realizar")
    print(f"La acción que seleccionó es {action_str}")

    if action_str in ["1", "2", "3"]:
        # Añadir una tarjeta de visita
        if action_str == "1":
            cards_tools.new_card()
        # mostrar todo
        elif action_str == "2":
            cards_tools.show_all()
        # Consultar por tarjetas de visita
        else:
            cards_tools.search_card()
    elif action_str == "0":
        print("Bienvenido al sistema de gestión de tarjetas de visita de nuevo")
        # Si no desea escribir el código de la nebulosa de la rama inmediatamente
        # al desarrollar el programa...
        # Puede usar la palabra clave pass para representar un marcador de posición
        # pass palabra clave no hace nada
        # ---
        # Pendiente: Modificar y eliminar la tarjeta de visita encontrada
        break
    else:
        print("Su entrada es incorrecta, por favor inténtelo de nuevo")
