"""
@title:   AGREGACIÓN (video 13)
@video:   https://youtu.be/u-T2aowKj6w
@author:  Gerardo Tordoya
@date:    2022-10-21
@remarks: La agregación es una forma de extender las capacidades de una clase
          sin tener que recurrir a la herencia. ¿Cómo se hace? Pues teniendo en
          su interior otro objeto cuyas características nos interesa adquirir.
          Se puede decir que es un objeto contenedor que contiene a otro/s
          objeto/s. Ejemplo: una biblioteca contiene libros.
          Finalmente, debe remarcarse que tanto el objeto contenedor como el
          objeto contenido pueden existir por separado (no son dependientes).
          Ejemplo: si destruyo biblioteca, los libros siguen existiendo.
"""

from colorama import Fore


# CLASE CONTENIDA
class Libro:
    def __init__(self, titulo, autor):
        self.titulo = titulo
        self.autor = autor

    def __str__(self):
        return f"Libro: {self.titulo} - Autor: {self.autor}"


# CLASE CONTENEDORA
class Biblioteca:
    def __init__(self, nombre, ciudad):
        self.nombre = nombre
        self.ciudad = ciudad
        self.libro = None
        self.libros = []

    def mostrar_libros(self):
        print(f"\n{Fore.GREEN}Biblioteca: {self.nombre} - Ciudad: {self.ciudad}{Fore.RESET}")

        if len(self.libros) == 0:
            print("No hay libros en la biblioteca")
        else:
            for libro in self.libros:
                print(libro)

    def agregar_libro(self, libro):
        # "isinstance" es una función que comprueba si el objeto que le pasamos
        # es de la clase que le indicamos: Python no es fuertemente tipado, por
        # lo que no es necesario verficar así el tipo de dato que le pasamos.
        if isinstance(libro, Libro):
            self.libros.append(libro)
        else:
            print("El objeto no es de la clase Libro")


# ─── PROGRAMA PRINCIPAL ──────────────────────────────────────────────────────
print("\nCreamos una biblioteca:")
biblioteca1 = Biblioteca("Nacional", "Madrid")
biblioteca1.mostrar_libros()

print("\nAgregamos un libro a la biblioteca (agregación):")
libro1 = Libro("El Quijote", "Cervantes")
biblioteca1.agregar_libro(libro1)
biblioteca1.mostrar_libros()

print("\nHacemos una agregación errónea:")
biblioteca1.agregar_libro("Libro 2")

print("\nAgregamos más libros a la biblioteca:")
libro2 = Libro("El Hobbit", "Tolkien")
libro3 = Libro("El Señor de los Anillos", "Tolkien")
biblioteca1.agregar_libro(libro2)
biblioteca1.agregar_libro(libro3)
biblioteca1.mostrar_libros()
