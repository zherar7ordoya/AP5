f = open("archivo.txt", "r") #Abro el archivo para la lectura

completo = f.read() #Leo el texto completo
print(completo)
f.seek(0) #Vuelvo a posicionarme en el primer lugar del archivo...
completo = f.readlines()
print(completo)

print(f.tell()) #Indica la posición del puntero en el archivo
f.seek(0) 

#parte = f2.read(512) #Si quisiera leer n cantidad de caracteres

while True:
    linea = f.readline() #Línea a
    if not linea: break
    print (linea)

f = open("archivo.txt", "a") #Abro el archivo para agregar información
f.write("\nquinta linea")
f.close()
  


archivo = "archivo2.txt"
while True: #Creamos un bucle infinito
    try: #Intentamos abrirlo
        with open (archivo, "r+") as f: #Abrimos utilizando Reescribir (r+) #with evita el close [using de C#]
            contenido = f.read()  #<-Lo abrimos utilizando el método read
            print (contenido)
            break
    except:
        print("Error al intentar abrir")
        print ("No se encuentra el archivo",archivo, "Especifique su nombre correctamente:")
        archivo = (input("Nombre de archivo:"))

