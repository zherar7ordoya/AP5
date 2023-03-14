# =======================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-25
# Description: Count reference 2 || Video 20 https://youtu.be/SkRlewpgEQ4
#              Hacer que disminuya el contador de referencias
# =======================================================================

import sys


def imprimir_referencias(objeto):
    print("--- En la función ---")
    print(sys.getrefcount(objeto))
    print(objeto.__dict__)
    print("--- Fin de la función ---")


class Clase:
    def __init__(self, x, y):
        self.x = x
        self.y = y


objeto1 = Clase(1, 2)
objeto2 = objeto1
objeto3 = objeto1
objeto4 = objeto1
lista1 = [objeto1]
lista2 = [objeto1]
print(sys.getrefcount(objeto1))

print("\nEmpieza a decrecer...")
objeto2 = 5
print(sys.getrefcount(objeto1))

lista1.pop()
print(sys.getrefcount(objeto1))

del lista2
print(sys.getrefcount(objeto1))

del objeto3
print(sys.getrefcount(objeto1))

objeto4 = None
print(sys.getrefcount(objeto1))
