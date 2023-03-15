# ==================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-24
# Description: Sobrecarga de operadores relacionales
#              Video 18 https://youtu.be/kqdaeYBoBAg
# ==================================================

class Libro:
    def __init__(self, paginas):
        self.paginas = paginas

    def __add__(self, otro):
        return self.paginas + otro.paginas

    def __gt__(self, otro):
        return self.paginas > otro.paginas


libro1 = Libro(50)
libro2 = Libro(200)

if libro1 > libro2:
    print("El libro 1 tiene mas paginas")
else:
    print("El libro 2 tiene mas paginas")


# Un caso particular. La siguiente clase, la clase Revista, tiene un atributo
# con el mismo nombre que la clase Libro. Ésto nos permitiría hacer:

class Revista:
    def __init__(self, paginas):
        self.paginas = paginas


revista1 = Revista(100)

if libro1 > revista1:
    print("El libro 1 tiene mas paginas")
else:
    print("La revista 1 tiene mas paginas")

# Recordar que se aprovecha el método __gt__ de la clase Libro:
#   >>> return self.paginas > otro.paginas
# En donde el primer operador es la instancia de la clase Libro, que toma como
# segundo operador a la instancia de la clase Revista (el "otro"), de decir, a
# el atributo paginas de la clase Revista.
