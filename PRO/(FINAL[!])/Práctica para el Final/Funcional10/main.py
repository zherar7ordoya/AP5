# -*- coding: cp1252 -*-

"""
Construir una funci�n que permita hacer b�squeda de inmuebles en funci�n de un
presupuesto dado. La funci�n recibir� como entrada la lista de inmuebles y un
precio, y devolver� otra lista con los inmuebles cuyo precio sea menor o igual
a que el dado. Los inmuebles de la lista que se devuelva deben incorporar un
nuevo par a cada diccionario con el precio del inmueble, donde el precio de un
inmueble se calcula con las siguiente f�rmula en funci�n de la zona:
Zona A:
precio = (metros * 1000 + habitaciones * 5000 + garaje * 15000) * (1-antiguedad/100)
Zona B:
precio = (metros * 1000 + habitaciones * 5000 + garaje * 15000) * (1-antiguedad/100) * 1.5
"""

from datetime import datetime
import pprint

# Incre�ble Python: True * 15000 = 15000, y False * 15000 = 0

inmuebles = [
    {"a�o": 2000, "metros": 100, "habitaciones": 3, "garaje": True, "zona": "A"},
    {"a�o": 2012, "metros": 60, "habitaciones": 2, "garaje": True, "zona": "B"},
    {"a�o": 1980, "metros": 120, "habitaciones": 4, "garaje": False, "zona": "A"},
    {"a�o": 2005, "metros": 75, "habitaciones": 3, "garaje": True, "zona": "B"},
    {"a�o": 2015, "metros": 90, "habitaciones": 2, "garaje": False, "zona": "A"},
]

def buscar_inmuebles(inmuebles, precio):
    lista = []
    a�o = datetime.now().year
    for inmueble in inmuebles:
        precio_inmueble = (inmueble["metros"] * 1000 + inmueble["habitaciones"] * 5000 + inmueble["garaje"] * 15000) * (1-(inmueble["a�o"]-a�o)/100)
        if inmueble["zona"] == "A":
            precio_inmueble = precio_inmueble
        else:
            precio_inmueble = precio_inmueble * 1.5
        if precio_inmueble <= precio:
            inmueble["precio"] = "$ {:,.0f}".format(precio_inmueble)
            lista.append(inmueble)
    return lista

bonito = buscar_inmuebles(inmuebles, 150000)
pprint.pprint(bonito)