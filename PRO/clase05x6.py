"""
                        [DESCRIPCIÓN DE ESTE MÓDULO]
Video 6 - Override a la clase padre
"""
__author__ = "Gerardo Tordoya"
__date__ = "2022-09-15"

################################################################################

class Persona:
    """ Clase Persona """
    def __init__(self, nombre, edad):
        self.nombre = nombre
        self.edad = edad

    def __str__(self):
        return f"Nombre: {self.nombre}, edad: {self.edad}"

    def mayor_edad(self):
        """ Determina si es mayor de edad """
        if self.edad >= 18:
            return True
        else:
            return False

    def muestra_datos(self):
        """ Muestra los datos de la persona """
        print("El nombre es", self.nombre)
        print("La edad es", self.edad)


class Empleado(Persona):
    """ Clase Empleado """
    def __init__(self, nombre, edad, sueldo):
        super().__init__(nombre, edad)
        self.sueldo = sueldo

    def __str__(self):
        return f"Nombre: {self.nombre}, edad: {self.edad}, sueldo: {self.sueldo}"

    def muestra_datos(self):
        """ Muestra los datos del empleado """
        super().muestra_datos()
        print("El sueldo es", self.sueldo)

    def mayor_sueldo(self):
        """ Determina si el sueldo es mayor a 1000 """
        if self.sueldo > 1000:
            return True
        else:
            return False

    def mayor_edad(self):
        """ Determina si es mayor de edad """
        if self.edad >= 21:
            print("Es mayor de edad")
            return True
        else:
            print("No es mayor de edad")
            return False

################################################################################

if __name__ == '__main__':

    persona1 = Persona("Juan", 20)
    persona1.muestra_datos()
    print(persona1)

    empleado1 = Empleado("Ana", 17, 25000)
    empleado1.muestra_datos()
    print(empleado1)
