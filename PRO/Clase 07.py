#Función de orden superior
def saludar(idioma):
    def saludar_es():
        print("Hola")

    def saludar_en():
        print("Hello")

    def saludar_fr():
        print("Salut")

    lang_func = {"es": saludar_es,  # Diccionario que contiene cada idioma y con su función referenciada
                 "en": saludar_en,
                 "fr": saludar_fr}
    return lang_func[idioma]

#f es una variable que contiene una función retornada por saludar.
f = saludar("es")
f()
#O directamente...
saludar("fr")()


#Map
def cuadrado(n):
    return n ** 2

l = [1, 2, 3]
cuadrados = map(cuadrado, l)

for numero in cuadrados:
    print(numero)

#filter

def es_par(n):
    return (n % 2.0 == 0)

l = [1, 2, 3]
l2 = filter(es_par, l)

for numero in l2:
    print("Es par: ", numero)


#reduce
from functools import reduce

def sumar(x, y):
    return x + y

l = [1, 2, 3]
suma = reduce(sumar, l)   

print("Suma: ", suma)


#función lambda
l = [1, 2, 3, 4]
pares = filter(lambda n: n % 2.0 == 0, l)

for numero in pares:
    print("Es par: ", numero)

#función lambda con clases
class Persona:

    def __init__(self, nombre, edad):
        self.__nombre = nombre
        self.__edad = edad

    def setNombre(self, nombre):
        self.__nombre = nombre
    
    def getNombre(self):
        return self.__nombre

    nombre = property(getNombre, setNombre)

    def setEdad(self, edad):
        self.__edad = edad
    
    def getEdad(self):
        return self.__edad

    edad = property(getEdad, setEdad)

    def __str__(self):
        return "{} de {} años".format(self.nombre, self.edad)
       

personas = [
    Persona("Juan", 35),
    Persona("Marta", 16),
    Persona("Manuel", 78),
    Persona("Eduardo", 12)
]

personas = map(lambda p: Persona(p.nombre, p.edad+1), personas)

for persona in personas:
    print(persona)

    