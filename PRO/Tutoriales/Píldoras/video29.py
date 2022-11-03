# =====================================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-01
# Description: POO      => Herencia
#              Video 29 => https://youtu.be/u_VbLsIyzRk
# =====================================================

class Vehiculos:
    def __init__(self, marca, modelo):
        self.marca = marca
        self.modelo = modelo
        self.enmarcha = False
        self.acelera = False
        self.frena = False

    def arrancar(self):
        self.enmarcha = True

    def acelerar(self):
        self.acelera = True

    def frenar(self):
        self.frena = True

    def estado(self):
        print(f"Marca:     \t{self.marca}\n" 
              f"Modelo:    \t{self.modelo}\n"
              f"En marcha: \t{self.enmarcha}\n"
              f"Acelerando:\t{self.acelera}\n"
              f"Frenando:  \t{self.frena}")


class Moto(Vehiculos):
    pass


# --- MAIN --------------------------------------------------------------------
if __name__ == "__main__":
    miMoto = Moto("Honda", "CBR")
    miMoto.estado()
