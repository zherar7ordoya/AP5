"""
                        [DESCRIPCIÓN DE ESTE MÓDULO]
Video 7 - Herencia múltiple
"""
__author__ = "Gerardo Tordoya"
__date__ = "2022-09-15"

################################################################################

class Producto():
    """clase producto"""
    def __init__(self, nombre, precio):
        self.nombre = nombre
        self.precio = precio

    def __str__(self):
        return f"Producto: {self.nombre} Precio: {self.precio}"

class Fruta(Producto):
    """clase fruta"""
    def __init__(self, nombre, precio, color):
        super().__init__(nombre, precio)
        self.color = color

    def __str__(self):
        return f"Producto: {self.nombre} Precio: {self.precio} Color: {self.color}"
