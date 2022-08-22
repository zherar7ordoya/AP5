print ("Hola Mundo") #Comentario

a = 8
b= "Hello"
c= True

#Formateo de salida...
print("Concatenando "+ str(a) + " " + b + " " + str(c)) #Obligatorio hacer cast a string
print("Concatenando",a,b,c)
print("Concatenando %s %s %s" % (a,b,c))

my_string = "Concatenando {} {} {}"
print(my_string.format(a,b,c))

print(f"Concatenando {a} {b} {c} ") #Sugerida...


m = 10
if m > 25:
    print("m es mayor que", 25)    
elif m == 10:
    print("m vale 10")
else:
    print("m es menor que", 25)


#Solicitud de datos al usuario...
num = eval(input("Ingrese un número: "))

while num != 0:

    if num > 10:
        print("Mayor que 10")
    else:
        print("Menor que 10")

    num = float(input("Enter a number: "))
    
cadena = "Curso de python"

for n in cadena:
    print(n)

l = [22, True, "una lista", [1, 2]]

print(l[0])
print(l[3][0])

l = [99, True, "una lista", [1, 2]]
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
print(orden)


c = "hola mundo"
c[0] # hs
c[5:] # mundo
c[::3] # hauo

t = (1, 2, True, "python")

print(t[0])

d = {"Love Actually": "Richard Curtis",
     "Kill Bill": "Tarantino",
    "Amélie": "Jean-Pierre Jeunet"}

print(d)

print(d["Love Actually"])


var = "par" if (num % 2 == 0) else "impar"
print(var)

secuencia = ["uno", "dos", "tres"]
for elemento in secuencia:
    print (elemento)

for i in range(5,10):
    print(i)


def sumar(num1:int, num2:int) -> int:
    """Función que retorna la suma de dos enteros...
    num1: Sumando 1
    num2: Sumando 2
    retorno: Total de tipo entero """    
    return num1 + num2
    

print("La suma calculada es: ", sumar(4,6))

while True:
    entrada = input("Ingrese un mensaje de esperanza...") 
    if entrada == "adios":
        break 
    else: 
        print (entrada)

#Tuplas de un elemento llevan la coma al final
t = (1,)
print(type(t)) 

#Prueba de Takeuchi
import time

def tak(x,y,z):
    if x <= y:
        return y
    else:
        return tak(tak(x-1,y,z),
                   tak(y-1,z,x),
                   tak(z-1,x,y))
#Probamos...

t_inicial = time.time()
tak(11,6,1)
t_final = time.time() - t_inicial
print(f"Tiempo {t_final} en segundos")

#Testear...
"""tak(12,6,1)
tak(13,6,1)
tak(14,6,1)"""


diccionario = {"clave": "valor"}

"""materias = {}
materias["lunes"] = [6103, 7540]
materias["martes"] = [6201]
materias["miércoles"] = [6103, 7540]
materias["jueves"] = []
materias["viernes"] = [6201]"""

print(diccionario["clave"])
print(diccionario.get("clave", ["no encontrado"]))

#print(diccionario.has_key("clave")) #Reemplazada en python 3 por
print('clave' in diccionario)

print(diccionario.items())
print(diccionario.keys())
print(diccionario.values())

print(diccionario.pop("clave")) #Muestro y lo quito 
print(diccionario.items())