# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-28
# Description: Excepciones
#              Video 21
#              https://youtu.be/2MaAs7XU2T0
# =========================================

def suma(num1, num2):
    return num1 + num2


def resta(num1, num2):
    return num1 - num2


def multiplica(num1, num2):
    return num1 * num2


def divide(num1, num2):
    try:
        respuesta = num1 / num2
    except ZeroDivisionError as exception:
        print("Se ejecuta cuando hay excepción.")
        return exception
    else:
        print("Se ejecuta cuando no hay excepciones.")
        return respuesta
    finally:
        print("Se ejecuta siempre.")


while True:
    try:
        op1 = (int(input("Introduce el primer número: ")))
        op2 = (int(input("Introduce el segundo número: ")))
        break
    except ValueError:
        print("Los valores introducidos no son correctos. Inténtalo de nuevo")

operacion = input("Introduce la operación a realizar (suma, resta, multiplica, divide): ")

if operacion == "suma":
    print(suma(op1, op2))
elif operacion == "resta":
    print(resta(op1, op2))
elif operacion == "multiplica":
    print(multiplica(op1, op2))
elif operacion == "divide":
    print(divide(op1, op2))
else:
    print("Operación no contemplada")

print("Operación ejecutada. Continuación de ejecución del programa ")

# =========================================
# Path: video22.py
# =========================================
