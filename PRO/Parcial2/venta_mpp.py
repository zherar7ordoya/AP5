from acceso_datos import AccesoDatos
from excepcion_capturada import ExceptionCapturada


class VentaMPP(AccesoDatos):

    def __init__(self, archivo):
        super().__init__(archivo)
        self.archivo = 'ventas.csv'

    # *** ALTAS ***
    def create(self, objeto):
        try:
            listado = self.leer(self.archivo)
            nuevo = [objeto.fecha,
                     objeto.codigo,
                     objeto.vendedor,
                     objeto.sucursal,
                     objeto.importe]
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
            nuevo = [objeto.fecha,
                     objeto.codigo,
                     objeto.vendedor,
                     objeto.sucursal,
                     objeto.importe]
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

