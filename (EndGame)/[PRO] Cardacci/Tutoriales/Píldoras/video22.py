# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-28
# Description: Excepciones
#              Video 22
#              https://youtu.be/HH3c6ZBvSx8
# =========================================


def suma(num1, num2):
    return num1 + num2


def resta(num1, num2):
    return num1 - num2


def multiplica(num1, num2):
    return num1 * num2


# Operación DIVIDE modificada.
def divide():
    try:
        dividendo = (float(input("Introduce el primer número: ")))
        divisor = (float(input("Introduce el segundo número: ")))
        print("La división es: " + str(dividendo / divisor))
    # except ValueError:
    #     print("El valor introducido es erróneo.")
    # except ZeroDivisionError:
    #     print("No se puede dividir entre 0.")
    except:
        print("Ha ocurrido un error.")
    finally:
        print("Cálculo finalizado.")


# Este bloque es interesante.------------------
while True:
    try:
        op1 = (int(input("Introduce el primer número: ")))
        op2 = (int(input("Introduce el segundo número: ")))
        break
    except ValueError:
        print("Los valores introducidos no son correctos. Inténtalo de nuevo")
# ---------------------------------------------

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
