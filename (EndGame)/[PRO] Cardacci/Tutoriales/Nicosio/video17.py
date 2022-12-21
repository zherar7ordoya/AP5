# ==============================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-24
# Description: Sobrecarga de operadores (Video 17: https://youtu.be/lQlp3UY_QCg)
# ==============================================================================

# La sobrecarga de operadores es "enseñarle" a las clases a que se comporten como
# si fueran tipos de datos nativos de Python. Por ejemplo, si queremos que una
# clase se comporte como un número, podemos sobrecargar los operadores +, -, *, /
# y otros.

# Para sobrecargar un operador, debemos definir un método en la clase que tenga
# el mismo nombre que el operador que queremos sobrecargar. Por ejemplo, si
# queremos sobrecargar el operador +, debemos definir un método llamado __add__.
# Este método debe recibir dos parámetros: el primero es el objeto que llama al
# método, y el segundo es el objeto que se le pasa como parámetro al operador.
# El método __add__ debe devolver el resultado de la operación. Por ejemplo, si
# queremos que la clase Punto se comporte como un número, podemos sobrecargar
# el operador + para que devuelva un nuevo punto que sea la suma de los dos
# puntos que se suman.

# Vemos un escenario:

a = 5
b = 10
c = "¡Hola "
d = "mundo!"

# Ésto lo puedo hacer:
print(a + b)  # 15
print(c + d)  # ¡Hola mundo!

# Pero si intento hacer lo mismo con mis propias clases, no funciona:

"""
class Contenedor:
    def __init__(self, litros):
        self.litros = litros

c1 = Contenedor(5)
c2 = Contenedor(10)
print(c1 + c2) # TypeError: unsupported operand type(s) for +: 'Contenedor' and 'Contenedor'
"""


# Esto es porque no hemos sobrecargado el operador + para que funcione con objetos
# de la clase Contenedor. Para hacerlo, debemos definir un método llamado __add__
# en la clase Contenedor.

"""
class Contenedor:
    def __init__(self, litros):
        self.litros = litros

    def __add__(self, otro):
        return self.litros + otro.litros


c1 = Contenedor(50)
c2 = Contenedor(100)
print(c1 + c2)  # 300
"""

# Ahora veamos de hacer un poco más complejo el ejemplo:

class Contenedor:
    def __init__(self, litros):
        self.litros = litros

    def __add__(self, otro):
        # En este caso, vamos a regresar una instancia de la clase Contenedor
        return Contenedor(self.litros + otro.litros)

    def __repr__(self):
        return f"El contenedor tiene {self.litros} litros"


c1 = Contenedor(50)
c2 = Contenedor(100)
c3 = c1 + c2
print(c3)  # El contenedor tiene 150 litros

# ...o también:
print(c1 + c2)
