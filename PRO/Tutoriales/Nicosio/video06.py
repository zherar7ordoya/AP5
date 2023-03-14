class Producto():
    """
    Por convención, los atributos que empiezan con _ son privados.
    Por convención, los atributos que empiezan con __ son "inaccesibles".
    """

    def __init__(self):
        self.cantidad = 10      # Atributo público
        self._costo = 5         # Atributo privado
        self.__impuesto = 0.16  # Atributo inaccesible


manzana = Producto()
print("Cantidad de manzanas:", manzana.cantidad)
print("Costo de manzanas:", manzana._costo)
manzana._costo = 56
print("Nuevo costo de manzanas:", manzana._costo)
print(manzana.cantidad, manzana._costo, manzana.__impuesto)
print(manzana.cantidad, manzana._costo)
dir(manzana)
print(manzana._Producto__impuesto)
