#!/usr/bin/python

print ("EJERCICIO 1")

def sumar(x, y):
	return x + y

respuesta = sumar(2, 3)
print(respuesta)

print ("===========")
print ("EJERCICIO 2")

def sumar2lecturas():
	a = eval(input("1er número: "))
	b = eval(input("2do número: "))
	print("Total: ", a + b)

sumar2lecturas()

print ("===========")
print ("EJERCICIO 3")

def maximo(a, b):
	if (a > b):
		return a
	elif (a < b):
		return b
	else:
		return "Son iguales"

respuesta = maximo(5, 5)
print(respuesta)

print ("===========")
print ("EJERCICIO 4")

def signo(a):
	if (a>0):
		return 1
	elif (a<0):
		return -1
	else:
		return 0

respuesta = signo(5)
print(respuesta)

print ("===========")
print ("EJERCICIO 5")

def sumaImpares(n):
	acumulador = 0
	for x in range(n * 2):
		if (x % 2) != 0: acumulador += x
	return acumulador

a = eval(input("Cantidad nros: "))
respuesta = sumaImpares(int(a))
print(respuesta)

print ("===========")
print ("EJERCICIO 6")

def mayorExponente(a, n):
	k = 0
	while(n % a == 0):
		n = n / a
		k += 1
	return k

respuesta = mayorExponente(2, 40)
print(respuesta)

print ("===========")
print ("EJERCICIO 7")

def factorial(n):
	resultado = 1
	for x in range(1, n + 1):
		resultado *= x
	return resultado

respuesta = factorial(4)
print(respuesta)

print ("===========")
print ("EJERCICIO 8")

def suma(xs):
	r = 0
	for x in xs:
		r += x
	return r

respuesta = suma([3, 2, 5])
print(respuesta)

print ("===========")
print ("EJERCICIO 9")

def fact(n):
	"""Función que calcula un factorial mediante recursividad.
	n: Cantidad de números
	retorno: El factorial calculado."""
	if n == 0:
		return 1
	else:
		return n * fact(n - 1)

respuesta = fact(4)
print(respuesta)