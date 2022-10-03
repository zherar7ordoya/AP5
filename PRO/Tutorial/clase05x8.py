#!/usr/bin/env python

"""
NICOSIO || Video Acceso a datos - 6 - Python Orientado a objetos.

@date:      Created on 2021-09-21
@date:      Last modification on 2021-09-21
@version:   1.0
@author:    Gerardo Tordoya
"""

__author__  = "Gerardo Tordoya"
__date__    = "2022-09-21"
__version__ = "Python 3.10.7"

# --------------------------->= [PROCEDIMIENTOS] <=--------------------------- #

class Producto():
    """
    Por convención, los atributos que empiezan con _ son privados.
    Por convención, los atributos que empiezan con __ son "inaccesibles".
    """
    def __init__(self):
        self.cantidad = 10
        self._costo = 5
        self.__impuesto = 0.16

manzana = Producto()
print("Cantidad de manzanas:", manzana.cantidad)
print("Costo de manzanas:",manzana._costo)
manzana._costo = 56
print("Nuevo costo de manzanas:", manzana._costo)
# print(manzana.cantidad, manzana._costo, manzana.__impuesto)
print(manzana.cantidad, manzana._costo)
dir(manzana)
print(manzana._Producto__impuesto)
