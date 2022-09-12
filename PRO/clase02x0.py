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

import time
from ast import literal_eval

print ("Hola Mundo") # Comentario

A = 8
B = "Hello"
C = True

#Formateo de salida...
print("Concatenando " + str(A) + " " + B + " " + str(C)) # Obligatorio hacer cast a string
print("Concatenando", A, B, C)
# print("Concatenando %s %s %s" % (A, B, C))

MI_CADENA = "Concatenando {} {} {}"
print(MI_CADENA.format(A, B, C))

print(f"Concatenando {A} {B} {C} ") # Sugerida

M = 10
if M > 25:
    print("m es mayor que", 25)
elif M == 10:
    print("m vale 10")
else:
    print("m es menor que", 25)


# Solicitud de datos al usuario
#num = eval(input("Ingrese un número: "))
num = literal_eval(input("Ingrese un número: "))

while num != 0:
    if num > 10:
        print("Mayor que 10")
    else:
        print("Menor que 10")

    num = float(input("Enter a number: "))

CADENA = "Curso de python"

for n in CADENA:
    print(n)

l = [22, True, "una lista", [1, 2]]

print(l[0])
print(l[3][0])

l = [99, True, "una lista", [1, 2]]
mi_VARIABLE = l[0:2] # mi_VARIABLE vale [99, True]
mi_VARIABLE = l[0:85:2] # mi_VARIABLE vale [99, “una lista”]
print(mi_VARIABLE)


l = [99, True, "una lista"]
mi_VARIABLE = l[1:]  # mi_VARIABLE vale [True, “una lista”]

mi_VARIABLE = l[:2]  # mi_VARIABLE vale [99, True]
mi_VARIABLE = l[:]   # mi_VARIABLE vale [99, True, “una lista”]
mi_VARIABLE = l[::2] # mi_VARIABLE vale [99, “una lista”]

mi_VARIABLE.append("Elemento nuevo")
print(mi_VARIABLE)
print(mi_VARIABLE.count(99))

a = (2,3)               # Tupla
mi_VARIABLE.extend(a)   # Pasa como lista
print(mi_VARIABLE)
mi_VARIABLE.insert(4, True)
print(mi_VARIABLE)
mi_VARIABLE.pop(4)                   # Remueve por posición
print(mi_VARIABLE)
mi_VARIABLE.remove("Elemento nuevo") # Remueve objeto
print(mi_VARIABLE)
mi_VARIABLE.reverse()                # Invertir la lista
print(mi_VARIABLE)
orden = ['e', 'a', 'u', 'o', 'i']

"""reverse = True (para ordenar de mayor a menor)"""
orden.sort()
print(orden)


C = "hola mundo"
print(C[0])    # h
print(C[5:])   # mundo
print(C[::3])  # "hauo"

T = (1, 2, True, "python")

print(T[0])

d = {"Love Actually": "Richard Curtis",
     "Kill Bill": "Tarantino",
    "Amélie": "Jean-Pierre Jeunet"}

print(d)

print(d["Love Actually"])


VARIABLE = "par" if (num % 2 == 0) else "impar"
print(VARIABLE)

secuencia = ["uno", "dos", "tres"]
for elemento in secuencia:
    print (elemento)

for i in range(5,10):
    print(i)


def sumar(num1:int, num2:int) -> int:
    """Función que retorna la suma de dos enteros...
    num1: Sumando 1
    num2: Sumando 2
    retorno: Total de tipo entero """
    return num1 + num2


print("La suma calculada es: ", sumar(4,6))

while True:
    entrada = input("Ingrese un mensaje de esperanza...")
    if entrada == "adios":
        break
    else:
        print (entrada)

#Tuplas de un elemento llevan la coma al final
t = (1,)
print(type(t))


def tak(xth,yth,zth):
    """Takes three arguments and returns the second one"""
    if xth <= yth:
        return yth
    return tak(tak(xth-1,yth,zth),
                tak(yth-1,zth,xth),
                tak(zth-1,xth,yth))
#Probamos...

t_inicial = time.time()
tak(11,6,1)
t_final = time.time() - t_inicial
print(f"Tiempo {t_final} en segundos")

# TESTEAR
# tak(12,6,1)
# tak(13,6,1)
# tak(14,6,1)

diccionario = {"clave": "valor"}

"""materias = {}
materias["lunes"] = [6103, 7540]
materias["martes"] = [6201]
materias["miércoles"] = [6103, 7540]
materias["jueves"] = []
materias["viernes"] = [6201]"""

print(diccionario["clave"])
print(diccionario.get("clave", ["no encontrado"]))

#print(diccionario.has_key("clave")) # Reemplazada en python 3 por:
print('clave' in diccionario)

print(diccionario.items())
print(diccionario.keys())
print(diccionario.values())

print(diccionario.pop("clave")) # Muestro y lo quito
print(diccionario.items())
