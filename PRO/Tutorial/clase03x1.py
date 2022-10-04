#!/usr/bin/env python

""" CLASE 03
NOTAS:
    - When checking names, Pylint differentiates between constants, variables,
      classes etc. Any name that is not inside a function/class will be
      considered a constant, anything else is a variable.
"""

__author__  = "Gerardo Tordoya"
__date__    = "2022-XX-XX"
__version__ = "Python 3.10.7"


# Herramientas
# ************
import os
import colorama
from colorama import Fore
colorama.init(autoreset = True)

def print_center(texto):
    """ Método genérico de consola para imprimir texto centrado. """
    print(
        Fore.GREEN +
        ' ' * ((os.get_terminal_size().columns - len(texto))//2) +
        texto
        )

# --------------------------->= [PROCEDIMIENTOS] <=--------------------------- #

os.system('CLS')

word = input("Introduce una palabra: ")
vocals = ['a', 'e', 'i', 'o', 'u']

for vocal in vocals:
    CONTADOR = 0                       # Ver notas al principio de este archivo.
    for letter in word:
        if letter == vocal:
            CONTADOR += 1
    print_center("La vocal " + vocal + " aparece " + str(CONTADOR) + " veces")

input()

materias = ["Matemáticas", "Física", "Química", "Historia", "Lengua"]
notas = []

for materia in materias:
    nota = input("¿Qué nota has sacado en " + materia + "? ")
    notas.append(nota)

#for i in range(len(materias)):
#    print("En " + materias[i] + " has sacado " + notas[i])

# Pylint: R1710: (consider-using-enumerate), consider-using-enumerate
#for i, materia in enumerate(materias):
#    print("En " + materia + " has sacado " + notas[i])

# GitHub Copilot (mejor que Pylint)
for materia, nota in zip(materias, notas):
    print("En " + materia + " has sacado " + nota)

input()
