from datetime import date

from colors import color
from consolemenu import *
from consolemenu.prompt_utils import PromptUtils


class RSE(Exception):
    """ Registro Sistemático de Excepciones """
    def __init__(self, message, *errors):
        Exception.__init__(self, message)
        self.errors = errors

        self.log = open("SEC/excepciones.log", "a")
        self.log.write(f"{date.today()} > {message} > {errors}\n")
        self.log.close()

        print(color(f"\n{message} > {errors}\n", fg="red"))
        PromptUtils(Screen()).enter_to_continue()
