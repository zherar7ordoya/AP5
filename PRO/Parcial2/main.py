# =======================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-20
# Description: Mi Programa en Python v2.0
# =======================================

import os
import csv
import re
from decimal import Decimal

from colorama import Fore
from consolemenu import *
from consolemenu.items import *


class ExceptionCapturada(Exception):
    def __init__(self, mensaje, *errores):
        Exception.__init__(self, mensaje)
        self.errores = errores
        print(f"{Fore.RED}{errores[0]}{Fore.RESET}")
        input("Presione una tecla para continuar...")


class AccesoDatos:

    def __enter__(self):
        """ Método mágico para el uso de with que se ejecuta al inicio """
        return self

    def __exit__(self, *args, **kwargs):
        """ Método mágico para el uso de with que se ejecuta al final """
        return self

    def leer(self, archivo):
        try:
            with open(archivo) as dat:
                return list(csv.reader(dat))
        except FileNotFoundError as e:
            raise ExceptionCapturada("NO SE ENCONTRÓ EL ARCHIVO", *e.args)

    def escribir(self, archivo, lista):
        try:
            with open(archivo, 'w', newline='\n') as dat:
                csv.writer(dat).writerows(lista)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL DESCONECTARSE", *e.args)


# --- MAPEADOR DE ARTÍCULOS ---------------------------------------------------


class ArticuloMapeador(AccesoDatos):

    def __init__(self):
        self.archivo = 'articulos.csv'

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.codigo, objeto.descripcion, objeto.stock]
            listado.append(nuevo)
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL CREAR", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer(self.archivo)
            return listado[idx]
        except Exception as e:
            raise ExceptionCapturada("ERROR AL LEER", *e.args)

    # *** MODIFICACIONES ***
    def update(self, objeto, idx):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.codigo, objeto.descripcion, objeto.stock]
            listado[idx] = nuevo
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer(self.archivo)
            del listado[idx]
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL ELIMINAR", *e.args)


# --- MAPEADOR DE VENTAS ------------------------------------------------------
class VentaMapeador(AccesoDatos):

    def __init__(self):
        self.archivo = 'ventas.csv'

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.fecha, objeto.codigo, objeto.vendedor, objeto.sucursal, objeto.importe]
            listado.append(nuevo)
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL CREAR", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer(self.archivo)
            return listado[idx]
        except Exception as e:
            raise ExceptionCapturada("ERROR AL LEER", *e.args)

    # *** MODIFICACIONES ***
    def update(self, objeto, cod):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.fecha, objeto.codigo, objeto.vendedor, objeto.sucursal, objeto.importe]
            listado[cod] = nuevo
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer(self.archivo)
            del listado[idx]
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL ELIMINAR", *e.args)


# --- CLASES ------------------------------------------------------------------
class Articulo:
    def __init__(self, codigo, descripcion, stock):
        self.codigo = codigo
        self.descripcion = descripcion
        self.stock = stock

    def __str__(self):
        return f"{self.codigo} - {self.descripcion} - {self.stock}"


class Venta:
    def __init__(self, fecha, codigo, vendedor, sucursal, importe):
        self.fecha = fecha
        self.codigo = codigo
        self.vendedor = vendedor
        self.sucursal = sucursal
        self.importe = importe

    def __str__(self):
        return f"{self.fecha} - {self.codigo} - {self.vendedor} - {self.sucursal} - {self.importe}"


# --- FUNCIONES PARA ARTÍCULOS ------------------------------------------------

