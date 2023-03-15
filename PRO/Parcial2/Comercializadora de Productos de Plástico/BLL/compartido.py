from colors import color
from BLL.validaciones import Valida


class Compartido:

    @staticmethod
    def obtener_idx(listado):
        for idx, x in enumerate(listado):
            print(idx, x)

        while True:
            try:
                # Compruebo que el índice sea un número entero
                idx = int(input("\nIngrese el número de registro del artículo a modificar: "))
                # Compruebo que el índice esté dentro del rango de la lista
                if idx < 0 or idx > len(listado) - 1:
                    print(color("\nDebe ingresar un número de registro válido", fg='red'))
                else:
                    break
            except ValueError:
                print(color("\nDebe ingresar un número entero", fg='red'))

        return idx


    @staticmethod
    def obtener_codigo():
        # Necesito instancia porque valida_codigo() no es un método estático
        validacion = Valida()
        while True:
            codigo = input("Ingrese el código del artículo (LNNN): ")
            if Valida.valida_codigo(codigo):
                if not validacion.existe_codigo(codigo):
                    return codigo
                else:
                    print("El código ingresado ya existe.")
            else:
                print("El código ingresado no es válido.")


    @staticmethod
    def obtener_descripcion():
        while True:
            descripcion = input("Ingrese la descripción del artículo: ")
            if Valida.valida_descripcion(descripcion):
                return descripcion
            else:
                print("La descripción ingresada no es válida. Debe ingresar 1 letra mayúscula + 3 letras o más")


    @staticmethod
    def obtener_stock():
        while True:
            stock = input("Ingrese el stock del artículo: ")
            if Valida.valida_stock(stock):
                return stock
            else:
                print("El stock ingresado no es válido. Debe ingresar un número mayor a 0")


    @staticmethod
    def obtener_fecha():
        while True:
            fecha = input("Fecha (dd/mm/aaaa): ")
            if Valida.valida_fecha(fecha):
                return fecha
            else:
                print("Error. Debe ingresar una fecha válida")


    @staticmethod
    def obtener_articulo():
        while True:
            # Necesito instancia porque valida_codigo() no es un método estático
            validacion = Valida()
            codigo = input("Código de artículo (LNNN): ")
            if Valida.valida_codigo(codigo) and validacion.existe_codigo(codigo):
                return codigo
            else:
                print("Error. Debe ingresar 1 letra mayúscula + 3 números (de un código que sí existe)")


    @staticmethod
    def obtener_vendedor():
        while True:
            vendedor = input("Vendedor: ")
            if Valida.valida_vendedor(vendedor):
                return vendedor
            else:
                print("Error. Debe ingresar 1 letra mayúscula + 3 letras o más")


    @staticmethod
    def obtener_sucursal():
        while True:
            sucursal = input("Sucursal (LLLNNN): ")
            if Valida.valida_sucursal(sucursal):
                return sucursal
            else:
                print("Error. Debe ingresar 3 letras mayúsculas + 3 números")


    @staticmethod
    def obtener_importe():
        while True:
            importe = input("Importe: ")
            if Valida.valida_importe(importe):
                importe = float(importe.replace(",", "."))
                return format(importe, '.2f')
            else:
                print(color("\nError. Debe ingresar un importe válido (número con 2 decimales)\n", fg="yellow"))
