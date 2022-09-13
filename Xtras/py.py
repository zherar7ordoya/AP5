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

class Vector:
    """Crea el vector"""
    def __init__(self, param1 = "Hello ", param2 = "World!"):
        self.xth = param1
        self.yth = param2

    def muestra(self):
        """Muestra el vector"""
        print(self.xth, self.yth)       # Se refiere a los atributos de la clase
        print("Presentación concluida...")   # Se refiere a un string

    def __str__(self):
        return self.xth + self.yth

vector = Vector()
vector.muestra()
