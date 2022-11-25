# ========================================
# Author:       Gerardo Tordoya
# Create date:  2022-11-22
# Description:  Mi Programa en Python v2.0
# ========================================
import csv
from colorama import init
from colorama import Fore
from consolemenu import *
from consolemenu.items import *
from decimal import Decimal
from excepcion_capturada import ExceptionCapturada
from articulo_bll import ArticuloBLL
from articulo_mpp import ArticuloMPP
from venta_bll import VentaBLL
from venta_mpp import VentaMPP

init()





def ordenar_archivo(archivo):
    with open(archivo) as dat:
        lista = list(csv.reader(dat))
        ordenar_lista(lista)
    with open(archivo, 'w', newline='\n') as dat:
        csv.writer(dat).writerows(lista)


def ordenar_lista(lista):
    # Ordeno por vendedor
    for idx in range(len(lista)):
        evaluado = idx
        for x in range(idx + 1, len(lista)):
            if lista[evaluado][2] > lista[x][2]:
                evaluado = x
        lista[idx], lista[evaluado] = lista[evaluado], lista[idx]

    # Ordeno por artículo
    for idx in range(len(lista)):
        evaluado = idx
        for x in range(idx + 1, len(lista)):
            if lista[evaluado][1] > lista[x][1]:
                evaluado = x
        lista[idx], lista[evaluado] = lista[evaluado], lista[idx]

    # Ordeno por sucursal
    for idx in range(len(lista)):
        evaluado = idx
        for x in range(idx + 1, len(lista)):
            if lista[evaluado][3] > lista[x][3]:
                evaluado = x
        lista[idx], lista[evaluado] = lista[evaluado], lista[idx]


def get_descripcion(codigo):
    try:

        articulo_mapeador = ArticuloBLL()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        # Le ahorro tiempo al programador que quiera eliminar idx: no lo hagas.
        for idx, x in enumerate(listado):
            if x[0] == codigo:
                return x[1]

    except ExceptionCapturada as e:
        print(e)



def imprimir_reporte(archivo_csv):
    archivo = open(archivo_csv)
    ventas = csv.reader(archivo)
    item = next(ventas, None)

    total_general = 0

    # Bucle Total General (condición de salida: ítem es None)
    while item:
        sucursal, total_sucursal = item[3], 0
        print(f"{Fore.YELLOW}\nSucursal {sucursal}\n{Fore.RESET}")

        # Bucle Total Sucursal
        while item and item[3] == sucursal:
            articulo, total_articulo = item[1], 0
            print(f"{Fore.RED}\t{get_descripcion(articulo)}{Fore.RESET}")

            # Bucle Total Artículo
            while item and item[3] == sucursal and item[1] == articulo:
                vendedor, total_vendedor = item[2], 0

                # Bucle Total Vendedor
                while item and item[3] == sucursal and item[1] == articulo and item[2] == vendedor:
                    total_vendedor += Decimal(item[4])
                    item = next(ventas, None)

                total_articulo += total_vendedor
                print(f"\t\t{vendedor}:\t{total_vendedor}")

            total_sucursal += total_articulo
            # Muestro el código porque me desequilibra el reporte si muestro el nombre
            print(f"{Fore.RED}\t\t\tTotal {articulo}:\t{total_articulo}\n{Fore.RESET}")

        total_general += total_sucursal
        print(f"{Fore.YELLOW}\t\t\t\tTotal {sucursal}:\t{total_sucursal}{Fore.RESET}")

    print(f"{Fore.GREEN}\n\t\t\t\t\tTOTAL GENERAL:\t{total_general}{Fore.RESET}")

    """ Como decían los Looney Tunes: ¡Eso es todo, amigos! """
    archivo.close()




