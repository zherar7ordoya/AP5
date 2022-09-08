# Comentario corto

"""
Comentario largo
"""

import math

class Vector:
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def muestra(self):
        print(self.x, self.y)

    def magnitud(self):
        return math.sqrt(self.x**2 + self.y**2)

v1 = Vector(4, 5)
v1.muestra()

m = v1.magnitud()
print(m)