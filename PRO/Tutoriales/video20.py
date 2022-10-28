# =========================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-28
# Description: Generadores
#              Video 20
#              https://youtu.be/ucaHqGII350
# =========================================

# USO DE YIELD FROM:

def devolver_ciudades(*ciudades):
    for ciudad in ciudades:
        # yield ciudad
        yield from ciudad


ciudades_devueltas = devolver_ciudades("Madrid", "Barcelona", "Bilbao", "Valencia")
print(next(ciudades_devueltas))
print(next(ciudades_devueltas))
print(next(ciudades_devueltas))
print(next(ciudades_devueltas))
print(next(ciudades_devueltas))
print(next(ciudades_devueltas))
