"""
Archivo original
"""

# Comentario corto

l = [22, True, "una lista", [1, 2]]

print(l[0])
print(l[3][0])

mi_var = [99, True, "una lista", [1, 2]]
mi_var = l[0:2] # mi_var vale [99, True]
mi_var = l[0:85:2] # mi_var vale [99, “una lista”]
print(mi_var)

l = [99, True, "una lista"]
mi_var = l[1:] # mi_var vale [True, “una lista”]

mi_var = l[:2] # mi_var vale [99, True]
mi_var = l[:] # mi_var vale [99, True, “una lista”]
mi_var = l[::2] # mi_var vale [99, “una lista”]

mi_var.append("Elemento nuevo")
print(mi_var)
print(mi_var.count(99))

a = (2,3) #Tupla
mi_var.extend(a) #Pasa como lista


print(mi_var)
mi_var.insert(4, True)
print(mi_var)
mi_var.pop(4) #Remove Por posición
print(mi_var)
mi_var.remove("Elemento nuevo") #Remove objeto
print(mi_var)
mi_var.reverse() #Invertir la lista
print(mi_var)
orden = ['e', 'a', 'u', 'o', 'i'] 
orden.sort() #reverse=True para ordenar de mayor a menor
otro = orden
print(otro)
print(orden)

c = "hola mundo"
c[0] # h
c[5:] # mundo
c[::3] # hauo

t = (1, 2, True, "python")

print(t[0])

d = {"Love Actually": "Richard Curtis",
     "Kill Bill": "Tarantino",
    "Amélie": "Jean-Pierre Jeunet"}

print(d)

print(d["Love Actually"])

materias = {} #Declaro un diccionario vacío
materias["lunes"] = ["física", "matemática"]
materias["martes"] = ["lengua"]
materias["miércoles"] = ["sistemas"]
materias["jueves"] = []
materias["viernes"] = ["arte"]

print(materias)
print(materias["lunes"][0]) #materias como diccionario y luego como lista...


diccionario = {"clave": "valor"}

print(diccionario["clave"])
print(diccionario.get("clave", ["no encontrado"])) #Opción de agregar un valor si no se encuentra la clave

#print(diccionario.has_key("clave")) #Reemplazada en python 3 por
print('clave' in diccionario)

print(diccionario.items()) #Todo los items del diccionaio
print(diccionario.keys()) #Todas las claves
print(diccionario.values()) #Todos los valores

print(diccionario.pop("clave")) #Muestro y lo quito 
print(diccionario.items())
