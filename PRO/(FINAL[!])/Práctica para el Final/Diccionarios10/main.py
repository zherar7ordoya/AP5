# -*- coding: cp1252 -*-

'''
Escribir un programa que permita gestionar la base de datos de clientes de una
empresa. Los clientes se guardarán en un diccionario en el que la clave de cada
cliente será su DNI, y el valor será otro diccionario con los datos del cliente:
nombre, dirección, teléfono, correo, preferente (donde tendrá el valor True si
si se trata de un cliente preferente). El programa debe preguntar al usuario por
una opción del siguiente menú:
(1) Añadir cliente,
(2) Eliminar cliente,
(3) Mostrar cliente,
(4) Listar todos los clientes,
(5) Listar clientes preferentes,
(6) Terminar.
En función de la opción elegida el programa tendrá que hacer lo siguiente:
(1) Preguntar los datos del cliente, crear un diccionario con los datos y
    añadirlo a la base de datos.
(2) Preguntar por el DNI del cliente y eliminar sus datos de la base de datos.
(3) Preguntar por el DNI del cliente y mostrar sus datos.
(4) Mostrar lista de todos los clientes de la base datos con su DNI y nombre.
(5) Mostrar la lista de clientes preferentes de la base de datos con su DNI y
    nombre.
(6) Terminar el programa.
'''

import json

def menu():
    print("\n1) Añadir cliente")
    print("2) Eliminar cliente")
    print("3) Mostrar cliente")
    print("4) Listar todos los clientes")
    print("5) Listar clientes preferentes")
    print("6) Terminar")
    opcion = int(input("\nIntroduzca una opcion: "))
    return opcion

def añadir_cliente(clientes):
    dni = input("Introduzca el DNI del cliente: ")
    nombre = input("Introduzca el nombre del cliente: ")
    direccion = input("Introduzca la direccion del cliente: ")
    telefono = input("Introduzca el telefono del cliente: ")
    correo = input("Introduzca el correo del cliente: ")

    preferente = input("Introduzca si es preferente [S]: ")
    if preferente == "S":
        preferente = True
    else:
        preferente = False

    clientes[dni] = {"nombre": nombre,
                     "direccion": direccion,
                     "telefono": telefono,
                     "correo": correo,
                     "preferente": preferente}

def eliminar_cliente(clientes):
    dni = input("Introduzca el DNI del cliente: ")
    del clientes[dni]

def mostrar_cliente(clientes):
    dni = input("Introduzca el DNI del cliente: ")
    print(clientes[dni])

def listar_clientes(clientes):
    for dni in clientes:
        print(dni, clientes[dni]["nombre"])

def listar_preferentes(clientes):
    for dni in clientes:
        if clientes[dni]["preferente"]:
            print(dni, clientes[dni]["nombre"])

def main():
    clientes = json.loads(open("clientes.json").read())
    opcion = menu()

    while opcion != 6:
        if opcion == 1:
            añadir_cliente(clientes)
        elif opcion == 2:
            eliminar_cliente(clientes)
        elif opcion == 3:
            mostrar_cliente(clientes)
        elif opcion == 4:
            listar_clientes(clientes)
        elif opcion == 5:
            listar_preferentes(clientes)
        else:
            print("Opcion incorrecta")
        opcion = menu()

if __name__ == "__main__":
    main()
