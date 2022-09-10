# Ejercio del Banco

Es un banco que administra las cuentas de sus clientes.
Por un lado los clientes y por otro las cuentas.
Cada cuenta soporta 3 tipos de operaciones:
Depósitos
Extracciones
Transferencias

No usar objetos.

Depositar significa elegir una cuenta y agregarle dinero.
Extraer significa elegir una cuenta y sacarle dinero.
Transferir significa elegir una cuenta y sacarle dinero y elegir otra cuenta y agregarle dinero.

Restricciones:

- Si la cuenta no tiene saldo suficiente para extraer, no se puede extraer.
- Si la cuenta no tiene saldo suficiente para transferir, no se puede transferir.
- No se puede extraer ni transferir un importe más grande que el saldo de la cuenta.

No hace falta hacer un historial de operaciones (registro de movimientos). Alcanza con el saldo final.

Con respecto a los clientes:

- Agregar un cliente
- Eliminar un cliente
- Modificar un cliente

Con respecto a las cuentas:

- Agregar una cuenta
- Eliminar una cuenta
- Modificar una cuenta

Opcciones para mostrar una cuenta:

- Mostrar todo ante cada modificación
- Mostrar todo al final de la ejecución

Un cliente puede tener más de una cuenta.

El trabajo es imprimir en consola y leer de consola.
Se puede hacer con funciones.
