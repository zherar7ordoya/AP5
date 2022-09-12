#!/usr/bin/env python

""" *------------------>= [DESCRIPCIÓN DE ESTE MÓDULO] <=----------------------*
This program is free software: you can redistribute it and/or modify it under
the terms of the GNU General Public License as published by the Free Software
Foundation, either version 3 of the License, or (at your option) any later
version.
"""
__author__ = "Gerardo Tordoya"
__date__ = "2022/09/12"

# *------------------------->= [Run Forest, run!] <=---------------------------*

#Para trabajar con fechas...
from datetime import datetime

class Terrestre:
    """Terrestre"""
    def desplazar(self):
        """Desplazar"""
        print("El animal anda")

class Acuatico:
    """Acuatico"""
    def desplazar(self):
        """Desplazar"""
        print("El animal nada")

class Cocodrilo(Terrestre, Acuatico):
    """Cocodrilo"""
    #pass

c = Cocodrilo()
c.desplazar()

#Salida -> El animal anda

print(issubclass(Terrestre, Cocodrilo)) #False
print(issubclass(Cocodrilo, Acuatico)) #True


#Polimorfismo...

def frecuencias(secuencia):
    """ Calcula las frecuencias de aparición de los elementos de
        la secuencia recibida.
        Devuelve un diccionario con elementos: {valor: frecuencia}
    """
    # crea un diccionario vacío
    frec = dict()
    # recorre la secuencia
    for elemento in secuencia:
        frec[elemento] = frec.get(elemento, 0) + 1
    return frec

numeros = frecuencias([2,4,5,7,3,2])
print(numeros)
nombres = frecuencias(["pedro","juan","pedro","tito","pedro","juan"])
print(nombres)

#Con clases
class Leon:
    """Leon"""
    def desplazar(self):
        """Desplazar"""
        print("Avanzo en 4 patas...")

class Bicicleta():
    """Bicicleta"""
    def desplazar(self):
        """Desplazar"""
        print("Avanzo en 2 ruedas...")

leon = Leon()
#leon.desplazar()

bicicleta = Bicicleta()
#bicicleta.desplazar()

def mover(obj): # No sé, no me gusta... el original era "object".
    """Mover"""
    obj.desplazar()

mover(leon)
mover(bicicleta)

#Sobrecarga métodos
class Persona():
    """def mensaje(self, mensaje):"""
    def __init__(self):
        print("Construyo Persona")

    def mensaje(self):
        """Mensaje"""
        print("mensaje desde la clase Persona")

class Obrero(Persona):
    """def mensaje(self, mensaje):"""
    def __init__(self, horas):
        super().__init__()
        print("Construyo Obrero")
        self.__horas_trabajo = horas
    def mensaje(self):
        print("mensaje desde la clase Obrero", self.__horas_trabajo)

obrero_planta = Obrero(40)
obrero_planta.mensaje()

obrero_planta.__class__ = Persona #Trato al obrero como una persona
obrero_planta.mensaje()

#Trato nuevamente como obrero al objeto conservando el estado del objeto
obrero_planta.__class__ = Obrero
obrero_planta.mensaje()


#Sobrecarga de operadores
class Punto:
    """def __str__(self):"""
    def __init__(self, xth = 0, yth = 0):
        self.xth = xth
        self.yth = yth
    def __add__(self, other): #Sobrecarga de método de suma
        xth = self.xth + other.xth
        yth = self.yth + other.yth
        return xth, yth

punto1 = Punto(4, 6)
punto2 = Punto(1, -2)
print (punto1 + punto2)

#Usando type para una clase
print(type(Persona))
print(type(str))

#Usando type para un objeto
PER = "test"
persona1 = Persona()

print(type(PER))
print(type(persona1))


# new VERSUS init
class Ath():
    """DOCSTRING!"""
    def __new__(cls):
        print ("Correcto...") # A.__new__ es llamado
        return super(Ath, cls).__new__(cls)

    def __init__(self): #Init nuno puede devolver nada, salvo un None
        print ("A.__init__ es llamado")
        #return 33

a = Ath()

#Singleton

class SoyUnico():
    """SoyUnico"""
    __instance = None
    nombre = None

    def __str__(self):
        return self.nombre

    def __new__(cls):
        if SoyUnico.__instance is None:
            SoyUnico.__instance = object.__new__(cls)
        return SoyUnico.__instance

ricardo = SoyUnico()
ricardo.nombre = "Ramon Valdes"
print(ricardo)
ramon = SoyUnico()
ramon.nombre = "Roberto Gomez"
print(ramon)
print(ricardo)
print(ramon)


#Duck typing

class Bird:
    """Bird"""
    def fly(self):
        """Fly"""
        print("fly with wings")

class Airplane:
    """Airplane"""
    def fly(self):
        """Fly"""
        print("fly with fuel")

class Fish:
    """Fish"""
    def swim(self):
        """Swim"""
        print("fish swim in sea")

# Atributos con el mismo nombre
# se consideran como duck typing
#for obj in Bird(), Airplane(), Fish():
    #obj.fly() #En Fish daría excepción

#Ordenamiento - Ejemplos y objetos
a = [7, -1, 5, 3]
b = sorted(a)
print(a)
print(b)

frutas = ['pera', 'Manzana', 'banana']
frutas.sort()
print(frutas)
frutas.sort(key = str.lower)
print(frutas)

planetas = ['mercurio', 'venus', 'tierra', 'marte']
planetas.sort(reverse= True)
print(planetas)




class Factura:
    """Factura"""
    def __init__(self, nro, fecha):
        self.__nro = nro
        self.__fecha = fecha

    def get_fecha(self):
        """get_fecha"""
        return self.__fecha

    def set_fecha(self, fecha):
        """set_fecha"""
        self.__fecha = fecha

    def get_nro(self):
        """get_nro"""
        return self.__nro

    def set_nro(self, nro):
        """set_nro"""
        self.__nro = nro

    nro = property(get_nro, set_nro)
    fecha = property(get_fecha, set_fecha)

f1 = Factura(1, datetime(2019, 1, 1))
f2 = Factura(8, datetime(2019, 1, 5))
f3 = Factura(9, datetime(2019, 1, 2))
f4 = Factura(2, datetime(2019, 1, 9))

lista_facturas = [f1, f2, f3, f4]


facturas_ordenada_nro = sorted(lista_facturas, key=lambda objeto: objeto.nro)
print("Ordenamiento por nro:")
for s in facturas_ordenada_nro:
    print(s.nro, s.fecha)

facturas_ordenada_fecha = sorted(lista_facturas, key=lambda objeto: objeto.fecha)
print("Ordenamiento por fecha:")
for s in facturas_ordenada_fecha:
    print(s.nro, s.fecha)
