# -*- coding: cp1252 -*-

'''
Escribir una función que aplique un descuento a un precio y otra que aplique el
IVA a un precio. Escribir una tercera función que reciba un diccionario con los
precios y porcentajes de una cesta de la compra, y una de las funciones
anteriores, y utilice la función pasada para aplicar los descuentos o el IVA a
los productos de la cesta y devolver el precio final de la cesta.
'''

# Total precios: 1500
# Total descuentos: 150
# Total IVA: 300


diccionario = {
    'producto1': {'precio': 100,
                  'descuento': 10,
                  'iva': 20},
    'producto2': {'precio': 200,
                  'descuento': 10,
                  'iva': 20},
    'producto3': {'precio': 300,
                  'descuento': 10,
                  'iva': 20},
    'producto4': {'precio': 400,
                  'descuento': 10,
                  'iva': 20},
    'producto5': {'precio': 500,
                  'descuento': 10,
                  'iva': 20}}

descuento = lambda precio, porcentaje: precio * porcentaje / 100
iva = lambda precio, porcentaje: precio * porcentaje / 100

def cesta(diccionario, funcion):
    total = 0

    if (funcion == descuento):
        for key, producto in diccionario.items():
            total += funcion(producto['precio'], producto['descuento'])
        return total
    if (funcion == iva):
        for key, producto in diccionario.items():
            total += funcion(producto['precio'], producto['iva'])
        return total

def subtotal(diccionario):
    total = 0
    for key, producto in diccionario.items():
        total += producto['precio']
    return total

print("Total (sin IVA ni descuentos): ", subtotal(diccionario))
print("Total de descuentos: ", cesta(diccionario, descuento))
print("Total de IVA: ", cesta(diccionario, iva))
