# -*- coding: cp1252 -*-

"""
Usando las cuatro estructuras de datos de Python (lista, tupla, conjunto y
diccionario), construir un ABM para cada una de ellas.
"""

lista = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
tupla = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10)
conjunto = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
diccionario = {
    1: "uno",
    2: "dos",
    3: "tres",
    4: "cuatro",
    5: "cinco",
    6: "seis",
    7: "siete",
    8: "ocho",
    9: "nueve",
    10: "diez",
}

def alta(estructura, elemento):
    try:
        if (type(estructura) is tuple):
            raise Exception("\nNo se puede agregar en una tupla\n")
    except Exception as e:
        print(e)
    else:
        if (type(estructura) is dict):
            dividido = elemento.split(",")
            clave = int(dividido[0])
            valor = dividido[1]
            estructura[clave] = valor
        elif (type(estructura) is set):
            estructura.add(elemento)
        else:
            estructura.append(elemento)


def baja(estructura, elemento):
    try:
        if (type(estructura) is tuple):
            raise Exception("\nNo se puede eliminar en una tupla\n")
    except Exception as e:
        print(e)
    else:
        if (type(estructura) is dict):
            del estructura[elemento]
        else:
            estructura.remove(elemento)


def modificacion(estructura, elemento, nuevo_elemento):
    try:
        if (type(estructura) is tuple):
            raise Exception("\nNo se puede modificar en una tupla\n")
        if (type(estructura) is set):
            raise Exception("\nNo se puede modificar en un conjunto\n")
    except Exception as e:
        print(e)
    else:
        if (type(estructura) is dict):
            estructura[elemento] = nuevo_elemento
        else:
            indice = estructura.index(elemento)
            estructura[indice] = nuevo_elemento
        

def consulta(estructura, elemento):
    if (type(estructura) is dict):
        return bool(estructura.get(elemento))
    elif elemento in estructura:
        return True
    else:
        return False


def main():
    print("\n 1) Alta en lista")
    print(" 2) Baja en lista")
    print(" 3) Modificación en lista")
    print(" 4) Consulta en lista")

    print("\n 5) Alta en tupla")
    print(" 6) Baja en tupla")
    print(" 7) Modificación en tupla")
    print(" 8) Consulta en tupla")

    print("\n 9) Alta en conjunto")
    print("10) Baja en conjunto")
    print("11) Modificación en conjunto")
    print("12) Consulta en conjunto")

    print("\n13) Alta en diccionario")
    print("14) Baja en diccionario")
    print("15) Modificación en diccionario")
    print("16) Consulta en diccionario")

    print("\n17) Salir")
    opcion = int(input("\nIngrese una opción: "))

    while opcion != 17:

        try:
            if opcion == 1:
                print("\nLista:", lista)
                alta(lista, int(input("Ingrese un elemento: ")))
                print("Lista:", lista)
            elif opcion == 2:
                print("\nLista:", lista)
                baja(lista, int(input("Ingrese un elemento: ")))
                print("Lista:", lista)
            elif opcion == 3:
                print("\nLista:", lista)
                modificacion(lista, int(input("Ingrese un elemento: ")), int(input("Ingrese un nuevo elemento: ")))
                print("Lista:", lista)
            elif opcion == 4:
                print("\nLista:", lista)
                print(consulta(lista, int(input("Ingrese un elemento: "))))

            elif opcion == 5:
                print("\nTupla:", tupla)
                alta(tupla, int(input("Ingrese un elemento: ")))
            elif opcion == 6:
                print("\nTupla:", tupla)
                baja(tupla, int(input("Ingrese un elemento: ")))
            elif opcion == 7:
                print("\nTupla:", tupla)
                modificacion(tupla, int(input("Ingrese un elemento: ")), int(input("Ingrese un nuevo elemento: ")))
            elif opcion == 8:
                print("\nTupla:", tupla)
                print(consulta(tupla, int(input("Ingrese un elemento: "))))

            elif opcion == 9:
                print("\nConjunto:", conjunto)
                alta(conjunto, int(input("Ingrese un elemento: ")))
                print("Conjunto:", conjunto)
            elif opcion == 10:
                print("\nConjunto:", conjunto)
                baja(conjunto, int(input("Ingrese un elemento: ")))
                print("Conjunto:", conjunto)
            elif opcion == 11:
                print("\nConjunto:", conjunto)
                modificacion(conjunto, int(input("Ingrese un elemento: ")), int(input("Ingrese un nuevo elemento: ")))
            elif opcion == 12:
                print("\nConjunto:", conjunto)
                print(consulta(conjunto, int(input("Ingrese un elemento: "))))

            elif opcion == 13:
                print("\nDiccionario:", diccionario)
                alta(diccionario, input("Ingrese un elemento [clave,valor]: "))
                print("Diccionario:", diccionario)
            elif opcion == 14:
                print("\nDiccionario:", diccionario)
                baja(diccionario, int(input("Ingrese un elemento [clave]: ")))
                print("Diccionario:", diccionario)
            elif opcion == 15:
                print("\nDiccionario:", diccionario)
                modificacion(diccionario, int(input("Ingrese un elemento [clave]: ")), input("Ingrese un nuevo elemento [valor]: "))
                print("Diccionario:", diccionario)
            elif opcion == 16:
                print("\nDiccionario:", diccionario)
                print(consulta(diccionario, int(input("Ingrese un elemento [clave]: "))))

            else:
                print("Opción incorrecta")
        except Exception as e:
            print(f"\n{e}\n")

        opcion = int(input("\nIngrese una opción: "))


if __name__ == "__main__":
    main()
