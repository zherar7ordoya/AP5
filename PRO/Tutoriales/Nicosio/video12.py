"""
@title:  POLIMORFISMO (video 12)
@video:  https://youtu.be/nddslqcV8sA
@author: Gerardo Tordoya
@date:   2022-10-21
"""


class Animal:
    def __init__(self, nombre):
        self.nombre = nombre

    def __repr__(self):
        return f"Animal (nombre = '{self.nombre}')"

    def mover(self):
        print(f"{self.nombre} se mueve")


class Perro(Animal):
    def mover(self):
        print(f"{self.nombre} corre")


class Pez(Animal):
    def mover(self):
        print(f"{self.nombre} nada")


class Reptil(Animal):
    def mover(self):
        print(f"{self.nombre} se arrastra")


def trabaja_animal(animal):
    print(f"Trabajando con {animal}")
    # No es para confundirse, es como si hiciera lo siguiente:
    print(animal)
    animal.mover()


print("¿Qué mascosta quieres?")
print("1. Perro")
print("2. Pez")
print("3. Reptil")
opcion = input("¿Qué eliges? ")
nombre = input("¿Cómo se llama? ")

if opcion == "1":
    mascota = Perro(nombre)
elif opcion == "2":
    mascota = Pez(nombre)
elif opcion == "3":
    mascota = Reptil(nombre)

trabaja_animal(mascota)

print("""
-----------------------
2DA PARTE: POLIMORFISMO
-----------------------
""")

mascota1 = Perro("Firulais")
mascota2 = Pez("Nemo")
mascota3 = Reptil("Serpiente")

mascotas = [mascota1, mascota2, mascota3]

for mascota in mascotas:
    print(mascota)
    mascota.mover()
