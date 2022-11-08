# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-05
# Description: Patrón de diseño Repositorio
# =========================================

# NOTA > No crea la tabla, ya debe existir

# NOTA > Voy a enviar este código a Cardacci para que me diga si es correcto
#        o no. Porque no estoy seguro si es correcto o no.


import shutil
import sqlite3
from colorama import Fore, init

init()


# --- DAL ---------------------------------------------------------------------
def conectarse():
    return sqlite3.connect('BDD.sqlite')


# No puedo hacer una función porque necesito heredar a Exception
class DetalleException(Exception):
    def __init__(self, mensaje, *excepcion):
        Exception.__init__(self, mensaje)
        self.excepcion = excepcion

        # Quiero centrar el mensaje. Para eso uso el método center()
        # que necesita como parámetro el ancho de la pantalla.
        ancho = shutil.get_terminal_size().columns

        print(Fore.RED)
        print(excepcion[0].center(ancho))
        print(Fore.RESET)

        input("Presione una tecla para continuar...")


# --- CLASE BASE --------------------------------------------------------------
class ClaseBase:
    def __init__(self):
        try:
            self.conexion = conectarse()
        except Exception as e:
            raise DetalleException(*e.args)
        self._completo = False

    def __enter__(self):
        """ Método mágico para el uso de with que se ejecuta al inicio """
        return self

    def __exit__(self, type_, value, traceback):
        """ Método mágico para el uso de with que se ejecuta al final """
        self.cerrar()

    def completo(self):
        self._completo = True

    def cerrar(self):
        if self.conexion:
            try:
                if self._completo:
                    self.conexion.commit()
                else:
                    self.conexion.rollback()
            except Exception as e:
                raise DetalleException(*e.args)
            finally:
                try:
                    self.conexion.close()
                except Exception as e:
                    raise DetalleException(*e.args)


# --- MAPPER (CRUD) -----------------------------------------------------------
class UsuarioMapper(ClaseBase):
    def create(self, objeto):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'INSERT INTO Usuarios(Nombre, Apellido, Domicilio, Comentario) '
                              f'VALUES("'
                              f'{objeto.nombre}", "'
                              f'{objeto.apellido}", "'
                              f'{objeto.domicilio}", "'
                              f'{objeto.comentario}")')
            print(f"ID > {indicador.lastrowid}")
        except Exception as e:
            raise DetalleException("ERROR AL CREAR EL USUARIO", *e.args)

    def read(self, usuario_id):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'SELECT * '
                              f'FROM Usuarios '
                              f'WHERE UsuarioID = {usuario_id}')
            return indicador.fetchone()
        except Exception as e:
            raise DetalleException("ERROR AL LEER EL USUARIO", *e.args)

    def update(self, objeto):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'UPDATE Usuarios '
                              f'SET '
                              f'Nombre = "{objeto.nombre}", '
                              f'Apellido = "{objeto.apellido}", '
                              f'Domicilio = "{objeto.domicilio}", '
                              f'Comentario = "{objeto.comentario}" '
                              f'WHERE UsuarioID = {objeto.usuario_id}')
        except Exception as e:
            raise DetalleException("ERROR AL ACTUALIZAR EL USUARIO", *e.args)

    def delete(self, usuario_id):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'DELETE FROM Usuarios '
                              f'WHERE UsuarioID = {usuario_id}')
        except Exception as e:
            raise DetalleException("ERROR AL ELIMINAR EL USUARIO", *e.args)


# --- ENTIDADES ---------------------------------------------------------------
class Usuario:
    def __init__(self, nombre, apellido, domicilio, comentario):
        self.usuario_id = 0
        self.nombre = nombre
        self.apellido = apellido
        self.domicilio = domicilio
        self.comentario = comentario


# --- TEST --------------------------------------------------------------------
try:
    with UsuarioMapper() as usuario_store:
        # # Crear
        # usuario = Usuario("Gerardo", "Tordoya", "Alte. Brown", "Prueba de ingreso")
        # usuario_store.create(usuario)
        # usuario_store.completo()
        # print(f"{Fore.GREEN}USUARIO CREADO{Fore.RESET}")
        #
        # # Leer
        # usuario = usuario_store.read(7)
        # usuario_store.completo()
        # print(usuario)
        # print(f"{Fore.GREEN}USUARIO LEÍDO{Fore.RESET}")

        # Actualizar
        usuario = Usuario("Gerardo", "Tordoya", "Alte. Brown", "Prueba de actualización")
        usuario.usuario_id = 102
        usuario_store.update(usuario)
        usuario_store.completo()
        print(f"{Fore.GREEN}USUARIO ACTUALIZADO{Fore.RESET}")

        # # Eliminar
        # usuario_store.delete(3)
        # usuario_store.completo()
        # print(f"{Fore.GREEN}USUARIO ELIMINADO{Fore.RESET}")

except DetalleException as error:
    print(error)
