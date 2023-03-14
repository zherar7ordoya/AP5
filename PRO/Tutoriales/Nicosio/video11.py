"""
@title: Herencia Múltiple (video 11)
@video: https://youtu.be/ja0vcn7B8B0
@author: Gerardo Tordoya
@date: 2022-09-15
"""


class Producto:
    def __init__(self, cantidad, costo):
        self.total = None
        self.cantidad = cantidad
        self.costo = costo

    def total(self):
        self.total = self.cantidad * self.costo
        print(f"El total es: {self.total}")


class Fruta:
    def __init__(self, nombre, origen):
        self.nombre = nombre
        self.origen = origen

    def mostrar(self):
        print(f"La fruta es: {self.nombre}")
        print(f"Origen: {self.origen}")


class Articulo(Producto, Fruta):
    def __init__(self, cantidad, costo, nombre, origen):
        Producto.__init__(self, cantidad, costo)
        Fruta.__init__(self, nombre, origen)

    def mostrar(self):
        Producto.total(self)
        Fruta.mostrar(self)


manzana = Articulo(10, 100, "Manzana", "Argentina")
manzana.mostrar()
