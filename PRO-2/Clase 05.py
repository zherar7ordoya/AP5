class Instrumento:
    def __init__(self, precio):
        print("Contruyo Instrumento")
        self.__precio = precio        

    def tocar(self):
        print("Estamos tocando musica")

    def romper(self):
        print("Eso lo pagas tu")
        print("Son", self.__precio, "$$$")


class Bateria(Instrumento):
    def __init__(self, tipo_parche, precio):
        #super().__init__(precio)
        Instrumento.__init__(self, precio)
        print("Contruyo batería")
        self.__tipo_parche = tipo_parche  

    def golpear_palillos(self):
        print("Golpeando palillos")

class Guitarra(Instrumento):
    pass

instrumento = Instrumento(5000)
bateria = Bateria("Blando", 5000)

instrumento.tocar()
instrumento.romper()
bateria.tocar()
bateria.romper()

instrumento = bateria #Permitido
instrumento.romper()
instrumento.golpear_palillos() #golpear_palillos es de batería por lo tanto esto funciona...

instrumento2 = Instrumento(5000)
bateria_mana = Bateria("Duro", 10000)
bateria_mana = instrumento2 #Python me permite asignar un tipo padre a hijo...
#bateria_mana.golpear_palillos() #Pero...Esta línea daría error ya que golpear_palillos no es de instrumento

class AgregarElemento(list): #Creamos una clase Agregarelemento heredando atributos de clase list
    def append(self, alumno): #Definimos que el método append (de listas) añadirá el elemento alumno
        print ("Añadido el alumno", alumno) #Imprimimos el resultado del método
        super().append(alumno) #Incorporamos la función super SIN INDICAR LA CLASE ACTUAL, seguida
                                                    #del método append para la variable alumno
 
lista1 = AgregarElemento() #Definimos la clase de nuestra lista llamada "Lista1"
lista1.append ('Matias') #Añadimos un elemento a la lista como lo haríamos normalmente
lista1.append('Jorge') #Otro elemento...
print(lista1)  # Imprimimos la lista para corroborar los alumnos...

