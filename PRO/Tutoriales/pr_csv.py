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


# --- MAPPER (CRUD) -----------------------------------------------------------
class BaseStore:
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


class VentaMapper(BaseStore):
    def create(self, objeto, lista):
        try:
            nuevo = [objeto.cliente, objeto.anio, objeto.mes, objeto.dia, objeto.monto]
            lista.append(nuevo)
        except Exception as e:
            raise ExceptionStore("ERROR AL CREAR", *e.args)

    def read(self, idx, lista):
        try:
            return lista[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL LEER", *e.args)

    def update(self, objeto, idx, lista):
        try:
            nuevo = [objeto.cliente, objeto.anio, objeto.mes, objeto.dia, objeto.monto]
            lista[idx] = nuevo
        except Exception as e:
            raise ExceptionStore("ERROR AL ACTUALIZAR", *e.args)

    def delete(self, idx, lista):
        try:
            del lista[idx]
        except Exception as e:
            raise ExceptionStore("ERROR AL ELIMINAR", *e.args)


# --- ENTIDADES ---------------------------------------------------------------

class Alumno:
    def __init__(self, padron,  apellido, nombre, materia):
        self.padron = padron
        self.apellido = apellido
        self.nombre = nombre
        self.materia = materia


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
    with VentaMapper() as abm:
        # Crear
        lista = abm.conectarse('ventas.csv')
        abm.create(Venta("Dario Cardacci", 2020, "08", 26, 1000.21), lista)
        abm.desconectarse('ventas.csv', lista)
        print(f"{Fore.GREEN}VENTA CREADA{Fore.RESET}")

        # Leer
        lista = abm.conectarse('ventas.csv')
        registro = abm.read(7, lista)
        print(registro)
        print(f"{Fore.GREEN}VENTA LEÍDA{Fore.RESET}")

        # Actualizar
        venta = Venta("Ricardo Darin", 2022, "08", 26, 1000.21)
        lista = abm.conectarse('ventas.csv')
        abm.update(venta, 1, lista)
        abm.desconectarse('ventas.csv', lista)
        print(f"{Fore.GREEN}VENTA ACTUALIZADA{Fore.RESET}")

        # Eliminar
        lista = abm.conectarse('ventas.csv')
        abm.delete(0, lista)
        abm.desconectarse('ventas.csv', lista)
        print(f"{Fore.GREEN}VENTA ELIMINADA (FÍSICAMENTE){Fore.RESET}")

except ExceptionStore as error:
    print(error)
