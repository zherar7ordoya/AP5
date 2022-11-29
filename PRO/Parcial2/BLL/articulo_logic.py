import click
from colorama import Fore

from consolemenu.prompt_utils import PromptUtils
from colors import color

from BEL.articulo_model import ArticuloModel
from MPP.articulo_mapper import ArticuloMapper
from EHL.handler_logger import RegistradorExcepciones
from BLL.validaciones import Valida


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


def obtener_descripcion():
    while True:
        descripcion = input("Ingrese la descripción del artículo: ")
        if Valida.valida_descripcion(descripcion):
            return descripcion
        else:
            print("La descripción ingresada no es válida. Debe ingresar 1 letra mayúscula + 3 letras o más")


def obtener_stock():
    while True:
        stock = input("Ingrese el stock del artículo: ")
        if Valida.valida_stock(stock):
            return stock
        else:
            print("El stock ingresado no es válido. Debe ingresar un número mayor a 0")


class ArticuloLogic(ArticuloMapper):

    def __init__(self):
        super().__init__()
        self.articulo_mpp = ArticuloMapper()

    def alta(self):
        try:
            print("ALTA DE ARTÍCULO\n================\n")
            codigo = obtener_codigo()
            descripcion = obtener_descripcion()
            stock = obtener_stock()

            articulo = ArticuloModel(codigo, descripcion, stock)

            if click.confirm(f"\n¿Confirma el alta?"):
                self.articulo_mpp.create(articulo)
                print(f"\nIngresado > {Fore.YELLOW}{articulo}{Fore.RESET}")
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")
        except Exception as e:
            raise RegistradorExcepciones("ERROR AL DAR DE ALTA", *e.args)

    def baja(self):
        try:
            print("BAJA DE ARTÍCULO\n================\n")

            listado = self.articulo_mpp.leer()

            for idx, x in enumerate(listado):
                print(idx, x)

            while True:
                try:
                    idx = int(input("\nIngrese el número de registro del artículo a eliminar: "))
                    break
                except ValueError:
                    print("Error. Debe ingresar un número entero")

            # Y este es un caso a prueba de chistosos o distraídos.
            if idx < 0 or idx > len(listado) - 1:
                raise RegistradorExcepciones("Debe ingresar un número de registro válido")

            print(
                f"\n{Fore.RED}ADVERTENCIA:"
                f"Esta operación también eliminará los registros asociados de Ventas{Fore.RESET}")

            if click.confirm(f"\n¿Confirma la baja?"):
                self.articulo_mpp.delete(idx)
                print(f"\nEliminado > {Fore.YELLOW}{listado[idx]}{Fore.RESET}")
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")
        except Exception as e:
            raise RegistradorExcepciones(*e.args)

    def modificacion(self):
        try:
            print("MODIFICACIÓN DE ARTÍCULO\n========================\n")

            listado = self.articulo_mpp.leer()

            for idx, x in enumerate(listado):
                print(idx, x)

            while True:
                try:
                    idx = int(input("\nIngrese el número de registro del artículo a modificar: "))
                    break
                except ValueError:
                    print("Error. Debe ingresar un número entero")

            # Y este es un caso a prueba de chistosos o distraídos.
            if idx < 0 or idx > len(listado) - 1:
                raise RegistradorExcepciones("Debe ingresar un número de registro válido")

            codigo = listado[idx][0]
            descripcion = obtener_descripcion()
            stock = obtener_stock()
            articulo = ArticuloModel(codigo, descripcion, stock)

            if click.confirm(f"\n¿Confirma la modificación?"):
                self.articulo_mpp.update(articulo, idx)
                print(f"\nModificado > {Fore.YELLOW}{articulo}{Fore.RESET}")
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")
        except Exception as e:
            raise RegistradorExcepciones(*e.args)
