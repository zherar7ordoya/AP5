from DAL.acceso_datos import AccesoDatos
from MPP.venta_mapper import VentaMapper
from EHL.handler_logger import CapturadorExcepciones


class ArticuloMapper(AccesoDatos):

    def __init__(self):
        super().__init__('DAT\\articulos.csv')
        self.ventas_mpp = VentaMapper()

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
            raise CapturadorExcepciones("Error de creación de artículo", *e.args)

    # *** CONSULTAS ***
    def read(self, idx):
        try:
            listado = self.leer()
            return listado[idx]
        except Exception as e:
            raise CapturadorExcepciones("Error de lectura de artículo", *e.args)

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
            raise CapturadorExcepciones("Error de actualización de artículo", *e.args)

    # *** BAJAS ***
    def delete(self, idx):
        try:
            lista_articulos = self.leer()

            # Borro las ventas asociadas al artículo
            codigo = lista_articulos[idx][0]
            lista_ventas = iter(self.ventas_mpp.leer())
            reemplazo = []
            item = next(lista_ventas, None)

            while item:
                if item[1] != codigo:
                    reemplazo.append(item)
                item = next(lista_ventas, None)

            self.ventas_mpp.escribir(reemplazo)

            # Ahora sí puedo borrar el artículo
            del lista_articulos[idx]
            self.escribir(lista_articulos)

        except Exception as e:
            raise CapturadorExcepciones("Error de eliminación de artículo", *e.args)
