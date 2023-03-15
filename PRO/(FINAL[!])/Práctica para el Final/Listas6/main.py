# -*- coding: cp1252 -*-

"""
Escribir un programa que almacene las asignaturas de un curso (por ejemplo,
Matem�ticas, F�sica, Qu�mica, Historia y Lengua) en una lista, pregunte al
usuario la nota que ha sacado en cada asignatura y elimine de la lista las
asignaturas aprobadas. Al final el programa debe mostrar por pantalla las
asignaturas que el usuario tiene que repetir.
"""

materias = ["Matem�ticas", "F�sica", "Qu�mica", "Historia", "Lengua"]
notas = []

for materia in materias:
    nota = input(f"�Qu� nota has sacado en {materia}? ")
    notas.append(nota)

for i in range(len(materias) - 1, -1, -1):
    if int(notas[i]) >= 7:
        materias.pop(i)
        notas.pop(i)

print("Tienes que repetir las siguientes asignaturas:")

for i in range(len(materias)):
    print(f"{materias[i]}")
