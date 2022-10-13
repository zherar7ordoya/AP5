# Ejercio del Banco

**No usar objetos, resolver en forma estructurada.**

Es un banco que administra las cuentas de sus clientes.
Por un lado los clientes y por otro las cuentas.
Cada cuenta soporta 3 tipos de operaciones:

- **Depósitos:** Depositar significa elegir una cuenta y agregarle dinero.
- **Extracciones:** Extraer significa elegir una cuenta y sacarle dinero.
- **Transferencias:** Transferir significa elegir una cuenta y sacarle dinero y elegir otra cuenta y agregarle dinero.

Es necesario:

- ABM Clientes
- ABM Cuentas
- Un cliente puede tener más de una cuenta

## Restricciones

- Si la cuenta no tiene saldo suficiente para extraer, no se puede extraer.
- Si la cuenta no tiene saldo suficiente para transferir, no se puede transferir.
- No se puede extraer ni transferir un importe más grande que el saldo de la cuenta.
- No se puede transferir a la misma cuenta.
- No se puede transferir a una cuenta que no existe.

## Opcciones para mostrar una cuenta

Alcanza con el saldo final:

- Mostrar todo ante cada modificación
- Mostrar todo al final de la ejecución

## Observaciones

El trabajo es imprimir en consola y leer de consola.
No hace falta crear un historial de operaciones (registro de movimientos).
Se puede hacer con funciones.
