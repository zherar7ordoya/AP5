class Coche:

    marca = None  # Atributo de clase público
    __modelo = None  # Atributo de clase privado

    def __init__(self, gasolina): #Constructor
        self.__gasolina = gasolina
        print("Tenemos", gasolina, "litros")

    def __del__(self): #Destructor
        print ("Eliminando objeto...")

    @classmethod
    def set_modelo(cls, modelo):
        """Método de clase"""
        cls.__modelo = modelo

    def get_gasolina(self):
        """Método de instancia"""
        return self.__gasolina

    def set_gasolina(self, gasolina):
        """Método de instancia"""
        if gasolina > 0:
            self.__gasolina = gasolina
        else:
            print("No se puede cargar menos o igual a 0 de combustible")

    gasolina = property(get_gasolina, set_gasolina)

    def arrancar(self):
        """2.0"""
        if self.__gasolina > 0:
            print("Arranca")
        else:
            print("No arranca")

    def conducir(self):
        """2.0"""
        if self.__gasolina > 0:
            self.__gasolina -= 1
            print("Quedan", self.__gasolina, "litros")
        else:
            print("No se mueve")

    @classmethod
    def imprimir(cls):
        """Método de clase"""
        print("Yo soy un coche", cls.marca, "modelo", cls.__modelo)

    @staticmethod
    def funcion_sin_relacion_con_la_clase(origen, destino, kms):
        """Definimos el método"""
        print ("El automovil irá desde", origen, "hasta", destino, "recorriendo", kms, "kms")

auto1 = Coche(5) #Instancio un coche
Coche.marca = "Fiat" #Modifico atributo público de clase 
Coche.set_modelo("Argo") #Modifico atributo privado de clase (setter)
auto1.arrancar() #Arrancar el vehículo, método de instancia
auto1.conducir() #Conducir el vehículo, método de instancia
#auto1.set_gasolina(10)
auto1.set_gasolina(0) #Método setter tradicional
auto1.gasolina = 10 #Seteo por property
print(auto1.gasolina) #Traigo la gasolina por property
print(auto1.get_gasolina()) #Traigo la gasolina por getter tradicional
auto1.conducir()
auto1.conducir()
Coche.imprimir() #Método de clase -> LLamo directo a la clase
Coche.funcion_sin_relacion_con_la_clase("bs as", "rosario", 45) #Método estático -> Sin relación interna
del auto1 #Destruyo el objeto


auto2 = Coche(10)
del auto2


class Ejemplo:
    def publico_test(self):
        print("Público")

    def __privado_test(self):
        print("Privado")

ej = Ejemplo()

print([attr for attr in dir(ej) if 'test' in attr]) #dir() método que retorna métodos y atributos de cualquier objeto...

ej.publico_test()
ej._Ejemplo__privado_test()


#Agregación
class Salary:
    def __init__(self, pay):
        self.__pay=pay

    def get_total(self):
        return (self.__pay * 12)

class Employee:
    def __init__(self, pay, bonus):
        self.__pay=pay #Paso directamente el objeto Salario en el constructor
        self.__bonus=bonus
        #self.__obj_salary=Salary(self.__pay) 

    def annual_salary(self):
        return "Total: "  +  str(self.__pay.get_total() + self.__bonus)

obj_salary=Salary(100) #Creo el objeto salario
obj_emp=Employee(obj_salary, 10) #Lo paso como parámetro al constructor a Empleado
print (obj_emp.annual_salary())
