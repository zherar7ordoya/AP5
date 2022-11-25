import csv

from excepcion_capturada import ExceptionCapturada


# --- DAL (si esto fuera una arquitectura en capas) ----------------------------

class AccesoDatos:

    def __enter__(self):
        """ Método mágico para el uso de with que se ejecuta al inicio """
        return self

    # No toques los argumentos, no importa lo que Pylint diga.
    def __exit__(self, *args, **kwargs):
        """ Método mágico para el uso de with que se ejecuta al final """
        return self

    # Pylint me dice que el método leer() puede ser estático, pero no me lo justifica.
    def leer(self, archivo):
        try:
            with open(archivo) as dat:
                return list(csv.reader(dat))
        except FileNotFoundError as e:
            raise ExceptionCapturada("NO SE ENCONTRÓ EL ARCHIVO", *e.args)

    # Pylint me dice que el método escribir() puede ser estático, pero no me lo justifica.
    def escribir(self, archivo, lista):
        try:
            with open(archivo, 'w', newline='\n') as dat:
                csv.writer(dat).writerows(lista)
        except Exception as e:
            raise ExceptionCapturada("ERROR AL CERRAR EL ARCHIVO", *e.args)





