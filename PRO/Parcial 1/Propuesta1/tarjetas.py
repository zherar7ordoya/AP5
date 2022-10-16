"""
Grabar todos los diccionarios de tarjetas de visita
"""

card_list = []


def show_menu():
    """Muestrame el menu"""
    print("*" * 50)
    print("Bienvenido al [Sistema de gestión de tarjetas de visita]")
    print("")
    print("1. Añadir una tarjeta de visita")
    print("2. Mostrar todo")
    print("3. Buscar tarjetas de visita")
    print("")
    print("0. Sistema de salida")
    print("*" * 50)


def new_card():
    """Añadir una tarjeta de visita"""
    print("-" * 50)
    print("Añadir una tarjeta de visita")

    # 1. Solicitar al usuario que ingrese los detalles de la tarjeta de presentación
    name_str = input("Por favor escriba su nombre: ")
    phone_str = input("Por favor ingrese el teléfono: ")
    qq_str = input("Por favor ingrese qq: ")
    email_str = input("Por favor ingrese su correo electrónico: ")
    # 2. Crear una tarjeta de presentación utilizando la información ingresada por el usuario
    card_dict = {
        "name": name_str,
        "phone": phone_str,
        "qq": qq_str,
        "email": email_str

    }
    # 3. Añadir el diccionario de tarjetas de visita a la lista
    card_list.append(card_dict)
    # 4. Solicitar al usuario que agregue correctamente
    print(f"¡Se agregó correctamente la tarjeta de presentación de {name_str}!")


def show_all():
    """mostrar todas las tarjetas de visita"""
    print("-" * 50)
    print("Mostrar todas las tarjetas de visita")
    # Determine si hay un registro de tarjeta de presentación, si no, pregunte al usuario y regrese
    if len(card_list) == 0:
        print("""Actualmente no hay ningún registro de tarjeta de presentación,
        utilice la nueva función para agregar una tarjeta de presentación.""")
        # return puede devolver el resultado de ejecutar una función
        # El siguiente código no se ejecutará
        # Si no hay nada después de return, significa que volverá a la posición de la función.
        # y no devuelve resultados
        return
    # encabezado de impresión
    for name in ["Nombre", "Teléfono", "qq", "Correo electrónico"]:
        print(name, end="\t\t")
    print("")
    # línea divisoria de impresión
    print("=" * 50)
    # Recorra la lista de tarjetas de visita una vez y genere información del diccionario
    for card in card_list:
        print(f'{card["name"]}\t\t{card["phone"]}\t\t{card["qq"]}\t\t{card["email"]}')


def search_card():
    """Buscar tarjetas de visita"""
    print("-" * 50)
    print("Consultar por tarjetas de visita")

    # 1. Solicitar al usuario el nombre a buscar
    find_name = input("Por favor ingrese el nombre para buscar")
    # 2. Recorra la lista de tarjetas de presentación para encontrar el nombre
    # que desea buscar; si no lo encuentra, debe avisar al usuario
    for card in card_list:
        if card["name"] == find_name:
            print("=" * 50)
            print("Nombre\t\tTeléfono\t\tQQ\t\tCorreo electrónico")
            print("=" * 50)
            print(f'{card["name"]}\t\t{card["phone"]}\t\t{card["qq"]}\t\t{card["email"]}')
            deal_card(card)
            break
    else:
        print(f"lo siento, no encontrado {find_name}")


def deal_card(find_dict):
    """Procesar tarjetas de presentación encontradas"""
    action_str = input("Seleccione una acción para realizar!"
                       "[1]. Modificar tarjeta de visita [2]. Borrar tarjeta de visita [0]. Salir")
    if action_str == "1":
        find_dict["name"] = input_card_info(find_dict["name"], "Nombre")
        find_dict["phone"] = input_card_info(find_dict["phone"], "Teléfono")
        find_dict["qq"] = input_card_info(find_dict["qq"], "qq")
        find_dict["email"] = input_card_info(find_dict["email"], "email")
        print("Modificar tarjeta de visita con éxito")
    elif action_str == "2":
        card_list.remove(find_dict)
        print("Eliminar tarjeta de visita con éxito")


def input_card_info(dict_value, tip_message):
    """Ingrese la información de la tarjeta de presentación
    :param dict_value: El valor original en el diccionario.
    :param tip_message: pronta informacion
    :return: valor modificado
    """
    # 1. Qué solicitar para la entrada del usuario
    result_str = input(tip_message)
    # 2. Al juzgar el contenido ingresado por el usuario, si el usuario ingresa
    # el contenido, devuelve el resultado directamente
    if len(result_str) > 0:
        return result_str
    # 3. Si el usuario no tiene contenido, devuelve el valor original en el diccionario
    return dict_value
