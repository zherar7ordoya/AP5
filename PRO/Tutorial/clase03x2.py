#!/usr/bin/env python

""" *------------------>= [DESCRIPCIÓN DE ESTE MÓDULO] <=----------------------*
This program is free software: you can redistribute it and/or modify it under
the terms of the GNU General Public License as published by the Free Software
Foundation, either version 3 of the License, or (at your option) any later
version.
"""
__author__ = "Gerardo Tordoya"
__date__ = "2022/09/12"

# *------------------------->= [Run Forest, run!] <=---------------------------*

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
