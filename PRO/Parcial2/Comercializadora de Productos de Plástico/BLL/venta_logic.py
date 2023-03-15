import click
from colors import color
from BLL.compartido import Compartido
from EHL.handler_logger import CapturadorExcepciones
from BEL.venta_model import VentaModel
from MPP.venta_mapper import VentaMapper


class VentaLogic(VentaMapper):

    def __init__(self):
        super().__init__()
        self.venta_mpp = VentaMapper()


    def alta(self):
        try:
            print("ALTA DE VENTA\n=============\n")

            venta = VentaModel(Compartido.obtener_fecha(),
                               Compartido.obtener_articulo(),
                               Compartido.obtener_vendedor(),
                               Compartido.obtener_sucursal(),
                               Compartido.obtener_importe())

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
            idx = Compartido.obtener_idx(listado)

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
            idx = Compartido.obtener_idx(listado)

            print("\nIngrese los nuevos datos de la venta")
            venta = VentaModel(Compartido.obtener_fecha(),
                               Compartido.obtener_articulo(),
                               Compartido.obtener_vendedor(),
                               Compartido.obtener_sucursal(),
                               Compartido.obtener_importe())

            if click.confirm(f"\n¿Confirma la modificación?"):
                self.venta_mpp.update(venta, idx)
                print(f"\nModificado > " + color(f"{venta}", fg="yellow"))
                input("\nOperación completada (presione una tecla para continuar)")
            else:
                input("\nOperación cancelada (presione una tecla para continuar)")

        except Exception as e:
            raise CapturadorExcepciones("Error al modificar la venta", *e.args)
