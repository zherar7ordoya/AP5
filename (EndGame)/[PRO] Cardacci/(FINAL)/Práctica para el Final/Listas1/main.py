materias = ["Matematicas", "Fisica", "Quimica", "Historia", "Lengua"]
notas = []

for materia in materias:
    nota = input(f"Que nota has sacado en {materia}?")
    notas.append(nota)

for i in range(len(materias)):
    print(f"En {materias[i]} has sacado {notas[i]}")
