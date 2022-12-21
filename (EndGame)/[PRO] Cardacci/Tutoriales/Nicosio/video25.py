# ==============================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-26
# Description: Interfaces informales || Video 25 || https://youtu.be/L02gy-dSfNg
# ==============================================================================


# Como se dijo, Python no tiene interfaces formales, pero si podemos simularlas
# (es lo que se vio en los videos anteriores). Pero un problema que puede darse
# es que si se implementa una interfaz, puede que no necesariamente se
# implementen sus métodos. Para evitar esto, podemos usar el módulo abc (Abstract
# Base Classes) que viene con Python. Este módulo nos permite definir clases
# abstractas, que no se pueden instanciar, pero que sí pueden ser heredadas.
# O bien, podemos definir excepciones para los métodos que no se implementen.

class IAnimal:
    """Interfaz animal"""

    def ingresar_datos(self, nombre: str, peso: float) -> bool:
        """
        Parameters
        ----------
        nombre : str
            Nombre del animal.
        peso : float
            Peso del animal.

        Returns
        -------
        bool
            True si el animal tiene sobrepeso.
        """
        try:
            raise NotImplementedError("No se ha implementado el método «ingresar_datos»")
        except NotImplementedError as e:
            print(e)

    def caminar(self, metros: int):
        """
        Parameters
        ----------
        metros : int
            Cantidad de metros a caminar.

        Returns
        -------
        None.
        """
        try:
            raise NotImplementedError("No se ha implementado el método «caminar»")
        except NotImplementedError as e:
            print(e)


# --- Vamos a implementar la interfaz IAnimal ---------------------------------

# Esta clase cumple con la interfaz IAnimal.
class Gato(IAnimal):

    def __init__(self):
        self.nombre = None
        self.peso = None

    def ingresar_datos(self, nombre: str, peso: float) -> bool:
        self.nombre = nombre
        self.peso = peso

        if self.peso > 7:
            return True
        else:
            return False

    def caminar(self, metros: int):
        if 70 < metros < 850:
            print("Tu gato camina lo suficiente")
        else:
            print("Lleva a tu gato a caminar más")

    def __repr__(self):
        return f"Gato: {self.nombre} \t Peso: {self.peso}"


# En cambio, esta clase no cumple con la interfaz IAnimal.
class Tortuga(IAnimal):
    pass


# --- Vamos a usar la nueva clase ---------------------------------------------
mi_tortuga = Tortuga()
print(mi_tortuga.ingresar_datos("Manuelita", 0.25))

# Finalmente, otra desventaja de esta simulación de interfaces es que se puede
# implementar la interfaz misma:
mi_interfaz = IAnimal()
print(mi_interfaz)
