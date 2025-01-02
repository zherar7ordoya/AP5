# ================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-31
# Description: POO => Encapsulamiento de atributos
#              Video 27
#              https://youtu.be/x5CY8fVyYLo
# ================================================


class Coche:

    def __init__(self):
        self.__largo = 250
        self.__ancho = 120
        self.__ruedas = 4
        self.__marcha = False

    def arrancar(self, arrancamos):
        self.__marcha = arrancamos

        if self.__marcha:
            return "El coche está en marcha"
        else:
            return "El coche está parado"

    def estado(self):
        return f"{self.__ruedas} ruedas || " \
               f"{self.__ancho} de ancho  || " \
               f"{self.__largo} de largo"


# --- MAIN --------------------------------------------------------------------

coche = Coche()
print(coche.arrancar(True))

# Este ejemplo muestra el encapsulamiento del atributo "ruedas"
print(f"Estado del coche: {coche.estado()}")
coche.ruedas = 2
print(f"Estado del coche: {coche.estado()}")
