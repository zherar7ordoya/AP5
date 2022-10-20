""" Get y Set - 7 - Python Orientado a objetos """


class Producto:
    def __init__(self, costo):
        self._costo = costo
        self._precio_venta = self._calcula_venta()

    def _calcula_venta(self):
        return self._costo * 1.30

    def set_impuesto(self, impuesto):
        self.__impuesto = impuesto

    def get_precio_venta(self):
        return self._precio_venta

    def set_costo(self, valor):
        if valor > 0:
            self._costo = valor
            self._precio_venta = self._calcula_venta()
        else:
            print("El costo debe ser mayor a 0")
            self._costo = 0

    def get_costo(self):
        return self._costo

    def __repr__(self):
        return f"Costo: {self._costo}, Precio de venta: {self._precio_venta}"


manzana = Producto(10)
print(manzana)
pv = manzana.get_precio_venta()
print("El impuesto es", pv * 0.16)
manzana.set_costo(20)
print(manzana)
