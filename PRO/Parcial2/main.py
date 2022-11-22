# =======================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-21
# Description: Mi Programa en Python v2.0
# =======================================


# ******************************************************************************
# NOTA PARA EL PROFESOR CARDACCI:
# ------------------------------
#
# En la consola de Visual Studio, Colorama se niega a trabajar como lo hace en
# otras consolas. Igual que con el 1er parcial, para ver los colores, se debe
# ejecutar el programa desde la consola de Windows.
# Referencia: https://pypi.org/project/colorama/
#
# WHY DOESN'T COLORAMA WORK WITH VISUAL STUDIO?
# Well, these are (and colorama would do that for non-windows terminals I
# presume) ANSI escape codes which are interpreted by the terminal emulation.
# I.e. most likely VS does terminal emulation does not support them. 
# Referencia: https://stackoverflow.com/questions/65365077/why-doesnt-colorama-work-with-visual-studio
# ******************************************************************************


import click
import csv
import re
from colorama import init
from colorama import Fore
from consolemenu import *
from consolemenu.items import *
from decimal import Decimal

# Esto es lo más que se puede lograr con Colorama en VS: que init() filtre las
# secuencias de escape ANSI y las reemplace por una cadena vacía.
init()


# --- CAPA TRANSVERSAL (si esto fuera una arquitectura en capas) ---------------

# Todavía estoy investigando esta técnica.
class ExceptionCapturada(Exception):
    def __init__(self, mensaje, *errores):
        Exception.__init__(self, mensaje)
        self.errores = errores
        print(f"\n{Fore.RED}{errores[0]}{Fore.RESET}")
        input("Presione una tecla para continuar...")


# --- DAL (si esto fuera una arquitectura en capas) ----------------------------

class AccesoDatos:

    def __enter__(self):
        """ Método mágico para el uso de with que se ejecuta al inicio """
        return self

    # No toques los argumentos, no importa lo que Pylint diga.
    def __exit__(self, *args, **kwargs):
        """ Método mágico para el uso de with que se ejecuta al final """
        return self

    # Pylint me dice que el método leer() puede ser estático, pero no me lo justifica.
    def leer(self, archivo):
        try:
            with open(archivo) as dat:
                return list(csv.reader(dat))
        except FileNotFoundError as e:
            raise ExceptionCapturada("NO SE ENCONTRÓ EL ARCHIVO", *e.args)

    # Pylint me dice que el método escribir() puede ser estático, pero no me lo justifica.
    def escribir(self, archivo, lista):
        try:
            with open(archivo, 'w', newline='\n') as dat:
                csv.writer(dat).writerows(lista)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL CERRAR EL ARCHIVO", *e.args)


# --- MAPPER (si esto fuera una arquitectura en capas) -------------------------

# MAPPER DE LA ENTIDAD ARTÍCULO
# La estrategia del mapeador, en líneas generales, es siempre la misma: leer,
# operar, escribir. Leer y escribir están en la clase base, así que me
# despreocupo de eso y me concentro en las operaciones CRUD en sí.

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


# MAPPER DE LA ENTIDAD VENTA

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


# --- ENTIDADES (si esto fuera una arquitectura en capas) ----------------------

class Articulo:
    def __init__(self, codigo, descripcion, stock):
        self.codigo = codigo
        self.descripcion = descripcion
        self.stock = stock

    def __str__(self):
        return """
                 Código  {}
            Descripción  {}
                  Stock  {}"""\
            .format(self.codigo,
                    self.descripcion,
                    self.stock)


class Venta:
    def __init__(self, fecha, codigo, vendedor, sucursal, importe):
        self.fecha = fecha
        self.codigo = codigo
        self.vendedor = vendedor
        self.sucursal = sucursal
        self.importe = importe

    def __str__(self):
        return """
               Fecha  {}
              Código  {}
            Vendedor  {}
            Sucursal  {}
             Importe  {}"""\
            .format(self.fecha,
                    self.codigo,
                    self.vendedor,
                    self.sucursal,
                    self.importe)


