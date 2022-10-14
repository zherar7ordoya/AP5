"""
  @title        CLASE 01
  @description  Material otorgado para la clase 01 de la materia
  @author       Gerardo Tordoya
  @date         2022-09-12
  @source       UAI - Ingeniería en Computación
"""

# --- RUN FORREST, RUN ---------------------------------------------------------

import array
from os import system

TEXTO = str("Gerardo Tordoya ")
system("cls")

print("Imprime el texto: ", TEXTO)
print("Suma el texto: ", TEXTO + TEXTO)
print("Multiplica el texto: ", TEXTO * 3)
print("Imprime el primer caracter: ", TEXTO[0])
print("Imprime una rebanada del texto: ", TEXTO[8:15])
print("Imprime una rebanada usando index negativo: ", TEXTO[-16:-9])
print("Imprime el largo del texto: ", len(TEXTO))
print(
    "Imprime el texto sin espacios: ",
    TEXTO.strip(),
    "...quedando largo en ",
    len(TEXTO.strip()),
)
print("Imprime el texto en minúscula: ", TEXTO.lower())
print("Imprime el texto en mayúscula: ", TEXTO.upper())
print("Reemplaza una letra por otra: ", TEXTO.replace("o", "e"))
print("Divide el texto en palabras: ", TEXTO.split(" "))
X = "Tordoya" in TEXTO
print("Comprueba si existe una palabra en el texto: ", X)
EDAD = 43
texto = f"Mi nombre es {TEXTO}y tengo {EDAD} años"
print(texto)
texto = "Los así llamados \"programadores\" son los mejores"
print(texto)
texto = "capitalización"
print(texto.capitalize())
texto = " Visüal Stüdio Códe "
print(texto.center(50, "*"))
print(texto.casefold())
print("Centra el texto en 50 caracteres:\n", texto.center(50))
print("Cuenta la cantidad de veces que aparece la 'o': ", texto.count("o"))
print("Imprime una versión codificada del texto: ", texto.encode())
texto = "G\tT"
print("Imprime una versión con tabuladores:")
print(texto.expandtabs(2))
print(texto.expandtabs(3))
print(texto.expandtabs(4))
print(texto.expandtabs(5))

# Ejemplo a tener en cuenta (p37 del apunte)
txt = "Hello, welcome to my world."
x = txt.index("e", 5, 15)
print(x)

# Otro ejemplo a tener en cuenta (p45)
txt = "Mi nombre es\nGerardo Tordoya"
print("Verifica si todos los caracteres son imprimibles:", txt.isprintable())

# Otro ejemplo a tener en cuenta (p79)
a = 8
b = "Hola"
c = 3.14

print(f"El valor de a es {a}, el de b es {b} y el de c es {c}")

# --- LISTAS & ARRAYS ---------------------------------------------------------

# creating an array containing same data type elements 
mi_array = array.array('i', [1, 2, 3])

# accessing elements of array
for x in mi_array:
    print(f"x: {x}")

# ─── 5 MÉTODOS PARA UNIR LISTAS ───────────────────────────────────────────────

# 1. Usando el operador +
lista1 = [1, 2, 3]
lista2 = [4, 5, 6]
lista3 = lista1 + lista2
print(lista3)

# 2. Usando el método extend()
lista1 = [1, 2, 3]
lista2 = [4, 5, 6]
lista1.extend(lista2)
print(lista1)

# 3. Usando el método append()
lista1 = [1, 2, 3]
lista2 = [4, 5, 6]
lista1.append(lista2)  # type: ignore
print(lista1)

# 4. Usando el método insert()
lista1 = [1, 2, 3]
lista2 = [4, 5, 6]
lista1.insert(3, lista2)  # type: ignore
print(lista1)

# 5. Agregando todos los elementos, uno por uno
lista1 = [1, 2, 3]
lista2 = [4, 5, 6]
for x in lista2:
    lista1.append(x)
print(lista1)
