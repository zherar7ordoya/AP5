from DAL.acceso_datos import AccesoDatos
from EHL.handler_logger import CapturadorExcepciones


class VentaMapper(AccesoDatos):

    def __init__(self):
        super().__init__('DAT\\ventas.csv')

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
            self.escribir(listado)
        except Exception as e:
            raise CapturadorExcepciones("Error al crear la venta", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer()
            return listado[idx]
        except Exception as e:
            raise CapturadorExcepciones("Error al leer la venta", *e.args)

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
            raise CapturadorExcepciones("Error al actualizar la venta", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            listado = self.leer()
            del listado[idx]
            self.escribir(listado)
        except Exception as e:
            raise CapturadorExcepciones("Error al eliminar la venta", *e.args)

