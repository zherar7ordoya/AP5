import csv
from excepcion_capturada import RegistroSistematicoExcepciones


class AccesoDatos:
    def __init__(self, archivo):
        self.archivo = archivo

    def __enter__(self):
        """ Método mágico para el uso de with que se ejecuta al inicio """
        return self

    # No toques los argumentos, no importa lo que Pylint diga.
    def __exit__(self, *args, **kwargs):
        """ Método mágico para el uso de with que se ejecuta al final """
        return self

    # Pylint me dice que el método leer() puede ser estático, pero no me lo justifica.
    def leer(self):
        try:
            with open(self.archivo) as dat:
                return list(csv.reader(dat))
        except FileNotFoundError as e:
            raise RegistroSistematicoExcepciones("NO SE ENCONTRÓ EL ARCHIVO", *e.args)

    # Pylint me dice que el método escribir() puede ser estático, pero no me lo justifica.
    def escribir(self, listado):
        try:
            with open(self.archivo, 'w', newline='\n') as dat:
                csv.writer(dat).writerows(listado)
        except Exception as e:
            raise RegistroSistematicoExcepciones("ERROR AL CERRAR EL ARCHIVO", *e.args)
