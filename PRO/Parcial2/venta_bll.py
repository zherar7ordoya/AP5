import click
from colorama import Fore

from excepcion_capturada import ExceptionCapturada
from validaciones import Valida
from venta_bel import VentaBEL
from venta_mpp import VentaMPP


class VentaBLL:

    def alta(self):
        try:
            print("ALTA DE VENTA\n=============\n")

            venta = VentaBEL(self.obtener_fecha(),
                             self.obtener_articulo(),
                             self.obtener_vendedor(),
                             self.obtener_sucursal(),
                             self.obtener_importe())
            venta_mpp = VentaMPP()

            if click.confirm(f"\n¿Confirma el alta?"):
                venta_mpp.create(venta)
                print(f"\nAgregado > {Fore.YELLOW}{venta}{Fore.RESET}")
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")

        except ExceptionCapturada as e:
            print(e)

    def baja(self):
        try:
            print("BAJA DE VENTA\n=============\n")

            venta_mpp = VentaMPP()

            listado = venta_mpp.leer(venta_mpp.archivo)
            for idx, x in enumerate(listado):
                print(idx, x)

            # Este es un caso especial. Exception no abarca a ValueError.
            while True:
                try:
                    idx = int(input("\nIngrese el número de registro de la venta a eliminar: "))
                    break
                except ValueError:
                    print("Error. Debe ingresar un número entero")

            if click.confirm(f"\n¿Confirma la baja?"):
                venta_mpp.delete(idx)
                print(f"\nEliminado > {Fore.YELLOW}{listado[idx]}{Fore.RESET}")
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")

        except ExceptionCapturada as e:
            print(e)

    def modificacion(self):
        try:
            print("MODIFICACIÓN DE VENTA\n=====================\n")

            venta_mpp = VentaMPP()
            listado = venta_mpp.leer(venta_mpp.archivo)

            for idx, x in enumerate(listado):
                print(idx, x)

            # Este es un caso especial. Exception no abarca a ValueError.
            while True:
                try:
                    idx = int(input("\nIngrese el número de registro de la venta a modificar: "))
                    break
                except ValueError:
                    print("Error. Debe ingresar un número entero")

            print("\nIngrese los nuevos datos de la venta")
            venta = VentaBEL(self.obtener_fecha(),
                             self.obtener_articulo(),
                             self.obtener_vendedor(),
                             self.obtener_sucursal(),
                             self.obtener_importe())

            if click.confirm(f"\n¿Confirma la modificación?"):
                venta_mpp.update(venta, idx)
                print(f"\nModificado > {Fore.YELLOW}{venta}{Fore.RESET}")
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")

        except ExceptionCapturada as e:
            print(e)

    def obtener_fecha(self):
        while True:
            fecha = input("Fecha (dd/mm/aaaa): ")
            if Valida.valida_fecha(fecha):
                return fecha
            else:
                print("Error. Debe ingresar una fecha válida")

    # Esto necesito aclararlo:
    #   obtener_articulo() > verifica que SÍ exista el código
    #   obtener_codigo()   > verifica que NO exista el código
    def obtener_articulo(self):
        while True:
            codigo = input("Código de artículo (LNNN): ")
            if Valida.valida_codigo(codigo) and Valida.existe_codigo(codigo):
                return codigo
            else:
                print("Error. Debe ingresar 1 letra mayúscula + 3 números (de un código que sí existe)")

    def obtener_vendedor(self):
        while True:
            vendedor = input("Vendedor: ")
            if Valida.valida_vendedor(vendedor):
                return vendedor
            else:
                print("Error. Debe ingresar 1 letra mayúscula + 3 letras o más")

    def obtener_sucursal(self):
        while True:
            sucursal = input("Sucursal (LLLNNN): ")
            if Valida.valida_sucursal(sucursal):
                return sucursal
            else:
                print("Error. Debe ingresar 3 letras mayúsculas + 3 números")

    def obtener_importe(self):
        while True:
            importe = input("Importe: ")
            if Valida.valida_importe(importe):
                return importe
            else:
                print("Error. Debe ingresar un importe válido (NN.DD)")
