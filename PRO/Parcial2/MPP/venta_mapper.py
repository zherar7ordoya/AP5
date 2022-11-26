from acceso_datos import AccesoDatos
from excepcion_capturada import RegistroSistematicoExcepciones


class VentaMapper(AccesoDatos):

    def __init__(self):
        super().__init__('ventas.csv')

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer()
            nuevo = [objeto.fecha,
                     objeto.codigo,
                     objeto.vendedor,
                     objeto.sucursal,
                     objeto.importe]
            listado.append(nuevo)
            self.escribir(self.archivo, listado)
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
    def update(self, objeto, cod):
        try:
            listado = self.leer()
            nuevo = [objeto.fecha,
                     objeto.codigo,
                     objeto.vendedor,
                     objeto.sucursal,
                     objeto.importe]
            listado[cod] = nuevo
            self.escribir(listado)
        except Exception as e:
            raise RegistroSistematicoExcepciones("ERROR AL ACTUALIZAR", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer()
            del listado[idx]
            self.escribir(listado)
        except Exception as e:
            raise RegistroSistematicoExcepciones("ERROR AL ELIMINAR", *e.args)

