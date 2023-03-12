# -*- coding: cp1252 -*-

'''
Escribir una función que reciba una frase y devuelva un diccionario con las
palabras que contiene y su longitud.
'''

import json

def string_a_diccionario(frase):
    palabras = frase.split()
    return {palabra: len(palabra) for palabra in palabras}

frase = 'Hola, soy un diccionario'
diccionario = string_a_diccionario(frase)
bonito = json.dumps(diccionario, indent=4)
print(bonito)