# ========================================================
# Author:       Gerardo Tordoya
# Create date:  2022-11-29
# Description:  Error/Exception Handler Logger/Layer (EHL)
# ========================================================
import sys
from datetime import datetime
from colors import color


class CapturadorExcepciones(Exception):
    def __init__(self, message, *errors):
        Exception.__init__(self, message)

        # Podría generar un CSV cambiando " > " por ","
        registro = f"{datetime.now().strftime('%Y-%m-%d %H:%M')} > " \
                   f"{message} > " \
                   f"{str(sys.exc_info()[0])} > " \
                   f"{errors}"

        with open('EHL/excepciones.log', 'r+') as archivo:
            registros = archivo.read()
            archivo.seek(0, 0)
            archivo.write(f"{registro}\n{registros}")

        print(color(f"{message} > {errors}", fg="red"))
        input("\nPresione una tecla para continuar...\n")
