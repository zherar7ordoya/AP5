# =================================================
# Author:       Gerardo Tordoya
# Create date:  2022-11-29
# Description:  Error/Exception Handler Layer (EHL)
# =================================================

from datetime import date
from colors import color
from consolemenu import *
from consolemenu.prompt_utils import PromptUtils

import logging

logging.basicConfig(filename='EHL/excepciones.log', level=logging.ERROR)


# Exception/Error Handler/Logger
class RegistradorExcepciones(Exception):
    def __init__(self, message, *errors):
        Exception.__init__(self, message)
        self.errors = errors

        # self.log = open("EHL/excepciones.log", "a")
        # self.log.write(f"{date.today()} > {message} > {errors}\n")
        # self.log.close()

        logging.exception(str(errors[1]))

        print(color(f"\n{message} > {errors[1]}\n", fg="red"))
        PromptUtils(Screen()).enter_to_continue()
