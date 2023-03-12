# -*- coding: cp1252 -*-

'''
Escribir un programa que cree un diccionario de traducci�n espa�ol-ingl�s. El
usuario introducir� las palabras en espa�ol e ingl�s separadas por dos puntos,
y cada par <palabra>:<traducci�n> separados por comas. El programa debe crear
un diccionario con las palabras y sus traducciones. Despu�s pedir� una frase en
espa�ol y utilizar� el diccionario para traducirla palabra a palabra. Si una
palabra no est� en el diccionario debe dejarla sin traducir.
'''

diccionario = {}

print("Escriba la lista de palabras y sus traducciones en este formato:")
print("palabra:traducci�n,palabra:traducci�n,palabra:traducci�n")
print("Ejemplo => Yo:I,soy:am")

print()

palabras = input("Escriba => ")
print(f"'palabras' => {type(palabras)}")

for palabra in palabras.split(","):
    clave, valor = palabra.split(":")
    diccionario[clave] = valor

print("Diccionario =>", diccionario)
print()

frase = input("Escriba una frase en espa�ol => ")
print("                  Traducci�n =>", end=" ")

for palabra in frase.split():
    if palabra in diccionario:
        print(diccionario[palabra], end=" ")
    else:
        print(palabra, end=" ")

print("\n")
