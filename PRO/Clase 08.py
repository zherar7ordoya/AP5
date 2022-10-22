l = [0, 1, 2, 3]
l2 = [n ** 2 for n in l] #Comprensión de listas
print(l2) 

l2 = (n ** 2 for n in l) #Generador
print(l2) 

l = [0, 1, 2, 3] #Comprensión de listas
m = ["a", "b"] 
n = [s * v for s in m 
        for v in l 
	    if v > 0]

print(n)

def mi_generador(n, m, s):
    while(n <= m):
        yield n
        n += s

for n in mi_generador(0, 5, 1):
    print (n)

lista = list(mi_generador(0,5,1))   
print(lista)

#Decoradores
def mi_decorador(funcion):
    def nueva(*args):
        print ("Llamada a la funcion"), funcion.__name__
        retorno = funcion(*args)
        return retorno
    return nueva

@mi_decorador #mi_decorador(imp)("hola") #Da el mismo resultado...
def imp(s):
    print(s)

imp("Hola")


#Si quisiéramos aplicar más de un decorador bastaría añadir una nueva
#línea con el nuevo decorador. Es importante advertir que los decoradores 
# se ejecutarán de abajo hacia arriba
# @otro_decorador
# @mi_decorador
# def imp(s):
#     print (s)



