# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-28
# Description: Excepciones
#              Video 23
#              https://youtu.be/dLH-oay4Bts
# =========================================


# USO DE RAISE

def evaluar_edad(edad):
    if edad < 0:
        try:
            raise TypeError("No se permiten edades negativas")
        except TypeError as error:
            print(error)
            return "Se ha producido un error"
    if edad < 20:
        return "Eres muy joven"
    elif edad < 40:
        return "Eres joven"
    elif edad < 65:
        return "Eres maduro"
    elif edad < 100:
        return "Cuidate..."


print(evaluar_edad(-18))
print("Programa finalizado")
