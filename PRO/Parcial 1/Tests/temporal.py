"""
HERRAMIENTA CSV
"""

import pandas
df = pandas.read_csv('hrdata.csv')
print(df)

print("\n ======================================= \n")
print("\n ELIGIENDO INDEX / CONVIRTIENDO A FECHAS \n")

df = pandas.read_csv('hrdata.csv', index_col='Name', parse_dates=['Hire Date'])
print(df)

print("\n ======================================= \n")
print("\n ESCRIBIENDO A ARCHIVO \n")

df = pandas.read_csv('hrdata.csv',
            index_col='Employee',
            parse_dates=['Hired'],
            header=0,
            names=['Employee', 'Hired', 'Salary', 'Sick Days'])


print("\n ======================================= \n")
print("\n AGREGAR UNA FILA AL DATAFRAME \n")

# Agrega una fila al final del dataframe
#df.loc[len(df.index)] = ['Gerardo Tordoya', '1972-08-26', 25000.01, 13]
#df.to_csv('hrdata_modified.csv')

print(len(df.columns))

registro = ['Gerardo Tordoya', '1972-08-26', '25000']

df.loc[len(df.index)] = registro  # type: ignore

df.to_csv('hrdata_modified.csv')

print(df)
