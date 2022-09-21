""" Herencia - 8 - Python Orientado a objetos """

__author__ = "Gerardo Tordoya"
__date__ = "2022-09-21"
__version__ = "Python 3.10.7"

import statistics as st

class Calificaciones:
    """ Clase que representa las calificaciones de un alumno """
    def __init__(self, lista):
        self._lista = lista

    def minimo(self):
        """ Devuelve el valor minimo """
        return min(self._lista)

    def maximo(self):
        """ Devuelve el valor maximo """
        return max(self._lista)

# Herencia
class Estadisticas(Calificaciones):
    """ Clase que representa las estadisticas de un alumno """
    def promedio(self):
        """ Devuelve el promedio """
        return st.mean(self._lista)

    def mediana(self):
        """ Devuelve la mediana """
        return st.median(self._lista)

    def moda(self):
        """ Devuelve la moda """
        return st.mode(self._lista)

calif = [8, 10, 9, 8, 8,7,8,9,10,5,5,6,6,9,9,9,9]

MisCalifs = Calificaciones(calif)
print(MisCalifs.minimo())
print(MisCalifs.maximo())

MisEst = Estadisticas(calif)
print(MisEst.promedio())
print(MisEst.mediana())
print(MisEst.moda())
