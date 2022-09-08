"""Clase 3: Funciones y módulos"""

import math

class Vector:
    """__add__ es el método que se ejecuta cuando se usa el operador +"""
    def __init__(self, xth = 5, yth = 5):
        self.xth = xth
        self.yth = yth

    def muestra(self):
        """Muestra el vector"""
        print(self.xth, self.yth)

    def magnitud(self):
        """Calcula la magnitud del vector"""
        return math.sqrt(self.xth**2 + self.yth**2)

v1 = Vector(10, 8)
v1.muestra()
m = v1.magnitud()
print(m)

print('-------------')

v2 = Vector()
v2.muestra()
m2 = v2.magnitud()
print(m2)
