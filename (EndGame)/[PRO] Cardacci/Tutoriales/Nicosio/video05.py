""" 
@title: Video 5 - Sobrecarga de init
@description: Python no tiene sobrecarga de constructores, pero sí podemos simularlo.
@author: Gerardo Tordoya
@date: 2022-09-15
"""


class Alumno:
    def __init__(self, *args):
        if len(args) == 0:
            self.nombre = "Sin nombre"
            self.edad = "Sin edad"
            self.calificacion = 0
        elif len(args) == 1:
            self.nombre = args[0]
            self.edad = "Sin edad"
            self.calificacion = 0
        elif len(args) == 2:
            self.nombre = args[0]
            if args[1] >= 18:
                self.edad = args[1]
            else:
                self.edad = "Sin edad"
            self.calificacion = 0
        elif len(args) == 3:
            self.nombre = args[0]
            if args[1] >= 18:
                self.edad = args[1]
            else:
                self.edad = "Sin edad"
            self.calificacion = args[2]
        else:
            print("Cantidad de argumentos inválida")
            self.nombre = "Sin nombre"
            self.edad = "Sin edad"
            self.calificacion = 0

    def muestra_datos(self):
        print(self.nombre, self.edad, self.calificacion)


# ─── MAIN ────────────────────────────────────────────────────────────────────

if __name__ == '__main__':
    alumno1 = Alumno()
    alumno2 = Alumno("Juan")
    alumno3 = Alumno("Juan", 20)
    alumno4 = Alumno("Juan", 20, 8)
    alumno5 = Alumno("Juan", 20, 8, 9)

    alumno1.muestra_datos()
    alumno2.muestra_datos()
    alumno3.muestra_datos()
    alumno4.muestra_datos()
    alumno5.muestra_datos()
