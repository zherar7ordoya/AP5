# 记录所有的名片字典
card_list = []


def show_menu():
    """显示菜单"""
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
    """新增名片"""
    print("-" * 50)
    print("Añadir una tarjeta de visita")
    # 1.提示用户输入名片的详细信息
    name_str = input("Por favor escriba su nombre: ")
    phone_str = input("Por favor ingrese el teléfono: ")
    qq_str = input("Por favor ingrese qq: ")
    email_str = input("Por favor ingrese su correo electrónico: ")
    # 2.使用用户输入的信息建立一个名片
    card_dict = {
        "name": name_str,
        "phone": phone_str,
        "qq": qq_str,
        "email": email_str

    }
    # 3.将名片字典添加到列表中
    card_list.append(card_dict)
    # 4.提示用户添加成功
    print("¡Se agregó correctamente la tarjeta de presentación de %s!" % name_str)


def show_all():
    """显示所有名片"""
    print("-" * 50)
    print("Mostrar todas las tarjetas de visita")
    # 判断是否存在名片记录,如果没有,提示用户并且返回
    if len(card_list) == 0:
        print("Actualmente no hay ningún registro de tarjeta de presentación, utilice la nueva función para agregar una tarjeta de presentación.")
        # return可以返回一个函数的执行结果
        # 下方的代码不会被执行
        # 如果return后面没有任何内容,表示会返回到函数的位置
        # 并且不返回任何的结果
        return
    # 打印表头
    for name in ["Nombre", "Teléfono", "qq", "Correo electrónico"]:
        print(name, end="\t\t")
    print("")
    #     打印分割线
    print("=" * 50)
    #     遍历名片列表一次输出字典信息
    for card_dict in card_list:
        print("%s\t\t%s\t\t%s\t\t%s" % (card_dict["name"],
                                        card_dict["phone"],
                                        card_dict["qq"],
                                        card_dict["email"]))


def search_card():
    """搜索名片"""
    print("-" * 50)
    print("Consultar por tarjetas de visita")

    # 1.提示用户要搜索的姓名
    find_name = input("Por favor ingrese el nombre para buscar")
    # 2.遍历名片列表,查找要搜索的姓名,如果没有找到,需要提示用户
    for card_dict in card_list:
        if card_dict["name"] == find_name:
            print("=" * 50)
            print("Nombre\t\tTeléfono\t\tQQ\t\tCorreo electrónico")
            print("=" * 50)
            print("%s\t\t%s\t\t%s\t\t%s" % (card_dict["name"],
                                            card_dict["phone"],
                                            card_dict["qq"],
                                            card_dict["email"]))
            deal_card(card_dict)
            break
    else:
        print("lo siento, no encontrado %s" % find_name)


def deal_card(find_dict):
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
    """输入名片信息

    :param dict_value:字典中原有的值
    :param tip_message:提示信息
    :return:修改后的值
    """
    # 1.提示用户输入的内容
    result_str = input(tip_message)
    # 2.针对用户输入的内容进行判断,如果用户输入了内容,就直接返回结果
    if len(result_str) > 0:
        return result_str
    # 3.如果用户没有内容,返回字典中原有的值
    else:
        return dict_value
