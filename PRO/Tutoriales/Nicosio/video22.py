# ===================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-25
# Description: Descriptor || Video 22 || https://youtu.be/I8U1Ohb7bQE
# ===================================================================

# Los descriptores nos permiten hacer una validación de los tipos y valores que
# asignamos a un atributo de una clase.

class CostoValidador:
    def __init__(self):
        self.__costo = 0

    def __get__(self, instance, owner):
        print("Estoy en el descriptor")
        return self.__costo

    def __set__(self, instance, value):
        if not isinstance(value, int):
            raise ValueError("El costo debe ser un entero")
        if value < 0:
            raise ValueError("El costo no puede ser negativo")
        self.__costo = value


class Auto:
    costo = CostoValidador()

    def __init__(self, modelo, costo):
        self.modelo = modelo
        self.costo = costo

    def __repr__(self):
        return f"Auto(modelo={self.modelo}, costo={self.costo})"


try:
    mi_auto = Auto(2018, "Mucho dinero")
except ValueError as e:
    print(e)
else:
    print(mi_auto)

try:
    mi_auto = Auto(2018, -100)
except ValueError as e:
    print(e)
else:
    print(mi_auto)


try:
    mi_auto = Auto(2018, 100)
except ValueError as e:
    print(e)
else:
    print(mi_auto)
