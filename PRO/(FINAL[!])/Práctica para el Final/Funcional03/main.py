# -*- coding: cp1252 -*-

'''
Escribir una función que reciba otra función y una lista, y devuelva otra lista
con el resultado de aplicar la función dada a cada uno de los elementos de la
lista.
'''

duplicador = lambda x: x * 2
numeros = [1, 2, 3, 4, 5]

def recibidor(funcion, lista):
    return [funcion(x) for x in lista]

duplicados = recibidor(duplicador, numeros)
print(duplicados)