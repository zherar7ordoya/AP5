# ========================================
# Author:       Gerardo Tordoya
# Create date:  2022-11-28
# Description:  Mi Programa en Python v2.1
# ========================================


from consolemenu import *
from consolemenu.items import *
from colors import color

from BLL.articulo_logic import ArticuloLogic
from BLL.listado_logic import ListadoLogic
from BLL.venta_logic import VentaLogic
from EHL.handler_logger import CapturadorExcepciones


# ANSI Colors:
# https://pypi.org/project/ansicolors/
# https://www.ditig.com/256-colors-cheat-sheet

def main():
    try:
        # Menu principal
        menu = ConsoleMenu(color("ADMINISTRACIÓN DE ARTÍCULOS Y VENTAS", fg='LightGreen', style='bold+underline'),
                           color("Seleccione una opción", fg=226))

        # Creo los submenús
        submenu_articulos = SelectionMenu([], title=color("ABM ARTÍCULOS", fg='green', style='italic'),
                                          subtitle=color("Seleccione una opción", fg='yellow'))
        submenu_ventas = SelectionMenu([], title=color("ABM VENTAS", fg='green', style='italic'),
                                       subtitle=color("Seleccione una opción", fg='yellow'))
        submenu_listados = SelectionMenu([], title=color("LISTADOS", fg='green', style='italic'),
                                         subtitle=color("Seleccione una opción", fg='yellow'))

        # Agrego los items del submenú artículos
        articulo = ArticuloLogic()
        submenu_articulos.append_item(FunctionItem("Alta de artículo", articulo.alta))
        submenu_articulos.append_item(FunctionItem("Baja de artículo", articulo.baja))
        submenu_articulos.append_item(FunctionItem("Modificación de artículo", articulo.modificacion))

        # Agrego los items del submenú ventas
        venta = VentaLogic()
        submenu_ventas.append_item(FunctionItem("Alta de venta", venta.alta))
        submenu_ventas.append_item(FunctionItem("Baja de venta", venta.baja))
        submenu_ventas.append_item(FunctionItem("Modificación de venta", venta.modificacion))

        # Agrego los items del submenú listados
        listado = ListadoLogic()
        submenu_listados.append_item(FunctionItem("Listado de Artículos", listado.articulos))
        submenu_listados.append_item(FunctionItem("Listado de Ventas", listado.ventas))
        submenu_listados.append_item(FunctionItem("Listado de Sucursales", listado.sucursales))

        # Creo los ítems del menú principal
        item_articulos = SubmenuItem("Artículos\t>>   altas, bajas y modificaciones", submenu=submenu_articulos)
        item_ventas = SubmenuItem("Ventas\t>>   altas, bajas y modificaciones", submenu=submenu_ventas)
        item_listados = SubmenuItem("Listados\t>>   artículos, ventas y sucursales", submenu=submenu_listados)

        # Agrego los ítems al menú principal
        item_articulos.set_menu(menu)
        item_ventas.set_menu(menu)
        item_listados.set_menu(menu)

        # Agrego los ítems al menú principal
        menu.append_item(item_articulos)
        menu.append_item(item_ventas)
        menu.append_item(item_listados)

        # Muestro el menú principal
        menu.start()
        menu.join()

    except Exception as e:
        raise CapturadorExcepciones("Error al crear la interfaz de usuario", *e.args)


if __name__ == "__main__":
    main()