# --- CAPA DE NEGOCIO (si esto fuera una arquitectura en capas) ----------------

# VALIDACIONES
# A qué japonés se le ocurrió las regex...

class Valida:

    @staticmethod
    def valida_codigo(codigo):
        if re.match("([A-Z]\d{3})", codigo):
            return True
        return False

    @staticmethod
    def existe_codigo(codigo):
        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        if any(codigo in lista_anidada for lista_anidada in listado):
            return True
        return False

        # for articulo in listado:
        #     if articulo[0] == codigo:
        #         return True
        # return False

    @staticmethod
    def valida_descripcion(descripcion):
        if re.match("([A-Z]\w{3,})", descripcion):
            return True
        return False

    @staticmethod
    def valida_stock(stock):
        if re.match("([1-9]\d*)", stock):
            return True
        return False

    @staticmethod
    def valida_fecha(fecha):
        if re.match("(\d{2}/\d{2}/\d{4})", fecha):
            return True
        return False

    @staticmethod
    def valida_vendedor(vendedor):
        if re.match("([A-Za-z]\w{3,})", vendedor):
            return True
        return False

    @staticmethod
    def valida_sucursal(sucursal):
        if re.match("([A-Z]{3,3}\d{3,3})", sucursal):
            return True
        return False

    @staticmethod
    def valida_importe(importe):
        if re.match("(\d*\.?\d*)", importe):
            return True
        return False


# ASISTENTES DE ABM DE ARTÍCULOS ***********************************************
# Solo una cosa voy a decir de estas funciones. Son validadoras, y mientras no
# den por bueno el análisis, no salen del bucle. Y es por eso que no vi la
# necesidad de ningún error-handler.
#
# Esto necesito aclararlo: obtener_articulo() y obtener_codigo() hacen lo mismo
# excepto que:
#   -)  obtener_articulo() se usa en las modificaciones (update), ya que
#       verifica que exista el "registro" (código) a modificar.
#   -)  En cambio, obtener_codigo() se utiliza en las altas (create) porque
#       revisa que el código a dar de alta no exista (no esté repetido).
def obtener_codigo():
    while True:
        codigo = input("Código (LNNN): ")
        if Valida.valida_codigo(codigo) and not Valida.existe_codigo(codigo):
            return codigo
        else:
            print("Error. Debe ingresar 1 letra mayúscula + 3 números (de un código que no existe)")


def obtener_descripcion():
    while True:
        descripcion = input("Descripción: ")
        if Valida.valida_descripcion(descripcion):
            return descripcion
        else:
            print("Error. Debe ingresar 1 letra mayúscula + 3 letras o más")


def obtener_stock():
    while True:
        stock = input("Stock (N): ")
        if Valida.valida_stock(stock):
            return stock
        else:
            print("Error. Debe ingresar 1 número mayor a 0")


# ABM DE ARTÍCULOS *************************************************************
# La idea era que estas funciones quedaran cortitas y fáciles de leer.

