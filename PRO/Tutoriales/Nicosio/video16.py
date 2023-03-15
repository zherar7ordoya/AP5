# ========================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-24
# Description: Variables de clase (Video 16: https://youtu.be/9uTI8R0245g)
# ========================================================================

# Las variables de clase pertenecen a la clase, no a la instancia. Por tanto,
# todos los objetos (instancias) creadas van a tener esas variables de tal
# forma que si un objeto modifica el valor de esa variable, esa modificación se
# reflejará para todos los objetos (es decir, todos compartirán el cambio).
# Usualmente, se usan para definir constantes que todas las instancias puedan
# usar. Funcionalmente, se parecen mucho a las variables estáticas de C#.

class CuentaBanco:

    # Variable de clase (no se usa self)
    tipo_cambio = 20.22

    def __init__(self, cantidad):
        # Variable de instancia (es particular de cada objeto)
        self.cantidad = cantidad

    def convertir_dolares(self):
        # Así se accede a una variable de clase (tipo_cambio: no se usa self)
        print(self.cantidad / CuentaBanco.tipo_cambio)


cuenta1 = CuentaBanco(500)
cuenta2 = CuentaBanco(2357)

cuenta1.convertir_dolares()
cuenta2.convertir_dolares()

print('------------------------------')
CuentaBanco.tipo_cambio = 18.57

cuenta1.convertir_dolares()
cuenta2.convertir_dolares()
