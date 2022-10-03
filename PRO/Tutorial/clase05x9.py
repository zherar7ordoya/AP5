""" Get y Set - 7 - Python Orientado a objetos """

__author__ = "Gerardo Tordoya"
__date__ = "2022-09-21"
__version__ = "Python 3.10.7"

class Producto():
    """ Clase que representa un producto """
    def __init__(self, costo):
        self._costo = costo
        self._precio_venta = self._calcula_venta()

    def _calcula_venta(self):
        """ Calcula el precio de venta """
        return self._costo * 1.30

    def set_impuesto(self, impuesto):
        """ Establece el impuesto """
        self.__impuesto = impuesto

    def get_precio_venta(self):
        """ Regresa el precio de venta """
        return self._precio_venta

    def set_costo(self, valor):
        """ Establece el costo """
        if valor > 0:
            self._costo = valor
            self._precio_venta = self._calcula_venta()
        else:
            print("El costo debe ser mayor a 0")
            self._costo = 0

    def get_costo(self):
        """ Regresa el costo """
        return self._costo

    def __repr__(self):
        return f"Costo: {self._costo}, Precio de venta: {self._precio_venta}"

manzana = Producto(10)
print(manzana)
pv = manzana.get_precio_venta()
print("El impuesto es", pv * 0.16)
manzana.set_costo(20)
print(manzana)
