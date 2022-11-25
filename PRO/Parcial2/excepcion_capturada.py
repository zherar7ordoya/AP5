# --- CAPA TRANSVERSAL (si esto fuera una arquitectura en capas) ---------------
from colorama import Fore


# Todavía estoy investigando esta técnica.
class ExceptionCapturada(Exception):
    def __init__(self, mensaje, *errores):
        Exception.__init__(self, mensaje)
        self.errores = errores
        print(f"\n{Fore.RED}{errores[0]}{Fore.RESET}")
        input("Presione una tecla para continuar...")

