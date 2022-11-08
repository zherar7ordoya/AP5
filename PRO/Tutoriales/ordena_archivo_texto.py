# =======================================
# Author:      Gerardo Tordoya
# Create date: 2022-11-05
# Description: Ordena un archivo de texto
# =======================================

import csv


# Abro, leo, ordeno y guardo el archivo
def procesar_archivo(txt):
    with open(txt) as dat:
        lista = list(csv.reader(dat))
        ordenar_archivo(lista)
    with open(txt, 'w', newline='\n') as dat:
        csv.writer(dat).writerows(lista)


# Ordenamiento por Selección (Selection Sort)
def ordenar_archivo(lista):
    for idx in range(len(lista)):
        evaluado = idx
        for x in range(idx + 1, len(lista)):
            if lista[evaluado] > lista[x]:
                evaluado = x
        lista[idx], lista[evaluado] = lista[evaluado], lista[idx]


# --- MAIN --------------------------------------------------------------------

# Defino los archivos y los proceso (abro, leo, ordeno, escribo)
archivos = ['archivo1.csv', 'archivo2.csv', 'archivo3.csv']

try:
    for archivo in archivos:
        procesar_archivo(archivo)
except FileNotFoundError:
    print('No se encontró el archivo')
