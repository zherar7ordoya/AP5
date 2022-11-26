from decimal import Decimal
from colorama import Fore
from BLL.articulo_logic import ArticuloLogic
from excepcion_capturada import RegistroSistematicoExcepciones
from venta_logic import VentaLogic


class ListadoLogic:
    def __init__(self):
        self.articulo_bll = ArticuloLogic()
        self.venta_bll = VentaLogic()

    def articulos(self):
        try:
            print("LISTADO DE ARTÍCULOS\n====================\n")
            listado = self.articulo_bll.leer()
            for idx, x in enumerate(listado):
                print(idx, x)
            input("\nOperación completada (presione una tecla para continuar)")
        except Exception as e:
            raise RegistroSistematicoExcepciones(*e.args, **e.kwargs)

    def ventas(self):
        try:
            print("LISTADO DE VENTAS\n=================\n")
            listado = self.venta_bll.leer()
            for idx, x in enumerate(listado):
                print(idx, x)
            input("\nOperación completada (presione una tecla para continuar)")
        except Exception as e:
            raise RegistroSistematicoExcepciones(*e.args, **e.kwargs)

    def sucursales(self):
        try:
            print("REPORTE DE SUCURSALES\n=====================\n")
            self.ordenar_archivo()
            self.imprimir_reporte()
            input("\nOperación completada (presione una tecla para continuar)")
        except Exception as e:
            raise RegistroSistematicoExcepciones(*e.args, **e.kwargs)

    def ordenar_archivo(self):
        # Leo el archivo de ventas
        listado = self.venta_bll.leer()

        # Ordeno por vendedor
        for idx in range(len(listado)):
            evaluado = idx
            for x in range(idx + 1, len(listado)):
                if listado[evaluado][2] > listado[x][2]:
                    evaluado = x
            listado[idx], listado[evaluado] = listado[evaluado], listado[idx]

        # Ordeno por artículo
        for idx in range(len(listado)):
            evaluado = idx
            for x in range(idx + 1, len(listado)):
                if listado[evaluado][1] > listado[x][1]:
                    evaluado = x
            listado[idx], listado[evaluado] = listado[evaluado], listado[idx]

        # Ordeno por sucursal
        for idx in range(len(listado)):
            evaluado = idx
            for x in range(idx + 1, len(listado)):
                if listado[evaluado][3] > listado[x][3]:
                    evaluado = x
            listado[idx], listado[evaluado] = listado[evaluado], listado[idx]

        # Guardo el archivo ordenado
        self.venta_bll.escribir(listado)

    def imprimir_reporte(self):

        # Leo el archivo de ventas
        listado = iter(self.venta_bll.leer())

        # Divido lectura por registros
        item = next(listado, None)

        # Bucle Total General (condición de salida: ítem es None)
        total_general = 0

        while item:
            sucursal, total_sucursal = item[3], 0
            print(f"{Fore.YELLOW}\nSucursal {sucursal}\n{Fore.RESET}")

            # Bucle Total Sucursal
            while item and item[3] == sucursal:
                articulo, total_articulo = item[1], 0
                print(f"{Fore.RED}\t{self.get_descripcion(articulo)}{Fore.RESET}")

                # Bucle Total Artículo
                while item and item[3] == sucursal and item[1] == articulo:
                    vendedor, total_vendedor = item[2], 0

                    # Bucle Total Vendedor
                    while item and item[3] == sucursal and item[1] == articulo and item[2] == vendedor:
                        total_vendedor += Decimal(item[4])
                        item = next(listado, None)

                    total_articulo += total_vendedor
                    print(f"\t\t{vendedor}:\t{total_vendedor}")

                total_sucursal += total_articulo
                # Muestro el código porque me desequilibra el reporte si muestro el nombre
                print(f"{Fore.RED}\t\t\tTotal {articulo}:\t{total_articulo}\n{Fore.RESET}")

            total_general += total_sucursal
            print(f"{Fore.YELLOW}\t\t\t\tTotal {sucursal}:\t{total_sucursal}{Fore.RESET}")

        print(f"{Fore.GREEN}\n\t\t\t\t\tTOTAL GENERAL:\t{total_general}{Fore.RESET}")

    def get_descripcion(self, codigo):
        try:
            listado = self.articulo_bll.leer()
            for idx, x in enumerate(listado):
                if x[0] == codigo:
                    return x[1]
        except Exception as e:
            raise RegistroSistematicoExcepciones(*e.args, **e.kwargs)
