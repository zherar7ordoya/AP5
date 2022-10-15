#! /usr/bin/python3
# #!表示添加sheban标记,可以直接启动这个程序
import cards_tools

while True:
    cards_tools.show_menu()
    action_str = input("Por favor seleccione la acción que desea realizar")
    print("La acción que seleccionó es[%s]" % action_str)

    if action_str in ["1", "2", "3"]:
        # 新增名片
        if action_str == "1":
            cards_tools.new_card()
            pass
        # 显示全部
        elif action_str == "2":
            cards_tools.show_all()
            pass
        # 查询名片
        else:
            cards_tools.search_card()
            pass
        pass
    elif action_str == "0":
        print("Bienvenido al sistema de gestión de tarjetas de visita de nuevo")
        # 如果在开发程序时,不希望立刻编写分支nebula的代码
        # 可以使用pass关键字,表示一个占位符
        # pass关键字不会执行任何的操作
        # TODO 针对找到的名片做修改和删除的操作
        break
    else:
        print("Su entrada es incorrecta, por favor inténtelo de nuevo")
