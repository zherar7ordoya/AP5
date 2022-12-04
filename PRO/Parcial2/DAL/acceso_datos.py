import csv
from EHL.handler_logger import CapturadorExcepciones


class AccesoDatos:
    def __init__(self, archivo):
        self.archivo = archivo

    def __enter__(self):
        """ Método mágico para el uso de with que se ejecuta al inicio """
        return self

    def __exit__(self, *args, **kwargs):
        """ Método mágico para el uso de with que se ejecuta al final """
        return self

    def leer(self):
        try:
            with open(self.archivo) as dat:
                return list(csv.reader(dat))
        except FileNotFoundError as e:
            raise CapturadorExcepciones("Archivo no encontrado", *e.args)
        except Exception as e:
            raise CapturadorExcepciones("Error de lectura", *e.args)

    def escribir(self, listado):
        try:
            with open(self.archivo, 'w', newline='\n') as dat:
                csv.writer(dat).writerows(listado)
        except Exception as e:
            raise CapturadorExcepciones("Error de escritura", *e.args)