def alta_articulo():
    try:
        print("ALTA DE ARTÍCULO")
        print("================\n")

        articulo = Articulo(obtener_codigo(),
                            obtener_descripcion(),
                            obtener_stock())
        articulo_mapeador = ArticuloMapeador()

        if click.confirm(f"\n¿Confirma el alta?"):
            articulo_mapeador.create(articulo)
            print(f"\nIngresado > {Fore.YELLOW}{articulo}{Fore.RESET}")
            input("\nOperación completada (presione una tecla para continuar)")
        else:
            input("\nOperación cancelada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def baja_articulo():
    try:
        print("BAJA DE ARTÍCULO")
        print("================\n")

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        # Este es un caso especial. Exception no abarca a ValueError.
        while True:
            try:
                idx = int(input("\nIngrese el número de registro del artículo a eliminar: "))
                break
            except ValueError:
                print("Error. Debe ingresar un número entero")

        if click.confirm(f"\n¿Confirma la baja?"):
            articulo_mapeador.delete(idx)
            print(f"\nEliminado > {Fore.YELLOW}{listado[idx]}{Fore.RESET}")
            input("\nOperación completada (presione una tecla para continuar)")
        else:
            input("\nOperación cancelada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def modificacion_articulo():
    try:
        print("MODIFICACIÓN DE ARTÍCULO")
        print("========================\n")

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        # Este es un caso especial. Exception no abarca a ValueError.
        while True:
            try:
                idx = int(input("\nIngrese el número de registro del artículo a modificar: "))
                break
            except ValueError:
                print("Error. Debe ingresar un número entero")

        print("\nIngrese los nuevos datos del artículo")

        # En este caso, no se puede usar obtener_codigo() porque el código
        # no se puede modificar.
        articulo = Articulo(listado[idx][0],
                            obtener_descripcion(),
                            obtener_stock())

        if click.confirm(f"\n¿Confirma la modificación?"):
            articulo_mapeador.update(articulo, idx)
            print(f"\nModificado > {Fore.YELLOW}{articulo}{Fore.RESET}")
            input("\nOperación completada (presione una tecla para continuar)")
        else:
            input("\nOperación cancelada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


# ASISTENTES DE ABM DE VENTAS **************************************************
# Solo una cosa voy a decir de estas funciones. Son validadoras, y mientras no
# den por bueno el análisis, no salen del bucle. Y es por eso que no vi la
# necesidad de ningún error-handler.

def obtener_fecha():
    while True:
        fecha = input("Fecha (dd/mm/aaaa): ")
        if Valida.valida_fecha(fecha):
            return fecha
        else:
            print("Error. Debe ingresar una fecha válida")


# Esto necesito aclararlo:
#   obtener_articulo() > verifica que SÍ exista el codigo
#   obtener_codigo()   > verifica que NO exista el codigo
def obtener_articulo():
    while True:
        codigo = input("Código de artículo (LNNN): ")
        if Valida.valida_codigo(codigo) and Valida.existe_codigo(codigo):
            return codigo
        else:
            print("Error. Debe ingresar 1 letra mayúscula + 3 números (de un código que sí existe)")


def obtener_vendedor():
    while True:
        vendedor = input("Vendedor: ")
        if Valida.valida_vendedor(vendedor):
            return vendedor
        else:
            print("Error. Debe ingresar 1 letra mayúscula + 3 letras o más")


def obtener_sucursal():
    while True:
        sucursal = input("Sucursal (LLLNNN): ")
        if Valida.valida_sucursal(sucursal):
            return sucursal
        else:
            print("Error. Debe ingresar 3 letras mayúsculas + 3 números")


def obtener_importe():
    while True:
        importe = input("Importe: ")
        if Valida.valida_importe(importe):
            return importe
        else:
            print("Error. Debe ingresar un importe válido (NN.DD)")


# ABM DE VENTAS ****************************************************************
# La idea era que estas funciones quedaran cortitas y fáciles de leer.

def alta_venta():
    try:
        print("ALTA DE VENTA")
        print("=============\n")

        venta = Venta(obtener_fecha(),
                      obtener_articulo(),
                      obtener_vendedor(),
                      obtener_sucursal(),
                      obtener_importe())
        venta_mapeador = VentaMapeador()
        venta_mapeador.create(venta)

        print(f"\nIngresado > {venta}")
        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def baja_venta():
    try:
        print("BAJA DE VENTA")
        print("=============\n")

        venta_mapeador = VentaMapeador()

        listado = venta_mapeador.leer(venta_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)

        # Este es un caso especial. Exception no abarca a ValueError.
        while True:
            try:
                idx = int(input("\nIngrese el número de registro de la venta a eliminar: "))
                break
            except ValueError:
                print("Error. Debe ingresar un número entero")

        venta_mapeador.delete(idx)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def modificacion_venta():
    try:
        print("MODIFICACIÓN DE VENTA")
        print("=====================\n")

        venta_mapeador = VentaMapeador()
        listado = venta_mapeador.leer(venta_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        # Este es un caso especial. Exception no abarca a ValueError.
        while True:
            try:
                idx = int(input("\nIngrese el número de registro de la venta a modificar: "))
                break
            except ValueError:
                print("Error. Debe ingresar un número entero")

        print("\nIngrese los nuevos datos de la venta")
        venta = Venta(obtener_fecha(),
                      obtener_articulo(),
                      obtener_vendedor(),
                      obtener_sucursal(),
                      obtener_importe())

        venta_mapeador.update(venta, idx)

        print(f"\nModificado > {venta}")
        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


# LISTADOS Y REPORTES (CONSULTAS) **********************************************
def listado_articulos():
    try:
        print("LISTADO DE ARTÍCULOS")
        print("====================\n")

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


def listado_ventas():
    try:
        print("LISTADO DE VENTAS")
        print("=================\n")

        venta_mapeador = VentaMapeador()
        listado = venta_mapeador.leer(venta_mapeador.archivo)

        for idx, x in enumerate(listado):
            print(idx, x)

        input("\nOperación completada (presione una tecla para continuar)")

    except ExceptionCapturada as e:
        print(e)


# APAREO Y CORTE DE CONTROL ****************************************************
# Esta es una sección especial y por eso la dejo con su propio título

# ASISTENTES DE APOYO
# Abro, leo, ordeno y guardo el archivo
def ordenar_archivo(archivo):
    with open(archivo) as dat:
        lista = list(csv.reader(dat))
        ordenar_lista(lista)
    with open(archivo, 'w', newline='\n') as dat:
        csv.writer(dat).writerows(lista)


# Ordenamiento por Selección (Selection Sort)
# Esto lo tengo que aclarar:
# ¿Por qué tres bucles y así: if lista[evaluado][i] > lista[x][i]?
# El archivo de ventas está ordenado por fecha, artículo, vendedor, sucursal e
# importe (en ese orden). Cuando yo presenté este algoritmo la primera vez, la
# primera "columna" era la de los códigos (como usualmente lo es). En este caso,
# la columna ordenadora (sucursales) está en la posición 4. Pero el reporte no
# pide solo ese agrupamiento, sino que también pide agrupar por artículo y
# vendedor. Entonces, para que el algoritmo funcione, tengo que comparar
# secuencialmente las columnas 2, 1 y 4 (vendedor, artículo y sucursal), ya que
# así es el agrupamiento pedido en el reporte.
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


# Esto hay que explicarlo: si hay apareo, solo sucede con este ítem. En la
# consigna de Cardacci, se pide agrupar por artículos (específicamente: por el
# nombre de los artículos). Internamente (en los while) trabajo con los códigos
# de los artículos, pero le muestro al usuario el nombre del artículo, y eso
# explica esta función tan extraña.
def get_descripcion(codigo):
    try:

        articulo_mapeador = ArticuloMapeador()
        listado = articulo_mapeador.leer(articulo_mapeador.archivo)

        # Le ahorro tiempo al programador que quiera eliminar idx: no lo hagas.
        for idx, x in enumerate(listado):
            if x[0] == codigo:
                return x[1]

    except ExceptionCapturada as e:
        print(e)


# PROCEDIMIENTO PRINCIPAL DE APAREO Y CORTE DE CONTROL
# Bueno profesor, esta es la estrella de la película. No la busque más, aquí
# está, con sus while anidados.

def imprimir_reporte(archivo_csv):
    # Esto hay que explicarlo: el corte de control es una operación tan
    # particular que se hace engorroso (más difícil de entender) si descanso
    # sobre el CRUD hecho para todo lo demás. Opero directamente sobre el
    # archivo justificado por la regla de balance (una complejización debe
    # inyectarse para resolver una complejidad mayor, sino no procede).
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

    # Como decían los Looney Tunes: ¡Eso es todo, amigos!
    archivo.close()


# Y esto es lo primero que el usuario ve y así se organiza todo.
def reporte_sucursales():
    try:
        print("REPORTE DE SUCURSALES")
        print("=====================\n")

        venta_mapeador = VentaMapeador()
        ordenar_archivo(venta_mapeador.archivo)
        imprimir_reporte(venta_mapeador.archivo)

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
