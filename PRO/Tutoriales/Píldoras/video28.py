# =====================================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-01
# Description: POO      => Encapsulamiento de métodos
#              Video 28 => https://youtu.be/OU-e2uhoGxE
# =====================================================


class Coche:

    def __init__(self):
        self.__aceite = None
        self.__gasolina = None
        self.__puertas = None
        self.__largo = 250
        self.__ancho = 120
        self.__ruedas = 4
        self.__marcha = False

    def arrancar(self, arrancamos):
        chequeo = False

        self.__marcha = arrancamos

        if self.__marcha:
            chequeo = self.__chequeo_interno()

        if self.__marcha and chequeo:
            return "El coche está en marcha"
        elif self.__marcha and chequeo is False:
            return "Algo ha ido mal en el chequeo. No podemos arrancar"
        else:
            return "El coche está parado"

    def estado(self):
        return f"{self.__ruedas} ruedas || " \
               f"{self.__ancho} de ancho  || " \
               f"{self.__largo} de largo"

    def __chequeo_interno(self):
        print("Realizando chequeo interno")
        self.__gasolina = "OK"
        self.__aceite = "OK"
        self.__puertas = "Cerradas"

        if self.__gasolina == "OK" and \
                self.__aceite == "OK" and \
                self.__puertas == "Cerradas":
            return True
        else:
            return False


# --- MAIN --------------------------------------------------------------------

coche = Coche()
print(coche.arrancar(True))

# Este ejemplo muestra el encapsulamiento del atributo "ruedas"
print(f"Estado del coche: {coche.estado()}")
coche.ruedas = 2
print(f"Estado del coche: {coche.estado()}")
