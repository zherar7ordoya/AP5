import csv

from acceso_datos import AccesoDatos
from excepcion_capturada import RegistroSistematicoExcepciones


class ArticuloMapper(AccesoDatos):

    def __init__(self):
        super().__init__('articulos.csv')

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer()
            nuevo = [objeto.codigo,
                     objeto.descripcion,
                     objeto.stock]
            listado.append(nuevo)
            self.escribir(listado)
        except Exception as e:
            raise RegistroSistematicoExcepciones("ERROR AL CREAR", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer()
            return listado[idx]
        except Exception as e:
            raise RegistroSistematicoExcepciones("ERROR AL LEER", *e.args)

    # *** MODIFICACIONES ***
    def update(self, objeto, idx):
        try:
            listado = self.leer()
            nuevo = [objeto.codigo,
                     objeto.descripcion,
                     objeto.stock]
            listado[idx] = nuevo
            self.escribir(listado)
        except Exception as e:
            raise RegistroSistematicoExcepciones("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer()

            # TODO - Usar CRUD (!)
            codigo = listado[idx][0]
            archivo = open("../ventas.csv")
            ventas = csv.reader(archivo)
            reemplazo = []
            item = next(ventas, None)

            while item:
                if item[1] != codigo:
                    reemplazo.append(item)
                item = next(ventas, None)

            with open("../ventas.csv", 'w', newline='\n') as dat:
                csv.writer(dat).writerows(reemplazo)

            archivo.close()

            # Ahora sí puedo borrar el artículo
            del listado[idx]
            self.escribir(listado)

        except Exception as e:
            raise RegistroSistematicoExcepciones("ERROR AL ELIMINAR", *e.args)

