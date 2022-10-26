"""
@title:   COMPOSICIÓN (video 14)
@video:   https://youtu.be/UCeLEKjGDz4
@author:  Gerardo Tordoya
@date:    2022-10-21
@remarks: La composición es parecida a la agregación, pero la diferencia es que
          las instancias de las clases que se componen no pueden existir por
          separado. Es decir, si se destruye la clase contenedora, también se
          destruyen las instancias de las clases contenidas.
          Ejemplo: Una clase que representa un vehículo, y que contiene una
          instancia de la clase Motor, y otra de la clase Rueda. Si se destruye
          el vehículo, también se destruyen el motor y las ruedas.
"""

from colorama import Fore


# CLASE CONTENIDA
class Motor:
    def __init__(self, cilindros, hp):
        self.cilindros = cilindros
        self.hp = hp

    def __str__(self):
        return f"Motor de {self.cilindros} cilindros y {self.hp} HP"

    def trabaja(self):
        for i in range(self.hp):
            print(i, end=", ")
        print()


# CLASE CONTENEDORA
class Auto:
    def __init__(self, modelo, precio):
        self.modelo = modelo
        self.precio = precio
        # Aquí está la composición: creamos una instancia de la clase Motor
        # dentro de la clase Auto de tal manera que, si se destruye el Auto,
        # también se destruye el Motor.
        # Es decir, a motor no lo estoy "agregando" (pasando como parámetro)
        # sino que lo estoy usando de compomente (estoy "componiendo") para
        # armar un auto.
        self.motor = Motor(4, 10)

    def __str__(self):
        return f"Auto modelo {self.modelo} con motor {self.motor}: {Fore.YELLOW}$ {self.precio}{Fore.RESET}"

    def encender(self):
        print("Arrancando...")
        self.motor.trabaja()


if __name__ == "__main__":
    auto = Auto("Ford", 10000)
    print(auto)
    auto.encender()
