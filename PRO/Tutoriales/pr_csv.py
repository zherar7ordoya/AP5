# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-05
# Description: Patrón de diseño Repositorio
# =========================================


import csv

import sqlite3
from colorama import Fore, init

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

    def conectarse(self, txt):
        try:
            with open(txt) as dat:
                return list(csv.reader(dat))
        except FileNotFoundError as e:
            raise ExceptionStore("NO SE ENCONTRÓ EL ARCHIVO", *e.args)

    def desconectarse(self, txt, lista):
        try:
            with open(txt, 'w', newline='\n') as dat:
                csv.writer(dat).writerows(lista)
        except Exception as e:
            raise ExceptionStore("ERROR AL DESCONECTARSE", *e.args)


# --- MAPPER (CRUD) -----------------------------------------------------------

class AlumnoMapeador(AccesoDatos):
    def create(self, objeto, listado):
        try:
            nuevo = [objeto.padron, objeto.apellido, objeto.nombre, objeto.carrera]

            for x in listado:
                for y in x:
                    if y == str(objeto.padron):
                        raise Exception("EL PADRÓN YA EXISTE")

            listado.append(nuevo)
        except Exception as e:
            raise ExceptionStore("ERROR AL CREAR", *e.args)

    def read(self, idx, listado):
        try:
            return listado[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL LEER", *e.args)

    def update(self, objeto, idx, listado):
        try:
            nuevo = [objeto.padron, objeto.apellido, objeto.nombre, objeto.carrera]
            listado[idx] = nuevo
        except Exception as e:
            raise ExceptionStore("ERROR AL ACTUALIZAR", *e.args)

    def delete(self, idx, listado):
        try:
            del listado[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL ELIMINAR", *e.args)



# ----

class VentaMapeador(AccesoDatos):
    def create(self, objeto, listado):
        try:
            nuevo = [objeto.cliente, objeto.anio, objeto.mes, objeto.dia, objeto.monto]
            listado.append(nuevo)
        except Exception as e:
            raise ExceptionStore("ERROR AL CREAR", *e.args)

    def read(self, idx, listado):
        try:
            return listado[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL LEER", *e.args)

    def update(self, objeto, idx, listado):
        try:
            nuevo = [objeto.cliente, objeto.anio, objeto.mes, objeto.dia, objeto.monto]
            listado[idx] = nuevo
        except Exception as e:
            raise ExceptionStore("ERROR AL ACTUALIZAR", *e.args)

    def delete(self, idx, listado):
        try:
            del listado[idx]
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


# --- TEST --------------------------------------------------------------------


try:
    with AlumnoMapeador() as abm:
        # Crear
        # lista = abm.conectarse('alumnos.csv')
        # abm.create(Alumno("106", "Tordoya", "Gerardo", "Analista Programador Universitario"), lista)
        # abm.desconectarse('alumnos.csv', lista)
        # print(f"{Fore.GREEN}ALUMNO CREADO{Fore.RESET}")

        # Leer
        # lista = abm.conectarse('alumnos.csv')
        # registro = abm.read(3, lista)
        # abm.desconectarse('alumnos.csv', lista)
        # print(registro)
        # print(f"{Fore.GREEN}ALUMNO LEÍDO{Fore.RESET}")

        # Actualizar
        # registro = Alumno("106", "Tordoya", "Gerardo", "Analista Programador Universitario")
        # lista = abm.conectarse('alumnos.csv')
        # abm.update(registro, 6, lista)
        # abm.desconectarse('alumnos.csv', lista)
        # print(f"{Fore.GREEN}ALUMNO ACTUALIZADO{Fore.RESET}")

        # # Eliminar
        lista = abm.conectarse('alumnos.csv')
        abm.delete(1, lista)
        abm.desconectarse('alumnos.csv', lista)
        print(f"{Fore.GREEN}ALUMNO ELIMINADO (FÍSICAMENTE){Fore.RESET}")

except ExceptionStore as ex:
    raise ExceptionStore("ERROR AL ELIMINAR", *ex.args)



# try:
#     with VentaMapeador() as abm:
#         # Crear
#         lista = abm.conectarse('ventas.csv')
#         abm.create(Venta("Dario Cardacci", 2022, 11, "06", 9876.54), lista)
#         abm.desconectarse('ventas.csv', lista)
#         print(f"{Fore.GREEN}VENTA CREADA{Fore.RESET}")
#
#         # Leer
#         lista = abm.conectarse('ventas.csv')
#         registro = abm.read(7, lista)
#         print(registro)
#         print(f"{Fore.GREEN}VENTA LEÍDA{Fore.RESET}")
#
#         # Actualizar
#         venta = Venta("Dario Cardacci", 2022, 11, "06", 9876.54)
#         lista = abm.conectarse('ventas.csv')
#         abm.update(venta, 11, lista)
#         abm.desconectarse('ventas.csv', lista)
#         print(f"{Fore.GREEN}VENTA ACTUALIZADA{Fore.RESET}")
#
#         # Eliminar
#         lista = abm.conectarse('ventas.csv')
#         abm.delete(10, lista)
#         abm.desconectarse('ventas.csv', lista)
#         print(f"{Fore.GREEN}VENTA ELIMINADA (FÍSICAMENTE){Fore.RESET}")
#
# except ExceptionStore as ex:
#     raise ExceptionStore("ERROR AL ELIMINAR", *ex.args)
