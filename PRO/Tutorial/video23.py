# =============================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-25
# Description: Serialización Pickle || Video 23 || https://youtu.be/B6Vs7gw2VHQ
# =============================================================================

# Los descriptores nos permiten hacer una validación de los tipos y valores que
# asignamos a un atributo de una clase.

import pickle


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

# Serialización Pickle
# Es una forma de serializar objetos de Python para poder almacenarlos en un
# archivo y recuperarlos posteriormente.

print("\nCreamos un archivo para almacenar los objetos")
auto_output = open("video23.pkl", "wb")
pickle.dump(mi_auto, auto_output)
auto_output.close()

print("\nLeemos el archivo")
auto_input = open("video23.pkl", "rb")
mi_auto = pickle.load(auto_input)
auto_input.close()
print(mi_auto)
