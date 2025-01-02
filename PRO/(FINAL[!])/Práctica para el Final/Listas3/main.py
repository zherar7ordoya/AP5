# -*- coding: cp1252 -*-

'''
Escribir un programa que almacene las asignaturas de un curso (por ejemplo
Matemáticas, Física, Química, Historia y Lengua) en una lista, pregunte al
usuario la nota que ha sacado en cada asignatura, y después las muestre por
pantalla con el mensaje En <asignatura> has sacado <nota> donde <asignatura> es
cada una des las asignaturas de la lista y <nota> cada una de las
correspondientes notas introducidas por el usuario.
'''


materias = ["Matemáticas", "Física", "Química", "Historia", "Lengua"]
notas = []

for materia in materias:
    nota = input(f"¿Qué nota has sacado en {materia}? ")
    notas.append(nota)

for i in range(len(materias)):
    print(f"En {materias[i]} has sacado\t{notas[i]}")
