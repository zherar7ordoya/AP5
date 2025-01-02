"""
@title: Override a la clase padre (Video 10)
@video: https://youtu.be/c__WOp7TYsI
@author: Gerardo Tordoya
@date: 2022-10-20
"""


# Clase Base
class Persona:
    def __init__(self, nombre, edad):
        self.nombre = nombre
        self.edad = edad

    def __str__(self):
        return f"Nombre: {self.nombre}, edad: {self.edad}"

    def mayor_edad(self):
        if self.edad >= 18:
            return True
        else:
            return False

    def muestra_datos(self):
        print("El nombre es", self.nombre)
        print("La edad es", self.edad)


# Clase Heredera
class Empleado(Persona):
    def __init__(self, nombre, edad, sueldo, puesto):
        super().__init__(nombre, edad)
        self.sueldo = sueldo
        self.puesto = puesto

    def mayor_sueldo(self):
        if self.sueldo > 1000:
            return True
        else:
            return False

    # Override
    def __str__(self):
        return f"Nombre: {self.nombre}, edad: {self.edad}, sueldo: {self.sueldo}"

    # Override
    def muestra_datos(self):
        super().muestra_datos()
        print("El sueldo es", self.sueldo)
        print("El puesto es", self.puesto)

    # Override
    def mayor_edad(self):
        if self.edad >= 21:
            print("Es mayor de edad")
            return True
        else:
            print("No es mayor de edad")
            return False


if __name__ == '__main__':
    persona1 = Persona("Juan", 20)
    persona1.muestra_datos()
    print(persona1)

    print("----------------------")

    empleado1 = Empleado("Ana", 17, 25000, "CAJERA")
    empleado1.muestra_datos()
    print(empleado1)
