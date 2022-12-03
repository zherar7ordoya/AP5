import click

from colors import color

from BEL.articulo_model import ArticuloModel
from BLL.compartido import Compartido
from MPP.articulo_mapper import ArticuloMapper
from EHL.handler_logger import CapturadorExcepciones
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
                print(f"\nIngresado > " + color(f"{articulo}", fg="yellow"))
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")
        except Exception as e:
            raise CapturadorExcepciones("Error al dar de alta", *e.args)

    def baja(self):
        try:
            print("BAJA DE ARTÍCULO\n================\n")

            listado = self.articulo_mpp.leer()
            idx = obtener_idx(listado)

            print(color(f"\nADVERTENCIA:\n"
                        f"Esta operación también eliminará los registros asociados de Ventas", fg='red'))

            if click.confirm(f"\n¿Confirma la baja?\n"):
                self.articulo_mpp.delete(idx)
                print(f"\nArtículo eliminado > " + color(f"{listado[idx]}", fg="yellow"))
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")
        except Exception as e:
            raise CapturadorExcepciones("Error al dar la baja", *e.args)

    def modificacion(self):
        try:
            print("MODIFICACIÓN DE ARTÍCULO\n========================\n")

            listado = self.articulo_mpp.leer()
            idx = Compartido.obtener_idx(listado)

            codigo = listado[idx][0]
            descripcion = obtener_descripcion()
            stock = obtener_stock()
            articulo = ArticuloModel(codigo, descripcion, stock)

            if click.confirm(f"\n¿Confirma la modificación?"):
                self.articulo_mpp.update(articulo, idx)
                print(f"\nModificado > " + color(f"{articulo}", fg="yellow"))
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")
        except Exception as e:
            raise CapturadorExcepciones("Error al modificar", *e.args)
