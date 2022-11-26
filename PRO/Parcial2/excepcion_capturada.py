from datetime import date


class RegistroSistematicoExcepciones(Exception):
    def __init__(self, message, *errors):
        Exception.__init__(self, message)
        self.errors = errors

        self.log = open("excepciones.log", "a")
        self.log.write(f"{date.today()} > {message} > {errors}\n")
        self.log.close()
        print(f"Problema detectado:\n{message} > {errors}")
        input("Presione una tecla para continuar...")
