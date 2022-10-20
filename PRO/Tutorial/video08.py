"""
@title: Herencia (Video 8) Python Orientado a objetos
@author: Gerardo Tordoya
@date: 2022-09-21
"""

import statistics as st


class Calificaciones:
    def __init__(self, lista):
        self._lista = lista

    def minimo(self):
        return min(self._lista)

    def maximo(self):
        return max(self._lista)


# Herencia
class Estadisticas(Calificaciones):
    def promedio(self):
        return st.mean(self._lista)

    def mediana(self):
        return st.median(self._lista)

    def moda(self):
        return st.mode(self._lista)


# if __name__ == '__main__':
#     calificaciones = Estadisticas([1, 2, 3, 4, 5, 6, 7, 8, 9, 10])
#     print(calificaciones.minimo())
#     print(calificaciones.maximo())
#     print(calificaciones.promedio())
#     print(calificaciones.mediana())
#     print(calificaciones.moda())

notas = [8, 10, 9, 8, 8, 7, 8, 9, 10, 5, 5, 6, 6, 9, 9, 9, 9]

mis_calificaciones = Calificaciones(notas)
print(mis_calificaciones.minimo())
print(mis_calificaciones.maximo())

mis_estadisticas = Estadisticas(notas)
print(mis_estadisticas.promedio())
print(mis_estadisticas.mediana())
print(mis_estadisticas.moda())
