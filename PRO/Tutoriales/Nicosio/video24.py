# ==============================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-26
# Description: Interfaces informales || Video 24 || https://youtu.be/bZXXZKBeCmQ
# ==============================================================================

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
        pass

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
        pass


# --- Vamos a implementar la interfaz IAnimal ---------------------------------
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
            print("Tu gato no camina lo suficiente")

    def __repr__(self):
        return f"Gato: {self.nombre} \t Peso: {self.peso}"


# --- Vamos a usar la interfaz IAnimal ----------------------------------------
mi_gato = Gato()
print(mi_gato.ingresar_datos("Garfield", 8))
mi_gato.caminar(100)
print(mi_gato)
