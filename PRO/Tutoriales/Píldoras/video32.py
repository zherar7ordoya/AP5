# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-03
# Description: POO Video 31 > Polimorfismo
#              https://youtu.be/kV1cN_bqcSw
# =========================================

class Coche:
    def desplazamiento(self):
        print("Me desplazo utilizando 4 ruedas")


class Moto:
    def desplazamiento(self):
        print("Me desplazo utilizando 2 ruedas")


class Camion:
    def desplazamiento(self):
        print("Me desplazo utilizando 6 ruedas")


def desplazamiento_vehiculo(vehiculo):
    vehiculo.desplazamiento()


# --- MAIN --------------------------------------------------------------------

miVehiculo = Moto()
desplazamiento_vehiculo(miVehiculo)
