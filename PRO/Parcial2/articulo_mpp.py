import csv

from acceso_datos import AccesoDatos
from excepcion_capturada import ExceptionCapturada


class ArticuloMPP(AccesoDatos):

    def __init__(self):
        self.archivo = 'articulos.csv'

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.codigo,
                     objeto.descripcion,
                     objeto.stock]
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
            nuevo = [objeto.codigo,
                     objeto.descripcion,
                     objeto.stock]
            listado[idx] = nuevo
            self.escribir(self.archivo, listado)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer(self.archivo)

            # ELIMINACIÓN DE LOS REGISTROS ASOCIADOS EN EL ARCHIVO DE VENTAS
            # Esto tengo que explicarlo:
            # Supongamos que borro un artículo e inmediatamente después pido el
            # reporte de ventas (corte de control): se producirá una excepción
            # ya que ventas remite a un artículo que no existe.
            # Ventas es dependiente de Artículos y por eso se hace necesario un
            # borrado en cascada.
            #
            # Sí, pendiente. Yo había hecho salvedad cuando programé el corte de
            # control porque las circunstancias lo ameritaban. Me dí cuenta de
            # que estaba obligado al borrado en cascada luego, y esto ya
            # ameritaba que me base en el CRUD (porque ya estaba repitiendo
            # código "excepcional"). ¿Por qué no lo hice? Porque esto es un
            # examen y el tiempo se me estaba acabando (no iba a llegar a
            # probarlo, por ejemplo). Así que queda pendiente (aunque funciona).
            codigo = listado[idx][0]
            archivo = open("ventas.csv")
            ventas = csv.reader(archivo)
            reemplazo = []
            item = next(ventas, None)

            while item:
                if item[1] != codigo:
                    reemplazo.append(item)
                item = next(ventas, None)

            with open("ventas.csv", 'w', newline='\n') as dat:
                csv.writer(dat).writerows(reemplazo)

            archivo.close()

            # Ahora sí puedo borrar el artículo
            del listado[idx]
            self.escribir(self.archivo, listado)

        except Exception as e:
            raise ExceptionCapturada("ERROR AL ELIMINAR", *e.args)

