import random, math

class Perceptron:

    def __init__(self, input, learning_rate):
        """ input=Numero de entradas, learningRate = Tasa de aprendizaje"""
        self.weight = [random.uniform(-1,1) for n in range(input)] # Crea pesos aleatorios para cada entrada.
        self.bias = random.uniform(-1,1) # Crea un umbral aleatorio
        self.last_weight = self.weight # Guarda los ultimos pesos
        self.last_umbral = self.bias # Guarda el ultimo umbral
        print("Pesos Iniciales: "+str(self.weight))
        print("Umbral Inicial: "+str(self.bias))
        self.learning_rate = learning_rate # Indice de aprendizaje.
        
    def sum(self,input):
        output = self.bias # Añade el umbral
        for x in range(len(self.weight)):
            output += input[x] * self.weight[x] # Suma los productos(Entrada*Peso)
        return output; # Retorna los resultados.
    
    def sigmoide(self, x):
        """Función de activación"""
        return (1/(1+math.exp(-x))) # Funcion Sigmoide
    
    def output(self,input):
        """Aplico la sumatoria del input a la función de activación"""
        return self.sigmoide(self.sum(input)); # Devuelve el sigmoide de la sumatoria
    
    def learn(self, input, output):
        if len(self.last_weight) > 0: # Verifica si tiene datos de los últimos pesos
            error = output - self.output(input) # Identifica el error
            
            for x in range(len(self.weight)): 
                self.weight[x] = self.last_weight[x] + self.learning_rate * error * input[x] # Corrije el error de cada peso
            
            self.bias = self.last_umbral + self.learning_rate * error # Corrije el error del umbral.
            self.last_weight = self.weight # Guarda los ultimos pesos
            self.last_umbral = self.bias # Guarda el ultimo umbral
        else:
            self.last_weight = self.weight # Guarda los ultimos pesos
            self.last_umbral = self.bias # Guarda el ultimo umbral

    def redon(self, input): #// Esta funcion solo convierte las  salidas de enteros binarios osea 1 o 0.
        dict = {True : 1,
                False : 0 }

        return dict[input>0.5]

    def pulse(self, input):
        output = self.output(input) #LLamo a la función que hace el cálculo para la activación de la neurona...
        return self.redon(output)


#Datos iniciales
neurona = Perceptron(2,0.5) # Crea la neurona. 2 entradas, learningRate generalmente en 0.5

retorno_esperado = [0,1,1,0] #Salida esperada de la tabla AND/OR..etc.
steps = 1000 # Numero de etapas maximas.

#Tabla AND
inputs = ((0,0),
          (0,1),
          (1,0),
          (1,1),)

#Loop principal para el aprendizaje...
for x in range(steps):
    error = True  # Variable auxiliar para contar los errores
    print("\n>> Etapa: ", str(x+1))

    print("Entrada '0,0': Esperado: ", retorno_esperado[0],"; Objetivo: ", neurona.pulse(inputs[0]))
    print("Entrada '0,1': Esperado: ", retorno_esperado[1],"; Objetivo: ", neurona.pulse(inputs[1]))
    print("Entrada '1,0': Esperado: ", retorno_esperado[2],"; Objetivo: ", neurona.pulse(inputs[2]))
    print("Entrada '1,1': Esperado: ", retorno_esperado[3],"; Objetivo: ", neurona.pulse(inputs[3]))
       
    # Revisa si comete un error
    if neurona.pulse(inputs[0]) != retorno_esperado[0]:
        neurona.learn(inputs[0], retorno_esperado[0])  # Aprende
        error = False

    if neurona.pulse(inputs[1]) != retorno_esperado[1]:
        neurona.learn(inputs[1], retorno_esperado[1])  # Aprende
        error = False

    if neurona.pulse(inputs[2]) != retorno_esperado[2]:
        neurona.learn(inputs[2], retorno_esperado[2])  # Aprende
        error = False

    if neurona.pulse(inputs[3]) != retorno_esperado[3]:
        neurona.learn(inputs[3], retorno_esperado[3])  # Aprende
        error = False
        
    if error != False: # Si no hubo error: Para el aprendizaje.
        print("Datos Aprendidos")
        break

#Ya puedo usar la neurona...
print("Usando la neurona...")
print("[0,0] -> ", neurona.pulse((0,0)))
print("[0,1] -> ", neurona.pulse((0,1)))
print("[1,0] -> ", neurona.pulse((1,0)))
print("[1,1] -> ", neurona.pulse((1,1)))
