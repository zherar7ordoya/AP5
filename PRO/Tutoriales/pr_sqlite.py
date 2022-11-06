# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-05
# Description: Patrón de diseño Repositorio
# =========================================

# NOTA > No crea la tabla, ya debe existir

import sqlite3
from colorama import Fore, init

init()


# --- CLASE BASE --------------------------------------------------------------
class BaseStore:
    def __init__(self):
        try:
            self.conexion = conectarse()
        except Exception as e:
            raise ExceptionStore(*e.args, **e.kwargs)
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
                raise ExceptionStore(*e.args)
            finally:
                try:
                    self.conexion.close()
                except Exception as e:
                    raise ExceptionStore(*e.args)


# --- DAL ---------------------------------------------------------------------
def conectarse():
    return sqlite3.connect('BDD.sqlite')


class ExceptionStore(Exception):
    def __init__(self, mensaje, *errores):
        Exception.__init__(self, mensaje)
        self.errores = errores
        print(f"\n{Fore.RED}\t{errores[0]}{Fore.RESET}")


# --- MAPPER (CRUD) -----------------------------------------------------------
class UsuarioStore(BaseStore):
    def create(self, objeto):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'INSERT INTO Usuarios(Nombre, Apellido, Domicilio, Comentario) '
                              f'VALUES("{objeto.nombre}", "{objeto.apellido}", "{objeto.domicilio}", "{objeto.comentario}")')
            print(f"ID > {indicador.lastrowid}")
        except Exception as e:
            raise ExceptionStore("ERROR AL CREAR AL USUARIO", *e.args)

    def read(self, usuario_id):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'SELECT * FROM Usuarios WHERE UsuarioID = {usuario_id}')
            return indicador.fetchone()
        except Exception as e:
            raise ExceptionStore("ERROR AL LEER AL USUARIO", *e.args)

    def update(self, objeto):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'UPDATE Usuarios SET Nombre = "{objeto.nombre}", Apellido = "{objeto.apellido}", '
                              f'Domicilio = "{objeto.domicilio}", Comentario = "{objeto.comentario}" '
                              f'WHERE UsuarioID = {objeto.usuario_id}')
        except Exception as e:
            raise ExceptionStore("ERROR AL ACTUALIZAR AL USUARIO", *e.args)

    def delete(self, usuario_id):
        try:
            indicador = self.conexion.cursor()
            indicador.execute(f'DELETE FROM Usuarios WHERE UsuarioID = {usuario_id}')
        except Exception as e:
            raise ExceptionStore("ERROR AL ELIMINAR AL USUARIO", *e.args)


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
    with UsuarioStore() as usuario_store:
        # Crear
        usuario = Usuario("Gerardo", "Tordoya", "Alte. Brown", "Prueba de ingreso")
        usuario_store.create(usuario)
        usuario_store.completo()
        print(f"{Fore.GREEN}USUARIO CREADO{Fore.RESET}")

        # Leer
        usuario = usuario_store.read(7)
        usuario_store.completo()
        print(usuario)
        print(f"{Fore.GREEN}USUARIO LEÍDO{Fore.RESET}")

        # Actualizar
        usuario = Usuario("Gerardo", "Tordoya", "Alte. Brown", "Prueba de actualización")
        usuario.usuario_id = 2
        usuario_store.update(usuario)
        usuario_store.completo()
        print(f"{Fore.GREEN}USUARIO ACTUALIZADO{Fore.RESET}")

        # Eliminar
        usuario_store.delete(3)
        usuario_store.completo()
        print(f"{Fore.GREEN}USUARIO ELIMINADO{Fore.RESET}")

except ExceptionStore as error:
    print(error)
