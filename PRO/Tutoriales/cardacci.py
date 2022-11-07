# =================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-06
# Description: Ejercicio propuesto por Cardacci en la VC 2022-11-04
# =================================================================
import os
from decimal import *
from colorama import Fore, init
import csv

init()


class ExceptionStore(Exception):
    def __init__(self, mensaje, *errores):
        Exception.__init__(self, mensaje)
        self.errores = errores
        print(f"\n{Fore.RED}\t{errores[0]}{Fore.RESET}")


# --- DAL ---------------------------------------------------------------------

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
            raise ExceptionStore("NO SE ENCONTRÓ EL ARCHIVO", *e.args)

    def escribir(self, archivo, lista):
        try:
            with open(archivo, 'w', newline='\n') as dat:
                csv.writer(dat).writerows(lista)
        except Exception as e:
            raise ExceptionStore("ERROR AL DESCONECTARSE", *e.args)


# --- MAPPER (CRUD) -----------------------------------------------------------

class AlumnoMapeador(AccesoDatos):

    def __init__(self):
        self.archivo = 'alumnos.csv'

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.padron, objeto.apellido, objeto.nombre, objeto.carrera]

            for x in listado:
                for y in x:
                    if y == str(objeto.padron):
                        raise Exception("EL PADRÓN YA EXISTE")

            listado.append(nuevo)
            self.escribir(self.archivo, listado)

        except Exception as e:
            raise ExceptionStore("ERROR AL CREAR", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer(self.archivo)
            return listado[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL LEER", *e.args)

    # *** MODIFICACIONES ***
    def update(self, objeto, idx):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.padron, objeto.apellido, objeto.nombre, objeto.carrera]
            listado[idx] = nuevo
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionStore("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer(self.archivo)
            del listado[idx]
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionStore("ERROR AL ELIMINAR", *e.args)


# *---

class NotaMapeador(AccesoDatos):

    def __init__(self):
        self.archivo = 'notas.csv'

    # *** ALTAS ***
    def create(self, objeto):
        try:
            nuevo = [objeto.padron, objeto.materia, objeto.nota]
            listado = self.leer(self.archivo)

            # Necesito la lista de alumnos para validar el padrón
            alumnos = self.leer('alumnos.csv')

            # Cada alumno tiene varias materias.
            # Si agrego el objeto en cada coincidencia, se duplica varias veces.
            existe = False

            for x in alumnos:
                for y in x:
                    if y == str(objeto.padron):
                        # Si el padrón ya existe, habilito la bandera.
                        # Esto es más sencillo que usar un break.
                        existe = True

            if existe:
                listado.append(nuevo)
                self.escribir(self.archivo, listado)
            else:
                raise Exception("EL PADRÓN NO EXISTE")

        except Exception as e:
            raise ExceptionStore("ERROR AL CREAR", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer(self.archivo)
            return listado[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL LEER", *e.args)

    # *** MODIFICACIONES ***
    def update(self, objeto, idx):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.padron, objeto.materia, objeto.nota]
            listado[idx] = nuevo
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionStore("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer(self.archivo)
            del listado[idx]
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionStore("ERROR AL ELIMINAR", *e.args)


# *---

class VentaMapeador(AccesoDatos):

    def __init__(self):
        self.archivo = 'ventas.csv'

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.cliente, objeto.anio, objeto.mes, objeto.dia, objeto.monto]
            listado.append(nuevo)
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionStore("ERROR AL CREAR", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer(self.archivo)
            return listado[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL LEER", *e.args)

    # *** MODIFICACIONES ***
    def update(self, objeto, idx):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.cliente, objeto.anio, objeto.mes, objeto.dia, objeto.monto]
            listado[idx] = nuevo
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionStore("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer(self.archivo)
            del listado[idx]
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionStore("ERROR AL ELIMINAR", *e.args)


# --- ENTIDADES ---------------------------------------------------------------

class Alumno:
    def __init__(self, padron, apellido, nombre, carrera):
        self.padron = padron
        self.apellido = apellido
        self.nombre = nombre
        self.carrera = carrera


class Nota:
    def __init__(self, padron, materia, nota):
        self.padron = padron
        self.materia = materia
        self.nota = nota


class Venta:
    def __init__(self, cliente, anio, mes, dia, monto):
        self.cliente = cliente
        self.anio = anio
        self.mes = mes
        self.dia = dia
        self.monto = monto


# --- MÉTODOS DE LA 1RA PARTE DEL EJERCICIO -----------------------------------

def alta_alumno():
    try:
        print("ALTA DE ALUMNO")
        print("==============")
        padron = int(input("Ingrese el padrón del alumno: "))
        apellido = input("Ingrese el apellido del alumno: ")
        nombre = input("Ingrese el nombre del alumno: ")
        carrera = input("Ingrese la carrera del alumno: ")
        alumno = Alumno(padron, apellido, nombre, carrera)
        alumno_mapeador = AlumnoMapeador()
        alumno_mapeador.create(alumno)
        print("Alumno creado correctamente")
    except ExceptionStore as e:
        print(e)


def baja_alumno():
    try:
        print("BAJA DE ALUMNO")
        print("==============")
        alumno_mapeador = AlumnoMapeador()
        listado = alumno_mapeador.leer(alumno_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice del alumno a eliminar: "))
        alumno_mapeador.delete(idx)
        print("Alumno eliminado correctamente")
    except ExceptionStore as e:
        print(e)


def modificacion_alumno():
    try:
        print("MODIFICACIÓN DE ALUMNO")
        print("======================")
        alumno_mapeador = AlumnoMapeador()
        listado = alumno_mapeador.leer(alumno_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice del alumno a modificar: "))
        padron = int(input("Ingrese el padrón del alumno: "))
        apellido = input("Ingrese el apellido del alumno: ")
        nombre = input("Ingrese el nombre del alumno: ")
        carrera = input("Ingrese la carrera del alumno: ")
        alumno = Alumno(padron, apellido, nombre, carrera)
        alumno_mapeador.update(alumno, idx)
        print("Alumno modificado correctamente")
    except ExceptionStore as e:
        print(e)


def consulta_alumno():
    try:
        print("CONSULTA DE ALUMNO")
        print("==================")
        alumno_mapeador = AlumnoMapeador()
        listado = alumno_mapeador.leer(alumno_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice del alumno a consultar: "))
        alumno = alumno_mapeador.read(idx)
        print(alumno)
    except ExceptionStore as e:
        print(e)


def alta_nota():
    try:
        print("ALTA DE NOTA")
        print("============")
        padron = int(input("Ingrese el padrón del alumno: "))
        materia = input("Ingrese la materia: ")
        nota = float(input("Ingrese la nota: "))
        nota = Nota(padron, materia, nota)
        nota_mapeador = NotaMapeador()
        nota_mapeador.create(nota)
        print("Nota creada correctamente")
    except ExceptionStore as e:
        print(e)


def baja_nota():
    try:
        print("BAJA DE NOTA")
        print("============")
        nota_mapeador = NotaMapeador()
        listado = nota_mapeador.leer(nota_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice de la nota a eliminar: "))
        nota_mapeador.delete(idx)
        print("Nota eliminada correctamente")
    except ExceptionStore as e:
        print(e)


def modificacion_nota():
    try:
        print("MODIFICACIÓN DE NOTA")
        print("====================")
        nota_mapeador = NotaMapeador()
        listado = nota_mapeador.leer(nota_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice de la nota a modificar: "))
        padron = int(input("Ingrese el padrón del alumno: "))
        materia = input("Ingrese la materia: ")
        nota = float(input("Ingrese la nota: "))
        nota = Nota(padron, materia, nota)
        nota_mapeador.update(nota, idx)
        print("Nota modificada correctamente")
    except ExceptionStore as e:
        print(e)


def consulta_nota():
    try:
        print("CONSULTA DE NOTA")
        print("================")
        nota_mapeador = NotaMapeador()
        listado = nota_mapeador.leer(nota_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice de la nota a consultar: "))
        nota = nota_mapeador.read(idx)
        print(nota)
    except ExceptionStore as e:
        print(e)


def alta_venta():
    try:
        print("ALTA DE VENTA")
        print("=============")
        codigo = int(input("Ingrese el código del producto: "))
        cantidad = int(input("Ingrese la cantidad: "))
        venta = Venta(codigo, cantidad)
        venta_mapeador = VentaMapeador()
        venta_mapeador.create(venta)
        print("Venta creada correctamente")
    except ExceptionStore as e:
        print(e)


def baja_venta():
    try:
        print("BAJA DE VENTA")
        print("=============")
        venta_mapeador = VentaMapeador()
        listado = venta_mapeador.leer(venta_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice de la venta a eliminar: "))
        venta_mapeador.delete(idx)
        print("Venta eliminada correctamente")
    except ExceptionStore as e:
        print(e)


def modificacion_venta():
    try:
        print("MODIFICACIÓN DE VENTA")
        print("=====================")
        venta_mapeador = VentaMapeador()
        listado = venta_mapeador.leer(venta_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice de la venta a modificar: "))
        codigo = int(input("Ingrese el código del producto: "))
        cantidad = int(input("Ingrese la cantidad: "))
        venta = Venta(codigo, cantidad)
        venta_mapeador.update(venta, idx)
        print("Venta modificada correctamente")
    except ExceptionStore as e:
        print(e)


def consulta_venta():
    try:
        print("CONSULTA DE VENTA")
        print("=================")
        venta_mapeador = VentaMapeador()
        listado = venta_mapeador.leer(venta_mapeador.archivo)
        for idx, x in enumerate(listado):
            print(idx, x)
        idx = int(input("Ingrese el índice de la venta a consultar: "))
        venta = venta_mapeador.read(idx)
        print(venta)
    except ExceptionStore as e:
        print(e)


# --- COMÚN PARA EL TRABAJO CON ARCHIVOS --------------------------------------

# Abro, leo, ordeno y guardo el archivo
def procesar_archivo(txt):
    with open(txt) as dat:
        lista = list(csv.reader(dat))
        ordenar_archivo(lista)
    with open(txt, 'w', newline='\n') as dat:
        csv.writer(dat).writerows(lista)


# Ordenamiento por Selección (Selection Sort)
def ordenar_archivo(lista):
    for idx in range(len(lista)):
        evaluado = idx
        for x in range(idx + 1, len(lista)):
            if lista[evaluado] > lista[x]:
                evaluado = x
        lista[idx], lista[evaluado] = lista[evaluado], lista[idx]


# --- APAREO ENTRE ARCHIVOS ---------------------------------------------------


def leer_datos(datos):
    try:
        return datos.next()
    except:
        return None


def imprimir_notas_alumnos(alumnos, notas):
    notas_a = open(notas)
    alumnos_a = open(alumnos)
    notas_csv = csv.reader(notas_a)
    alumnos_csv = csv.reader(alumnos_a)

    # Empieza a leer
    alumno = next(alumnos_csv)
    nota = next(notas_csv)
    while alumno:
        print("\n\t" + alumno[2] + ", " + alumno[1] + " - " + alumno[0])
        if not nota or nota[0] != alumno[0]:
            print("\t\tNo se registran notas")
        while nota and nota[0] == alumno[0]:
            print("\t\t" + nota[1] + ": " + nota[2])
            try:
                nota = next(notas_csv)
            except StopIteration:
                nota = None
        try:
            alumno = next(alumnos_csv)
        except StopIteration:
            alumno = None


    # Cierro los archivos
    notas_a.close()
    alumnos_a.close()


def apareo():
    # Defino los archivos y los proceso (abro, leo, ordeno, escribo)
    archivos = ['alumnos.csv', 'notas.csv']
    try:
        for archivo in archivos:
            procesar_archivo(archivo)
    except FileNotFoundError:
        print('No se encontró el archivo')

    # Apareo propiamente dicho
    # Recorro un archivo de alumnos y otro de notas e imprimo las notas que
    # corresponden a cada alumno
    print("APAREO ENTRE ARCHIVOS")
    print("=====================")
    imprimir_notas_alumnos("alumnos.csv", "notas.csv")
    print("\nApareo realizado correctamente\n")
    input("Presione una tecla para continuar...")


# --- CORTE DE CONTROL --------------------------------------------------------


def ventas_clientes_mes(archivo_ventas):
    """ Recorre un archivo csv, con la información almacenada en el
        formato: cliente,an"o,mes,día,venta """
    # Inicialización
    ventas = open(archivo_ventas)
    ventas_csv = csv.reader(ventas)

    # item = leer_datos(ventas_csv)
    item = next(ventas_csv, None)
    total = 0

    while item:
        # Inicialización para el bucle de cliente
        cliente = item[0]
        total_cliente = 0
        print("\n\tCliente %s" % cliente)

        while item and item[0] == cliente:
            # Inicialización para el bucle de año
            anyo = item[1]
            total_anyo = 0
            print("\n\t\tAño: %s" % anyo)

            while item and item[0] == cliente and item[1] == anyo:
                mes, monto = item[2], Decimal(item[4])
                print(f"\t\t\tVentas mes {mes}: {monto}")
                total_anyo += monto
                # Siguiente registro
                item = next(ventas_csv, None)

            # Final del bucle de año
            print(f"\t\t\t\t\t\tTotal {anyo}: {total_anyo}")
            total_cliente += total_anyo

        # Final del bucle de cliente
        print(f"\n\tTotal para {cliente}: {total_cliente}\n")
        total += total_cliente

        # Final del bucle principal
        print("Total general: %.2f" % total)

    # Cierre del archivo
    ventas.close()


def corte_de_control():
    # Defino los archivos y los proceso (abro, leo, ordeno, escribo)
    archivos = ['ventas.csv']
    try:
        for archivo in archivos:
            procesar_archivo(archivo)
    except FileNotFoundError:
        print('No se encontró el archivo')

    # Corte de control propiamente dicho
    print("CORTE DE CONTROL")
    print("================")
    ventas_clientes_mes('ventas.csv')
    print("\nCorte de control realizado correctamente\n")
    input("Presione una tecla para continuar...")



# --- MAIN --------------------------------------------------------------------

while True:
    os.system('cls' if os.name == 'nt' else 'clear')
    print(f"""
    {Fore.GREEN}ABM en archivos .csv{Fore.RESET}
    
        {Fore.CYAN}ALUMNOS{Fore.RESET}
            1. Alta en archivo Alumnos
            2. Baja en archivo Alumnos
            3. Modificación en archivo Alumnos
            4. Consulta en archivo Alumnos
            
        {Fore.CYAN}NOTAS{Fore.RESET}
            5. Alta en archivo Notas
            6. Baja en archivo Notas
            7. Modificación en archivo Notas
            8. Consulta en archivo Notas
            
        {Fore.CYAN}VENTAS{Fore.RESET}
            9.  Alta en archivo Ventas
            10. Baja en archivo Ventas
            11. Modificación en archivo Ventas
            12. Consulta en archivo Ventas
            
    {Fore.GREEN}Apareo y Corte de Control{Fore.RESET}
            13. Apareo entre archivos Alumnos y Notas
            14. Corte de Control en archivo Ventas
            
            {Fore.YELLOW}15. Salir{Fore.RESET}            
    """)

    opcion = input("Ingrese opción > ")
    os.system('cls' if os.name == 'nt' else 'clear')

    if opcion == '1':
        alta_alumno()
    elif opcion == '2':
        baja_alumno()
    elif opcion == '3':
        modificacion_alumno()
    elif opcion == '4':
        consulta_alumno()
    elif opcion == '5':
        alta_nota()
    elif opcion == '6':
        baja_nota()
    elif opcion == '7':
        modificacion_nota()
    elif opcion == '8':
        consulta_nota()
    elif opcion == '9':
        alta_venta()
    elif opcion == '10':
        baja_venta()
    elif opcion == '11':
        modificacion_venta()
    elif opcion == '12':
        consulta_venta()
    elif opcion == '13':
        apareo()
    elif opcion == '14':
        corte_de_control()
    elif opcion == '15':
        print("¿Está seguro que desea salir? (S/N)")
        respuesta = input("Respuesta > ")
        if respuesta == 'S' or respuesta == 's':
            print("Saliendo...")
            break
        else:
            print("Continuando...")
