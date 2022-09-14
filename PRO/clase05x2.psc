// #!/usr/bin/env python
//
// """ *------------------>= [DESCRIPCIÓN DE ESTE MÓDULO] <=----------------------*
// Ejercicio del banco (usando estructurada).
// Archivos consultados:
//						Menu.psc
//						Mayores.psc
//						Subprocesos.psc
//						Sucursales.psc
// NOTA: Recordar configurar arreglos a base 0.
// """
// __author__ = "Gerardo Tordoya"
// __date__ = "2022-09-XX"
//
// # *------------------------->= [Run Forest, run!] <=---------------------------*

Proceso OperativaBancaria
	
	// GLOBALES
	Definir cliente Como Caracter
	Definir cuenta, cuentas Como Entero
	Dimension cuentas[2]
	
	// INICIALIZACIÓN
	Escribir ""
	Escribir "Ingrese su nombre (y apellido): " 
	Leer cliente
	cuenta <- 0
	cuentas[0] <- 0
	cuentas[1] <- 0
	
	DetallarCuenta(cliente, cuentas)
		
	Repetir
		
		Escribir "Operatoria Bancaria"
		Escribir "-------------------"
		Escribir  "Seleccione una opción:"
		Escribir "1) Alta de Cliente"
		Escribir "2) Baja de Cliente"
		Escribir "3) Modificación de Cliente"
		Escribir "4) Alta de Cuenta"
		Escribir "5) Baja de Cuenta"
		Escribir "6) Modificación de Cuenta"
		Escribir "7) Realizar Depósito"
		Escribir "8) Realizar Retiro"
		Escribir "9) Realizar Transferencia"
		Escribir "10) Salir"
		
		Leer operacion
		
		Segun operacion Hacer
			1:
				// Alta de Cliente
				AltaCliente()
				DetallarCuenta(cliente, cuentas)
			2:
				// Baja de Cliente
				BajaCliente()
				DetallarCuenta(cliente, cuentas)
			3:
				// Modificación de Cliente
				ModificacionCliente(cliente)
				DetallarCuenta(cliente, cuentas)
			4:
				// Alta de Cuenta
				AltaCuenta()
				DetallarCuenta(cliente, cuentas)
			5:
				// Baja de Cuenta
				BajaCuenta()
				DetallarCuenta(cliente, cuentas)
			6:
				// Modificación de Cuenta
				ModificacionCuenta()
				DetallarCuenta(cliente, cuentas)
			7:
				// Realizar Depósito
				Escribir "Ingrese cuenta sobre la que operar (0 ó 1): "
				Leer cuenta
				Depositar(cuenta, cuentas)
				DetallarCuenta(cliente, cuentas)
			8:
				// Realizar Retiro
				Escribir "Ingrese cuenta sobre la que operar (0 ó 1): "
				Leer cuenta
				Retirar(cuenta, cuentas)
				DetallarCuenta(cliente, cuentas)
			9:
				// Realizar Transferencia
				Escribir "Ingrese cuenta sobre la que operar (0 ó 1): "
				Leer cuenta
				Transferir(cuenta, cuentas)
				DetallarCuenta(cliente, cuentas)
			10:
				// Salir
				Escribir "Gracias y vuelva pronto."
				Escribir "Saliendo..."
				Escribir "Ahora puede cerrar esta ventana."
			De Otro Modo:
				Escribir "Ingrese una opción válida"
		Fin Segun
		
	Hasta Que operacion == 10
	
FinProceso

// """ *------------------------>= [PROCEDIMIENTOS] <=----------------------------*

// INFORMAR

SubProceso DetallarCuenta(cliente Por Referencia, cuentas Por Referencia)
	Escribir ""
	Escribir "Datos de la Cuenta"
	Escribir "------------------"
	Escribir cliente, ", su saldo es: "
	Para i <- 0 Hasta 1 Hacer
		Escribir "En cuenta ", i, " hay $ ", cuentas[i]
	FinPara
	Escribir ""
FinSubProceso

// CLIENTES

Funcion AltaCliente
	Escribir "Usted ya está dado de alta."
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

Funcion BajaCliente
	Escribir "No es posible aún realizar esa operación."
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

Funcion ModificacionCliente(cliente Por Referencia)
	Escribir cliente, " ingrese su nuevo nombre"
	Leer cliente
	Escribir "Operación exitosa."
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

// CUENTAS

Funcion AltaCuenta
	Escribir "No es posible aún realizar esa operación."
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

Funcion BajaCuenta
	Escribir "No es posible aún realizar esa operación."
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

Funcion ModificacionCuenta
	Escribir "Solo puede modificar los saldos de sus cuentas."
	Escribir "Para ello, elija una operación del menú principal."
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

// OPERACIONES

Funcion Depositar(cuenta Por Referencia, cuentas Por Referencia)
	Definir importe Como Entero
	Escribir "Ingrese importe a depositar: "
	Leer importe
	cuentas[cuenta] <- importe
	Escribir "Operación exitosa."
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

Funcion Retirar(cuenta Por Referencia, cuentas Por Referencia)
	Definir importe Como Entero
	Escribir "Ingrese importe a retirar: "
	Leer importe
	Si cuentas[cuenta] > importe Entonces
		cuentas[cuenta] = cuentas[cuenta] - importe
		Escribir "Operación exitosa."
	SiNo
		Escribir "Saldo insuficiente para hacer un retiro"
	FinSi
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion

Funcion Transferir(cuenta Por Referencia, cuentas Por Referencia)
	Definir importe Como Entero
	Escribir "Ingrese importe a transferir: "
	Leer importe
	Si cuentas[cuenta] > importe Entonces
		Si cuenta = 0 Entonces
			cuentas[cuenta] = cuentas[cuenta] - importe
			cuentas[1] = cuentas[1] + importe
			Escribir "Operación exitosa."
		SiNo
			cuentas[cuenta] = cuentas[cuenta] - importe
			cuentas[0] = cuentas[0] + importe
			Escribir "Operación exitosa."
		FinSi
	SiNo
		Escribir "Saldo insuficiente para hacer un retiro"
	FinSi
	Escribir "Presione un tecla para continuar..."
	Esperar Tecla
	Borrar Pantalla
FinFuncion
