# =====================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-25
# Description: Count reference || Video 19 https://youtu.be/by1MI4VReLg
#              (Conteo de Referencia)
# =====================================================================

import sys


class Clase:
    def __init__(self, x, y):
        self.x = x
        self.y = y


print("Creando Instancia 1")
objeto = Clase(2, 3)
print(sys.getrefcount(objeto))

otro = objeto
print(sys.getrefcount(objeto))

lista = [objeto]
print(sys.getrefcount(objeto))

aun_otro_objeto = Clase(4, 5)

print("\nPara finalizar:")
print(sys.getrefcount(objeto))
print(sys.getrefcount(aun_otro_objeto))
