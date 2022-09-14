// #!/usr/bin/env python
//
// """ *------------------>= [DESCRIPCI�N DE ESTE M�DULO] <=----------------------*
// Ejercicio del banco (usando estructurada).
// Archivos consultados:
//						Menu.psc
//						Mayores.psc
//						Subprocesos.psc
// """
// __author__ = "Gerardo Tordoya"
// __date__ = "2022-09-XX"
//
// # *------------------------->= [Run Forest, run!] <=---------------------------*

Algoritmo OperativaBancaria
	
	// GLOBALES
	Dimension clientes[2]
	Dimension cuentas[4]
	
	Repetir
		
		Escribir "Operatoria Bancaria"
		Escribir "-------------------"
		Escribir  "Seleccione una opci�n:"
		Escribir "1) Alta de Cliente"
		Escribir "2) Baja de Cliente"
		Escribir "3) Modificaci�n de Cliente"
		Escribir "4) Alta de Cuenta"
		Escribir "5) Baja de Cuenta"
		Escribir "6) Modificaci�n de Cuenta"
		Escribir "7) Realizar Dep�sito"
		Escribir "8) Realizar Retiro"
		Escribir "9) Realizar Transferencia"
		Escribir "10) Salir"
		
		Leer operacion
		
		Segun operacion Hacer
			1:
				// Alta de Cliente
				AltaCliente(clientes)
			2:
				// Baja de Cliente
			3:
				// Modificaci�n de Cliente
			4:
				// Alta de Cuenta
			5:
				// Baja de Cuenta
			6:
				// Modificaci�n de Cuenta
			7:
				// Realizar Dep�sito
			8:
				// Realizar Retiro
			9:
				// Realizar Transferencia
			10:
				// Salir
				Escribir "Gracias y vuelva pronto."
				Escribir "Saliendo..."
				Escribir "Ahora puede cerrar esta ventana."
			De Otro Modo:
				Escribir "Ingrese una opci�n v�lida"
		Fin Segun
		
	Hasta Que operacion == 10
	
FinAlgoritmo

// """ *------------------------>= [PROCEDIMIENTOS] <=----------------------------*

// CLIENTES

Funcion AltaCliente(clientes)
	Para i <- 0 Hasta 1 Hacer
		Escribir "Ingrese nombre del cliente ", i, ": "
		Leer clientes[i]
		Escribir "Cliente ingresado con c�digo ", i
	FinPara
FinFuncion

Funcion BajaCliente
	Escribir "Hola mundo!"
FinFuncion

Funcion ModificacionCliente
	Escribir "Hola mundo!"
FinFuncion

// CUENTAS

Funcion AltaCuenta(cuentas)
	Para i <- 0 Hasta 1 Hacer
		Escribir "Ingrese nombre del cliente ", i, ": "
		Leer cuentas[i]
		Escribir "Cliente ingresado con c�digo ", i
	FinPara
FinFuncion

Funcion BajaCuenta
	Escribir "Hola mundo!"
FinFuncion

Funcion ModificacionCuenta
	Escribir "Hola mundo!"
FinFuncion

// OPERACIONES

Funcion Depositar
	Escribir "Hola mundo!"
FinFuncion

Funcion Retirar
	Escribir "Hola mundo!"
FinFuncion

Funcion Transferir
	Escribir "Hola mundo!"
FinFuncion

// MOSTRAR TODO

Funcion MostrarTodo
	
FinFuncion
	