class ListadoBLL:

    def articulos(self):
        try:
            print("LISTADO DE ARTÍCULOS\n====================\n")

            articulo_bll = ArticuloBLL()
            listado = articulo_bll.leer(articulo_bll.archivo)

            for idx, x in enumerate(listado):
                print(idx, x)

            input("\nOperación completada (presione una tecla para continuar)")

        except ExceptionCapturada as e:
            print(e)

    def ventas(self):
        try:
            print("LISTADO DE VENTAS\n=================\n")

            venta_mpp = VentaMPP()
            listado = venta_mpp.leer(venta_mpp.archivo)

            for idx, x in enumerate(listado):
                print(idx, x)

            input("\nOperación completada (presione una tecla para continuar)")

        except ExceptionCapturada as e:
            print(e)

    def sucursales(self):
        try:
            print("REPORTE DE SUCURSALES\n=====================\n")

            venta_mpp = VentaMPP()
            ordenar_archivo(venta_mpp.archivo)
            imprimir_reporte(venta_mpp.archivo)

            input("\nOperación completada (presione una tecla para continuar)")

        except ExceptionCapturada as e:
            print(e)


# --- CAPA DE PRESENTACIÓN (si esto fuera una arquitectura en capas) -----------

def main():
    # Menu principal
    menu = ConsoleMenu(f"{Fore.GREEN}ADMINISTRACIÓN DE ARTÍCULOS Y VENTAS{Fore.RESET}",
                       "Seleccione una opción")

    # Creo los items del submenú usando Selection (que toma una lista de strings)
    submenu_articulos = SelectionMenu([],
                                      title="ABM ARTÍCULOS",
                                      subtitle="Seleccione una opción")
    submenu_ventas = SelectionMenu([],
                                   title="ABM VENTAS",
                                   subtitle="Seleccione una opción")
    submenu_listados = SelectionMenu([],
                                     title="LISTADOS",
                                     subtitle="Seleccione una opción")

    # Creo los items del submenú usando FunctionItem (que toma una función)

    articulo = ArticuloBLL()
    submenu_articulos.append_item(FunctionItem("Alta de artículo",
                                               articulo.alta))
    submenu_articulos.append_item(FunctionItem("Baja de artículo",
                                               articulo.baja))
    submenu_articulos.append_item(FunctionItem("Modificación de artículo",
                                               articulo.modificacion))

    venta = VentaBLL()
    submenu_ventas.append_item(FunctionItem("Alta de venta",
                                            venta.alta))
    submenu_ventas.append_item(FunctionItem("Baja de venta",
                                            venta.baja))
    submenu_ventas.append_item(FunctionItem("Modificación de venta",
                                            venta.modificacion))

    listado = ListadoBLL()
    submenu_listados.append_item(FunctionItem("Listado de Artículos",
                                              listado.articulos))
    submenu_listados.append_item(FunctionItem("Listado de Ventas",
                                              listado.ventas()))
    submenu_listados.append_item(FunctionItem("Reporte de Sucursales",
                                              listado.sucursales()))

    # Creo los ítems del menú principal usando SubmenuItem (que toma un submenú)
    submenu_item_articulos = SubmenuItem("Artículos\t>>   altas, bajas y modificaciones",
                                         submenu=submenu_articulos)
    submenu_item_articulos.set_menu(menu)

    submenu_item_ventas = SubmenuItem("Ventas\t>>   altas, bajas y modificaciones",
                                      submenu=submenu_ventas)
    submenu_item_ventas.set_menu(menu)

    submenu_item_listados = SubmenuItem("Listados\t>>   artículos, ventas y sucursales",
                                        submenu=submenu_listados)
    submenu_item_listados.set_menu(menu)

    # Agrego los ítems al menú principal
    menu.append_item(submenu_item_articulos)
    menu.append_item(submenu_item_ventas)
    menu.append_item(submenu_item_listados)

    # Muestro el menú principal
    menu.start()
    menu.join()


# El punto de entrada en Python es tan simple que asusta...
if __name__ == "__main__":
    main()

# --- NOTA PARA EL PROGRAMADOR QUE VAYA A EDITAR ESTO --------------------------
# No uses Visual Studio ni VSCode.
# Visual Studio tiene problemas para entender las indentaciones de Python.
# VSCode tiene fugas de memoria bastante feas con algunas librerías de Python.
# Apostá por PyCharm.
