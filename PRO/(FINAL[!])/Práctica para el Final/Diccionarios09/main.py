# -*- coding: cp1252 -*-

'''
Escribir un programa que gestione las facturas pendientes de cobro de una
empresa. Las facturas se almacenarán en un diccionario donde la clave de cada
factura será el número de factura y el valor el coste de la factura. El
programa debe preguntar al usuario si quiere añadir una nueva factura, pagar
una existente o terminar. Si desea añadir una nueva factura se preguntará por
el número de factura y su coste y se añadirá al diccionario. Si se desea pagar
una factura se preguntará por el número de factura y se eliminará del
diccionario. Después de cada operación el programa debe mostrar por pantalla la
cantidad cobrada hasta el momento y la cantidad pendiente de cobro.
'''

facturas = {}
cobrado = 0
pendiente = 0

while True:
    print("1. Añadir factura")
    print("2. Pagar factura")
    print("3. Salir")

    opcion = int(input("Elige una opción: "))

    if opcion == 1:
        numero = int(input("Introduce el número de la factura: "))
        coste = float(input("Introduce el coste de la factura: "))
        facturas[numero] = coste
        pendiente += coste
    if opcion == 2:
        numero = int(input("Introduce el número de la factura: "))
        if numero in facturas:
            coste = facturas.pop(numero)
            cobrado += coste
            pendiente -= coste
        else:
            print("No existe esa factura")
    if opcion == 3:
        break

    print("Cobrado: ", cobrado)
    print("Pendiente: ", pendiente)
