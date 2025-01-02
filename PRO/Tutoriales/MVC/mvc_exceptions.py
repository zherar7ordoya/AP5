# ====================================================================
# Author:       Gerardo Tordoya
# Create date:  2023-01-19
# Description:  Gerardo, te sugiero que dividas en tres este proyecto:
#                   1) MVC sin persistencia
#                   2) MVC con persistencia
#                   3) MVC con ORM
# ====================================================================

# FUENTE:
# https://www.giacomodebidda.com/posts/mvc-pattern-in-python-introduction-and-basicmodel/




# mvc_exceptions.py
class ItemAlreadyStored(Exception):
    pass


class ItemNotStored(Exception):
    pass
