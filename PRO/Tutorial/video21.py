# ================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-25
# Description: Uso de del || Video 21 https://youtu.be/fJzjDVIqFCA
# ================================================================

import sys


class Clase:
    def __init__(self, x, y, nombre):
        self.x = x
        self.y = y
        self.nombre = nombre

    def __del__(self):
        print("Se está eliminando el objeto...")
        print(f"Código de cierre para {self.nombre}: cerrar archivos, conexiones, etc.")
        print("Se ha eliminado el objeto")


objeto1 = Clase(1, 2, "objeto1")
objeto2 = objeto1

print(sys.getrefcount(objeto1))

objeto2 = None
objeto1 = None
