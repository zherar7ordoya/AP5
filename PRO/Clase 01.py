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
TXT = f"Mi nombre es {TEXTO} y tengo {EDAD} años"
print(TXT)
TXT = "Los así llamados \"programadores\" son los mejores"
print(TXT)
TXT = "capitalización"
print(TXT.capitalize())
TXT = " Visüal Stüdio Códe "
print(TXT.center(50, "*"))
print(TXT.casefold())
print("Centra el texto en 50 caracteres:\n", TXT.center(50))
print("Cuenta la cantidad de veces que aparece la 'o': ", TXT.count("o"))
print("Imprime una versión codificada del texto: ", TXT.encode())
TXT = "G\tT"
print("Imprime una versión con tabuladores:")
print(TXT.expandtabs(2))
print(TXT.expandtabs(3))
print(TXT.expandtabs(4))
print(TXT.expandtabs(5))

# Ejemplo a tener en cuenta (p37 del apunte)
CADENA = "Hello, welcome to my world."
XTH = CADENA.index("e", 5, 15)
print(XTH)

# Otro ejemplo a tener en cuenta (p45)
CADENA = "Mi nombre es\nGerardo Tordoya"
print("Verifica si todos los caracteres son imprimibles:", CADENA.isprintable())

# Otro ejemplo a tener en cuenta (p79)
ATH = 8
BTH = "Hola"
CTH = 3.14

print(f"El valor de a es {ATH}, el de b es {BTH} y el de c es {CTH}")

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
