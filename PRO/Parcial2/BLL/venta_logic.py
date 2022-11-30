import click
from colors import color

from EHL.handler_logger import CapturadorExcepciones
from BLL.validaciones import Valida
from BEL.venta_model import VentaModel
from MPP.venta_mapper import VentaMapper


def obtener_fecha():
    while True:
        fecha = input("Fecha (dd/mm/aaaa): ")
        if Valida.valida_fecha(fecha):
            return fecha
        else:
            print("Error. Debe ingresar una fecha válida")


def obtener_articulo():
    while True:
        # Necesito instancia porque valida_codigo() no es un método estático
        validacion = Valida()
        codigo = input("Código de artículo (LNNN): ")
        if Valida.valida_codigo(codigo) and validacion.existe_codigo(codigo):
            return codigo
        else:
            print("Error. Debe ingresar 1 letra mayúscula + 3 números (de un código que sí existe)")


def obtener_vendedor():
    while True:
        vendedor = input("Vendedor: ")
        if Valida.valida_vendedor(vendedor):
            return vendedor
        else:
            print("Error. Debe ingresar 1 letra mayúscula + 3 letras o más")


def obtener_sucursal():
    while True:
        sucursal = input("Sucursal (LLLNNN): ")
        if Valida.valida_sucursal(sucursal):
            return sucursal
        else:
            print("Error. Debe ingresar 3 letras mayúsculas + 3 números")


def obtener_importe():
    while True:
        importe = input("Importe: ")
        if Valida.valida_importe(importe):
            importe = float(importe.replace(",", "."))
            return format(importe, '.2f')
        else:
            print(color("\nError. Debe ingresar un importe válido (número con 2 decimales)\n", fg="yellow"))


class VentaLogic(VentaMapper):

    def __init__(self):
        super().__init__()
        self.venta_mpp = VentaMapper()

    def alta(self):
        try:
            print("ALTA DE VENTA\n=============\n")

            venta = VentaModel(obtener_fecha(),
                               obtener_articulo(),
                               obtener_vendedor(),
                               obtener_sucursal(),
                               obtener_importe())

            if click.confirm(f"\n¿Confirma el alta?"):
                self.venta_mpp.create(venta)
                print(f"\nAgregado > " + color(f"{venta}", fg="yellow"))
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")

        except Exception as e:
            raise CapturadorExcepciones("Error al dar el alta a la venta", *e.args)

    def baja(self):
        try:
            print("BAJA DE VENTA\n=============\n")

            listado = self.venta_mpp.leer()
            for idx, x in enumerate(listado):
                print(idx, x)

            # Este es un caso especial. Exception no abarca a ValueError.
            while True:
                try:
                    idx = int(input("\nIngrese el número de registro de la venta a eliminar: "))
                    break
                except ValueError:
                    print("Error. Debe ingresar un número entero")

            # Y este es un caso a prueba de chistosos o distraídos.
            if idx < 0 or idx > len(listado) - 1:
                raise CapturadorExcepciones("Debe ingresar un número de registro válido")

            if click.confirm(f"\n¿Confirma la baja?"):
                self.venta_mpp.delete(idx)
                print(f"\nEliminado > " + color(f"{listado[idx]}", fg="yellow"))
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")

        except Exception as e:
            raise CapturadorExcepciones("Error al intentar dar de baja la venta", *e.args)

    def modificacion(self):
        try:
            print("MODIFICACIÓN DE VENTA\n=====================\n")

            listado = self.venta_mpp.leer()

            for idx, x in enumerate(listado):
                print(idx, x)

            # Este es un caso especial. Exception no abarca a ValueError.
            while True:
                try:
                    idx = int(input("\nIngrese el número de registro de la venta a modificar: "))
                    break
                except ValueError:
                    print("Error. Debe ingresar un número entero")

            # Y este es un caso a prueba de chistosos o distraídos.
            if idx < 0 or idx > len(listado) - 1:
                raise CapturadorExcepciones("Debe ingresar un número de registro válido")

            print("\nIngrese los nuevos datos de la venta")
            venta = VentaModel(obtener_fecha(),
                               obtener_articulo(),
                               obtener_vendedor(),
                               obtener_sucursal(),
                               obtener_importe())

            if click.confirm(f"\n¿Confirma la modificación?"):
                self.venta_mpp.update(venta, idx)
                print(f"\nModificado > " + color(f"{venta}", fg="yellow"))
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")

        except Exception as e:
            raise CapturadorExcepciones("Error al modificar la venta", *e.args)
