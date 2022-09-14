Algoritmo detarea
	Definir contador, respuesta Como Entero
	Definir contraseña Como Caracter
	Escribir lista_de_expresiones
	saldo = 1000
	contador = 1
	Mientras contador <= 3 Hacer
		Escribir "Escribe la contraseña"
		leer contraseña
		
		si contraseña == "abc" Entonces
			contador = 4
			respuesta = 0
			Mientras respuesta <> 4 Hacer
				Escribir "1: = Consultar saldo"
				Escribir "2: = Ingresar saldo"
				Escribir "3: = Retirar saldo"
				Escribir "4: = Salir"
				leer respuesta
				
				segun respuesta hacer
					1: 
						Escribir "Tu saldo actual es: $",saldo
					2:
						Escribir "Ingresa la cantidad a depositar"
						leer deposito
						saldo = saldo + deposito
						Escribir "Tu saldo actual es es: $",saldo
					3:
						Escribir "Ingresa la cantidad a retirar"
						leer retiro
						si retiro > saldo Entonces
							Escribir "La cantidad supera el saldo"
							Escribir "Tu saldo actual es: $",saldo
						SiNo
							saldo = saldo - retiro
							Escribir "Tu saldo actual es: $",saldo
						FinSi
				FinSegun
			FinMientras
		SiNo
			contador = contador + 1
			si contador == 4 Entonces
				Escribir "Has fallado los 3 intentos"
			SiNo
				Escribir "La contraseÃ±a es incorrecta"
			FinSi
		FinSi
	FinMientras  
FinAlgoritmo
