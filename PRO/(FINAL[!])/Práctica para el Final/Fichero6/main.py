# -*- coding: cp1252 -*-

'''
Escribir un programa para gestionar un list�n telef�nico con los nombres y los
tel�fonos de los clientes de una empresa. El programa incorporar funciones
crear el fichero con el list�n si no existe, para consultar el tel�fono de un
cliente, a�adir el tel�fono de un nuevo cliente y eliminar el tel�fono de un
cliente. El list�n debe estar guardado en el fichero de texto listin.txt donde
el nombre del cliente y su tel�fono deben aparecer separados por comas y cada
cliente en una l�nea distinta.
'''

import os

def crear_archivo():
    if not os.path.exists("listin.txt"):
        fichero = open("listin.txt", "w")
        fichero.close()

def consultar_telefono():
    fichero = open("listin.txt", "r")
    nombre = input("Nombre del cliente: ")
    for linea in fichero:
        if nombre in linea:
            print ("El telefono de", nombre, "es", linea.split(",")[1])
    fichero.close()

def a�adir_telefono():
    fichero = open("listin.txt", "a")
    nombre = input("Nombre del cliente: ")
    telefono = input("Telefono del cliente: ")
    fichero.write(nombre + "," + telefono)

def eliminar_telefono():
    fichero = open("listin.txt", "r")
    nombre = input("Nombre del cliente: ")
    for linea in fichero:
        if nombre in linea:
            fichero = open("listin.txt", "w")
            fichero.write(linea.replace(nombre + "," + linea.split(",")[1], ""))
    fichero.close()
    
def menu():
    print ("1. Consultar telefono")
    print ("2. Anadir telefono")
    print ("3. Eliminar telefono")
    print ("4. Salir")
    opcion = int(input("Opcion: "))
    return opcion

def main():
    crear_archivo()
    opcion = menu()
    while opcion != 4:
        if opcion == 1:
            consultar_telefono()
        elif opcion == 2:
            a�adir_telefono()
        elif opcion == 3:
            eliminar_telefono()
        opcion = menu()

main()