def alta_articulo():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("ALTA DE ARTÍCULO")
        print("================")

        codigo = ""
        descripcion = ""
        stock = ""

        while True:
            codigo = input("Código: ")
            if not re.match("([A-Z]\d{3})", codigo):
                print("Error. Debe ingresar una letra mayúscula y 3 números")
            else:
                break

        while True:
            descripcion = input("Descripción: ")
            if not re.match("([A-Za-z0-9])", descripcion):
                print("Error. Debe ingresar una descripción válida (letras y números)")
            else:
                break


        while True:
            stock = input("Stock: ")
            if not int(stock):
                print("Error. Debe ingresar un stock válido (números)")
            else:
                break

        articulo = Articulo(codigo, descripcion, stock)
        articulo_mapeador = ArticuloMapeador()
        articulo_mapeador.create(articulo)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def baja_articulo():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("BAJA DE ARTÍCULO")
        print("================")

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        idx = int(input("\nIngrese el número de registro del artículo a eliminar: "))
        articulo_mapeador.delete(idx)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def modificacion_articulo():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("MODIFICACIÓN DE ARTÍCULO")
        print("========================")

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        idx = int(input("\nIngrese el número de registro del artículo a modificar: "))

        print("\nIngrese los nuevos datos del artículo")
        codigo = input("Código: ")
        descripcion = input("Descripción: ")
        stock = input("Stock: ")
        articulo = Articulo(codigo, descripcion, stock)

        articulo_mapeador.update(articulo, idx)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


# --- FUNCIONES PARA VENTAS ---------------------------------------------------

