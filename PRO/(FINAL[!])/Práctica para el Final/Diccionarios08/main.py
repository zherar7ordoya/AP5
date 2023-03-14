# -*- coding: cp1252 -*-

'''
Escribir un programa que cree un diccionario de traducción español-inglés. El
usuario introducirá las palabras en español e inglés separadas por dos puntos,
y cada par <palabra>:<traducción> separados por comas. El programa debe crear
un diccionario con las palabras y sus traducciones. Después pedirá una frase en
español y utilizará el diccionario para traducirla palabra a palabra. Si una
palabra no está en el diccionario debe dejarla sin traducir.
'''

diccionario = {}

print("Escriba la lista de palabras y sus traducciones en este formato:")
print("palabra:traducción,palabra:traducción,palabra:traducción")
print("Ejemplo => Yo:I,soy:am")

print()

palabras = input("Escriba => ")
print(f"'palabras' => {type(palabras)}")

for palabra in palabras.split(","):
    clave, valor = palabra.split(":")
    diccionario[clave] = valor

print("Diccionario =>", diccionario)
print()

frase = input("Escriba una frase en español => ")
print("                  Traducción =>", end=" ")

for palabra in frase.split():
    if palabra in diccionario:
        print(diccionario[palabra], end=" ")
    else:
        print(palabra, end=" ")

print("\n")
