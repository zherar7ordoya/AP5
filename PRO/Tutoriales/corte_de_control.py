# =============================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-05
# Description: Corte de control (recorre un archivo de ventas e imprime totales
#              y subtotales)
# =============================================================================

import csv


# No estoy seguro si es necesario, pero lo dejo por las dudas
def leer_datos(datos):
    try:
        return datos.next()
    except:
        return None


def ventas_clientes_mes(archivo_ventas):
    """ Recorre un archivo csv, con la información almacenada en el
        formato: cliente,an"o,mes,día,venta """
    # Inicialización
    ventas = open(archivo_ventas)
    ventas_csv = csv.reader(ventas)

    # item = leer_datos(ventas_csv)
    item = next(ventas_csv, None)
    total = 0

    while item:
        # Inicialización para el bucle de cliente
        cliente = item[0]
        total_cliente = 0
        print("Cliente %s" % cliente)

        while item and item[0] == cliente:
            # Inicialización para el bucle de año
            anyo = item[1]
            total_anyo = 0
            print("\tAño: %s" % anyo)

            while item and item[0] == cliente and item[1] == anyo:
                mes, monto = item[2], float(item[3])
                print(f"\t\tVentas del mes {mes}: {monto}")
                total_anyo += monto
                # Siguiente registro
                # item = leer_datos(ventas_csv)
                item = next(ventas_csv, None)

            # Final del bucle de año
            print(f"\tTotal para el año {anyo}: {total_anyo}")
            total_cliente += total_anyo

        # Final del bucle de cliente
        print(f"Total para el cliente {cliente}: {total_cliente}\n")
        total += total_cliente

        # Final del bucle principal
        print("Total general: %.2f" % total)

    # Cierre del archivo
    ventas.close()


# with open('ventas.csv', newline='', encoding='utf-8') as f:
#     reader = csv.reader(f)
#     for row in reader:
#         print(row)

ventas_clientes_mes('ventas.csv')