def alta_venta():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("ALTA DE VENTA")
        print("=============")
        fecha = input("Fecha: ")
        codigo = input("Código: ")
        vendedor = input("Vendedor: ")
        sucursal = input("Sucursal: ")
        importe = input("Importe: ")

        venta = Venta(fecha, codigo, vendedor, sucursal, importe)
        venta_mapeador = VentaMapeador()
        venta_mapeador.create(venta)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def baja_venta():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("BAJA DE VENTA")
        print("=============")

        venta_mapeador = VentaMapeador()

        listado = venta_mapeador.leer(venta_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)

        idx = int(input("\nIngrese el número de registro de la venta a eliminar: "))
        venta_mapeador.delete(idx)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def modificacion_venta():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("MODIFICACIÓN DE VENTA")
        print("=====================")

        venta_mapeador = VentaMapeador()
        listado = venta_mapeador.leer(venta_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        idx = int(input("\nIngrese el número de registro de la venta a modificar: "))

        print("\nIngrese los nuevos datos de la venta")
        fecha = input("Fecha: ")
        codigo = input("Código: ")
        vendedor = input("Vendedor: ")
        sucursal = input("Sucursal: ")
        importe = input("Importe: ")
        venta = Venta(fecha, codigo, vendedor, sucursal, importe)

        venta_mapeador.update(venta, idx)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


# --- LISTADOS ----------------------------------------------------------------

def listado_articulos():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("LISTADO DE ARTÍCULOS")
        print("====================")

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def listado_ventas():
    os.system('cls' if os.name == 'nt' else 'clear')
    try:
        print("LISTADO DE VENTAS")
        print("=================")

        venta_mapeador = VentaMapeador()
        listado = venta_mapeador.leer(venta_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


# --- APAREO Y CORTE DE CONTROL -----------------------------------------------

# Abro, leo, ordeno y guardo el archivo
def ordenar_archivo(archivo):
    with open(archivo) as dat:
        lista = list(csv.reader(dat))
        ordenar_lista(lista)
    with open(archivo, 'w', newline='\n') as dat:
        csv.writer(dat).writerows(lista)


# Ordenamiento por Selección (Selection Sort)
def ordenar_lista(lista):
    for idx in range(len(lista)):
        evaluado = idx
        for x in range(idx + 1, len(lista)):
            if lista[evaluado][3] > lista[x][3]:
                evaluado = x
        lista[idx], lista[evaluado] = lista[evaluado], lista[idx]

def get_descripcion(cod):
    try:

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        for idx, x in enumerate(listado):
            if x[0] == cod:
                return x[1]

    except ExceptionCapturada as e:
        print(e)


def imprimir_reporte(archivo):
    ventas = open(archivo)
    ventas_csv = csv.reader(ventas)
    item = next(ventas_csv, None)
    total_general = 0

    # Uso un bucle cuya condición es que el item no sea None
    while item:



        sucursal, total_sucursal = item[3], 0
        print(f"{Fore.YELLOW}\nSucursal {sucursal}\n{Fore.RESET}")

        while item and item[3] == sucursal:
            articulo, total_articulo = item[1], 0
            print(f"{Fore.RED}\t{get_descripcion(articulo)}{Fore.RESET}")

            while item and item[3] == sucursal and item[1] == articulo:
                vendedor, total_vendedor = item[2], 0

                while item and item[3] == sucursal and item[1] == articulo and item[2] == vendedor:
                    total_vendedor += Decimal(item[4])
                    item = next(ventas_csv, None)
                total_articulo += total_vendedor
                print(f"\t\t{vendedor}: {total_vendedor}")

            total_sucursal += total_articulo
            print(f"{Fore.RED}\t\t\tTotal artículo {articulo}: {total_articulo}\n{Fore.RESET}")

        total_general += total_sucursal
        print(f"{Fore.YELLOW}\t\t\t\tTotal sucursal {sucursal}: {total_sucursal}{Fore.RESET}")

    print(f"{Fore.GREEN}\n\t\t\t\t\tTotal general: {total_general}{Fore.RESET}")

    ventas.close()

def reporte_sucursales():
    os.system('cls' if os.name == 'nt' else 'clear')

    try:
        print("REPORTE DE SUCURSALES")
        print("=====================")

        venta_mapeador = VentaMapeador()

        ordenar_archivo(venta_mapeador.archivo)
        imprimir_reporte(venta_mapeador.archivo)

        input("\nOperación completada (presione una tecla para continuar)")



    except ExceptionCapturada as e:
        print(e)





# --- MAIN --------------------------------------------------------------------


def main():
    # Menu principal
    menu = ConsoleMenu("ADMINISTRACIÓN DE ARTÍCULOS Y VENTAS",
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
    submenu_articulos.append_item(FunctionItem("Alta de artículo",
                                               alta_articulo))
    submenu_articulos.append_item(FunctionItem("Baja de artículo",
                                               baja_articulo))
    submenu_articulos.append_item(FunctionItem("Modificación de artículo",
                                               modificacion_articulo))

    submenu_ventas.append_item(FunctionItem("Alta de venta",
                                            alta_venta))
    submenu_ventas.append_item(FunctionItem("Baja de venta",
                                            baja_venta))
    submenu_ventas.append_item(FunctionItem("Modificación de venta",
                                            modificacion_venta))

    submenu_listados.append_item(FunctionItem("Listado de Artículos",
                                              listado_articulos))
    submenu_listados.append_item(FunctionItem("Listado de Ventas",
                                              listado_ventas))
    submenu_listados.append_item(FunctionItem("Reporte de Sucursales",
                                              reporte_sucursales))

    # Creo los ítems del menú principal usando SubmenuItem (que toma un submenú)
    submenu_item_articulos = SubmenuItem("Altas, Bajas y Modificaciones de artículos",
                                         submenu=submenu_articulos)
    submenu_item_articulos.set_menu(menu)

    submenu_item_ventas = SubmenuItem("Altas, Bajas y Modificaciones de ventas",
                                      submenu=submenu_ventas)
    submenu_item_ventas.set_menu(menu)

    submenu_item_listados = SubmenuItem("Listados de Artículos, Ventas y Sucursales",
                                        submenu=submenu_listados)
    submenu_item_listados.set_menu(menu)

    # Agrego los ítems al menú principal
    menu.append_item(submenu_item_articulos)
    menu.append_item(submenu_item_ventas)
    menu.append_item(submenu_item_listados)

    # Muestro el menú principal
    menu.start()
    menu.join()


if __name__ == "__main__":
    main()
