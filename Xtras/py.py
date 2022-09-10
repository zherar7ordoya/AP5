""" @author: Gerardo
    @date: 2022-09-09
    @description: Colores en Python
"""

# Run the script

class Vector:
    """Crea el vector"""
    def __init__(self, param1 = "Hello ", param2 = "World!"):
        self.xth = param1
        self.yth = param2

    def muestra(self):
        """Muestra el vector"""
        print(self.xth, self.yth)       # Se refiere a los atributos de la clase
        print("Muestra concluída...")   # Se refiere a un string

    def __str__(self):
        return self.xth + self.yth

VECTOR = Vector()
VECTOR.muestra()
