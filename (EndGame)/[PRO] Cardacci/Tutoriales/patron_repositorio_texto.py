# ================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-05
# Description: Patrón de diseño Repositorio para archivos de texto
# ================================================================

# NOTA: Estoy esperando la respuesta de Cardacci para saber si
#       efectivamente este código es correcto.

import csv
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


# --- TEST --------------------------------------------------------------------

try:
    with NotaMapeador() as abm:
        # Crear
        abm.create(Nota("107", "Estadistica", "10"))
        print(f"{Fore.GREEN}NOTA CREADA{Fore.RESET}")

        # Leer
        registro = abm.read(3)
        print(registro)
        print(f"{Fore.GREEN}NOTA LEÍDA{Fore.RESET}")

        # Actualizar
        registro = Nota("107", "Programacion II", "10")
        abm.update(registro, 0)
        print(f"{Fore.GREEN}NOTA ACTUALIZADA{Fore.RESET}")

        # Eliminar
        abm.delete(0)
        print(f"{Fore.GREEN}NOTA ELIMINADA (FÍSICAMENTE){Fore.RESET}")

except ExceptionStore as ex:
    raise ExceptionStore("SE HA DETECTADO UN ERROR. LA APLICACIÓN SE CERRARÁ.", *ex.args)

try:
    with AlumnoMapeador() as abm:
        # Crear
        abm.create(Alumno("107", "Tordoya", "Gerardo", "Analista Programador"))
        print(f"{Fore.GREEN}ALUMNO CREADO{Fore.RESET}")

        # Leer
        registro = abm.read(3)
        print(registro)
        print(f"{Fore.GREEN}ALUMNO LEÍDO{Fore.RESET}")

        # Actualizar
        registro = Alumno("106", "Tordoya", "Gerardo", "Analista Programador Universitario")
        abm.update(registro, 6)
        print(f"{Fore.GREEN}ALUMNO ACTUALIZADO{Fore.RESET}")

        # Eliminar
        abm.delete(1)
        print(f"{Fore.GREEN}ALUMNO ELIMINADO (FÍSICAMENTE){Fore.RESET}")

except ExceptionStore as ex:
    raise ExceptionStore("SE HA DETECTADO UN ERROR. LA APLICACIÓN SE CERRARÁ.", *ex.args)

try:
    with VentaMapeador() as abm:
        # Crear
        abm.create(Venta("Dario Cardacci", 2022, 11, "06", 9876.54))
        print(f"{Fore.GREEN}VENTA CREADA{Fore.RESET}")

        # Leer
        registro = abm.read(7)
        print(registro)
        print(f"{Fore.GREEN}VENTA LEÍDA{Fore.RESET}")

        # Actualizar
        venta = Venta("Dario Cardacci", 2022, 11, "06", 9876.54)
        abm.update(venta, 11)
        print(f"{Fore.GREEN}VENTA ACTUALIZADA{Fore.RESET}")

        # Eliminar
        abm.delete(10)
        print(f"{Fore.GREEN}VENTA ELIMINADA (FÍSICAMENTE){Fore.RESET}")

except ExceptionStore as ex:
    raise ExceptionStore("ERROR AL ELIMINAR", *ex.args)
