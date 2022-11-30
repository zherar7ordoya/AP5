# ========================================================
# Author:       Gerardo Tordoya
# Create date:  2022-11-29
# Description:  Error/Exception Handler Logger/Layer (EHL)
# ========================================================


from datetime import datetime
from colors import color


class CapturadorExcepciones(Exception):
    def __init__(self, message, *errors):
        Exception.__init__(self, message)

        registro = f"{datetime.now().strftime('%Y-%m-%d %H:%M')} > " \
                   f"{message} > " \
                   f"{errors}"

        with open('EHL/excepciones.log', 'r+') as archivo:
            registros = archivo.read()
            archivo.seek(0, 0)
            archivo.write(f"{registro}\n{registros}")

        print(color(f"{message} > {errors}", fg="red"))
        input("\nPresione una tecla para continuar...\n")
