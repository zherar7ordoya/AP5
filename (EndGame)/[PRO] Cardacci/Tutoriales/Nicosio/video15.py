"""
@title:   CLASE ABSTRACTA (video 15)
@video:   https://youtu.be/41EFoLcCQUs
@author:  Gerardo Tordoya
@date:    2022-10-22
"""

from abc import ABC, abstractmethod


# CLASE ABSTRACTA
class Figura(ABC):

    @abstractmethod
    def area(self):
        pass

    @abstractmethod
    def perimetro(self):
        pass


class Cuadrado(Figura):
    def __init__(self, lado):
        self.lado = lado

    def area(self):
        return self.lado ** 2

    def perimetro(self):
        return self.lado * 4


class Circulo(Figura):
    def __init__(self, radio):
        self.radio = radio

    def area(self):
        return 3.1416 * self.radio ** 2

    def perimetro(self):
        return 2 * 3.1416 * self.radio


# ─── EJECUCIÓN ───────────────────────────────────────────────────────────────
print("Instanciar 'Figura' no es posible:")
try:
    figura = Figura()
except TypeError as e:
    print(e)

input()

print("Instanciar 'Cuadrado':")
cuadrado = Cuadrado(5)
print(f"Área: {cuadrado.area()}")
print(f"Perímetro: {cuadrado.perimetro()}")

input()

print("Instanciar 'Circulo':")
circulo = Circulo(5)
print(f"Área: {circulo.area()}")
print(f"Perímetro: {circulo.perimetro()}")
