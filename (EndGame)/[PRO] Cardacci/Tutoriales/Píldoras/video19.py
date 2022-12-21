# =======================================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-27
# Description: Generadores
#              Video 19
#              https://youtu.be/TLVnoqXGWpY
# =======================================================================

# def generar_pares(limite):
#     numero = 1
#     lista = []
#
#     while numero < limite:
#         lista.append(numero * 2)
#         numero += 1
#     return lista

def generar_pares(limite):
    numero = 1

    while numero < limite:
        yield numero * 2
        numero += 1


# A ver...

# print(generar_pares(10))

lista = generar_pares(10)

# for i in lista:
#     print(i)

print(next(lista))
print(next(lista))
print(next(lista))
