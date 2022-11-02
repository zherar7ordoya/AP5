# ====================================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-02
# Description: POO > super() & isinstance()
#              Video 31 > https://youtu.be/oe04X1B14YY
# ====================================================

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


class Furgoneta(Vehiculos):
    def __init__(self, marca, modelo):
        super().__init__(marca, modelo)
        self.cargado = None

    def carga(self, cargar):
        self.cargado = cargar
        if self.cargado:
            return "La furgoneta está cargada"
        else:
            return "La furgoneta no está cargada"


class Moto(Vehiculos):
    caballito = "No, para nada..."

    def wheelie(self):
        self.caballito = "Haciendo wheelie, ¡wiii!"

    def estado(self):
        print(f"Marca:     \t{self.marca}\n"
              f"Modelo:    \t{self.modelo}\n"
              f"En marcha: \t{self.enmarcha}\n"
              f"Acelerando:\t{self.acelera}\n"
              f"Frenando:  \t{self.frena}\n"
              f"Caballito: \t{self.caballito}")


class VElectricos:
    def __init__(self):
        self.cargando = None
        self.autonomia = 100

    def cargar_energia(self):
        self.cargando = True


class BicicletaElectrica(VElectricos, Vehiculos):
    def __init__(self, marca, modelo):
        super().__init__()
        self.marca = marca
        self.modelo = modelo


# --- MAIN --------------------------------------------------------------------
if __name__ == "__main__":
    # miMoto = Moto("Honda", "CBR")
    # miMoto.wheelie()
    # miMoto.estado()

    # miFurgoneta = Furgoneta("Renault", "Kangoo")
    # miFurgoneta.arrancar()
    # miFurgoneta.estado()
    # print(miFurgoneta.carga(True))

    miBici = BicicletaElectrica("Orbea", "H50")
    miBici.estado()
