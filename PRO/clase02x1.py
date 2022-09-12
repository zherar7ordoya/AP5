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

from ast import literal_eval

print("EJERCICIO 1")


def sumar(xth, yth):
    """Suma dos números."""
    return xth + yth

RES = sumar(2, 3)
print(RES)

print("===========")
print("EJERCICIO 2")


def sumar2lecturas():
    """Función que suma dos lecturas de teclado."""
    ath = literal_eval(input("1er número: "))
    bth = literal_eval(input("2do número: "))
    print("Total: ", ath + bth)

sumar2lecturas()

print("===========")
print("EJERCICIO 3")

def maximo(ath, bth):
    """Función que devuelve el máximo de dos números."""
    if ath > bth:
        return a
    elif ath < bth:
        return bth
    else:
        return "Son iguales"


respuesta = maximo(5, 5)
print(respuesta)

print("===========")
print("EJERCICIO 4")


def signo(ath):
    """Función que devuelve el signo de un número."""
    if ath > 0:
        return 1
    elif ath < 0:
        return -1
    else:
        return 0

RES = signo(5)
print(RES)

print("===========")
print("EJERCICIO 5")


def suma_impares(nth):
    """Función que suma los n primeros números impares."""
    acumulador = 0
    for xxx in range(nth * 2):
        if (xxx % 2) != 0:
            acumulador += xxx
    return acumulador


a = literal_eval(input("Cantidad nros: "))
respuesta = suma_impares(int(a))
print(respuesta)

print("===========")
print("EJERCICIO 6")

def mayor_exponente(va1, vn1):
    """Función que calcula el mayor exponente de n que divide a a."""
    k = 0
    while vn1 % a == 0:
        vn1 = vn1 / va1
        k += 1
    return k


RES = mayor_exponente(2, 40)
print(RES)

print("===========")
print("EJERCICIO 7")


def factorial(nth):
    """Función que calcula un factorial mediante recursividad."""
    resultado = 1
    for xxx in range(1, nth + 1):
        resultado *= xxx
    return resultado

respuesta = factorial(4)
print(respuesta)

print("===========")
print("EJERCICIO 8")


def suma(xth):
    """Función que suma los n primeros números."""
    rth = 0
    for xxx in xth:
        rth += xxx
    return rth

RES = suma([3, 2, 5])
print(RES)

print("===========")
print("EJERCICIO 9")

def fact(nth):
    """Función que calcula un factorial mediante recursividad.
    n: Cantidad de números
    retorno: El factorial calculado."""
    if nth == 0:
        return 1
    else:
        return nth * fact(nth - 1)

respuesta = fact(4)
print(respuesta)

print("===========")
print("ADICIONAL SOBRE FUNCIONES")


def varios(param1, param2, *otros):
    """Función que recibe varios parámetros."""
    for val in otros:
        print(param1)
        print(param2)
        print(val)

varios(1, 2, 25, 52, 252)

print("===========")

def varios_mas(param1, param2, **otros):
    """Función que recibe varios parámetros."""
    for i in otros.items():
        print(param1)
        print(param2)
        print(i)

varios_mas(1, 2, tercero = 3)
