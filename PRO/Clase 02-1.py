#!/usr/bin/python

print ("EJERCICIO 1")

def sumar(x, y):
	return x + y

sumar(2, 3)

print ("===========")
print ("EJERCICIO 2")

def sumar2lecturas():
	a = eval(input("1er número:"))
	b = eval(input("2do número:"))
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

maximo(5, 5)

print ("===========")
print ("EJERCICIO 4")

def signo(a):
	if (a>0):
		return 1
	elif (a<0):
		return -1
	else:
		return 0

signo(5)
signo(-5)
signo(0)

print ("===========")
print ("EJERCICIO 5")

