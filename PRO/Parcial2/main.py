# ========================================
# Author:       Gerardo Tordoya
# Create date:  2022-11-22
# Description:  Mi Programa en Python v2.0
# ========================================


from colorama import Fore
from consolemenu import *
from consolemenu.items import *

from BLL.articulo_logic import ArticuloLogic
from BLL.listado_logic import ListadoLogic
from BLL.venta_logic import VentaLogic


def main():
    # Menu principal
    menu = ConsoleMenu(f"{Fore.GREEN}ADMINISTRACIÓN DE ARTÍCULOS Y VENTAS{Fore.RESET}", "Seleccione una opción")

    # Creo los submenús
    submenu_articulos = SelectionMenu([], title="ABM ARTÍCULOS", subtitle="Seleccione una opción")
    submenu_ventas = SelectionMenu([], title="ABM VENTAS", subtitle="Seleccione una opción")
    submenu_listados = SelectionMenu([], title="LISTADOS", subtitle="Seleccione una opción")

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


if __name__ == "__main__":
    main()
