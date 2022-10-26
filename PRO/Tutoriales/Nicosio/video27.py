# =======================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-26
# Description: Interfaces con Protocol
#              Video 27 || https://youtu.be/IiyHjdD7_Ak
# =======================================================================

# --- RECAPITULANDO --------------------------------------------------------- *
#   - Video 24 -> Interfaces Informales                                       *
#   - Video 25 -> Interfaces Informales con Excepciones                       *
#   - Video 26 -> Interfaces Formales con ABC (clases abstractas)             *
#   - Video 27 -> Interfaces Formales con Protocolos                          *
# --------------------------------------------------------------------------- *

# from typing import Protocol
from typing_extensions import Protocol


class IAnimal(Protocol):
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

    def caminar(self, metros: int) -> None:
        """
        Parameters
        ----------
        metros : int
            Cantidad de metros a caminar.

        Returns
        -------
        None.
        """


# --------------------------------------------------------------------------- *

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


class Perro(IAnimal):
    # Esta clase solo implementa uno de los métodos de la interfaz.
    def caminar(self, metros: int):
        if 70 < metros < 850:
            print("Tu perro camina lo suficiente")
        else:
            print("Lleva a tu perro a caminar más")


# --------------------------------------------------------------------------- *

# mi_gato = Gato()
# print(mi_gato.ingresar_datos("Garfield", 8))
# mi_gato.caminar(100)
# print(mi_gato)

# mi_perro = Perro()
# mi_perro.caminar(100)

otro_gato = IAnimal()  # Protocolo no se puede instanciar
