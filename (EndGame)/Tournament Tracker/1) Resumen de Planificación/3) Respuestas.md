---
/*
  @title        GESTOR DE TORNEOS
  @description  Aplicación para crear, organizar y administrar torneos.
  @author       Gerardo Tordoya
  @date         2022-10-09
*/
---

# Respuestas

**1) ¿Cuántos jugadores participan en el torneo? ¿Es un número fijo o variable?**

La aplicación debe poder manejar un número variable de jugadores en un torneo.

**2) Si un torneo tiene menos de la dotación completa de jugadores (_es decir, se cuenta con un número impar de jugadores_), ¿cómo lo manejamos?**

Un torneo con menos del número perfecto (un múltiplo de 2: 4, 8, 16, 32, etc.) debe agregar "exentos". Básicamente, ciertas personas seleccionadas al azar pueden saltarse la primera ronda y actuar como si hubieran ganado.

**3) ¿El orden de quién juega entre sí debe ser aleatorio u ordenado por orden de entrada?**

El orden de los partidos debe ser aleatorio.

**4) ¿Deberíamos agendar el partido o se juega cuando sea?**

Los partidos se juegan cuando sea. Es decir, en cualquier momento que los jugadores quieran jugar en el orden que sea.

**5) Si los partidos están agendados, ¿cómo sabe el sistema cuándo agendar los partidos?**

Los partidos no están agendados. Se juegan cuando sea.

**6) Si los partidos se juegan cuando sea, ¿se puede jugar un partido de la segunda ronda antes de que se complete la primera ronda?**

No. Cada ronda debe completarse antes de que comience la siguiente.

**7) ¿El sistema necesita almacenar puntuaciones de algún tipo o solo los ganadores?**

Sería bueno almacenar una puntuación simple. Sólo un número para cada jugador. De esa manera, la aplicación puede ser lo suficientemente flexible para manejar un torneo de damas (el ganador tendría un 1 y el perdedor un 0) o un torneo de baloncesto.

**8) ¿Qué tipo de front-end debe tener este sistema (formulario, página web, aplicación, etc.)?**

Por ahora, el sistema debería ser una aplicación de escritorio. Más adelante, se puede agregar una interfaz web o móvil.

**9) ¿Dónde se almacenarán los datos (base de datos, archivo, etc.)?**

Idealmente, los datos deben almacenarse en una base de datos de Microsoft SQL Server, pero agregue la opción de, en cambio, almacenarlos en un archivo de texto.

**10) ¿Este sistema manejará tarifas de entrada, premios u otros pagos?**

Sí, el torneo debería tener la opción de cobrar una cuota de inscripción. Los premios también deberían ser una opción en la que el administrador del torneo elija cuánto dinero otorgar a un número variable de lugares. El monto total en efectivo no debe exceder los ingresos del torneo. También sería bueno especificar un sistema basado en porcentajes.

**11) ¿Qué tipo de reportes se necesitan?**

Un informe simple que especifique el resultado de los juegos por ronda, así como un informe que especifique quién ganó y cuánto ganó. Estos pueden mostrarse en un formulario o pueden enviarse por correo electrónico a los competidores del torneo y al administrador.

**12) ¿Quién puede registrar los resultados de los partidos?**

Cualquiera que use la aplicación puede registrar los resultados de los partidos.

**13) ¿Existen varios niveles de acceso (administrador, usuario, etc.)?**

No. El único método de acceso variado es que los competidores no puedan acceder a la aplicación y, en cambio, hagan todo por correo electrónico.

NOTA: El administrador del torneo ha definido que los competidores no tengan acceso a la aplicación. Lo que hacen los competidores, lo hacen a través de un e-mail. Y esta decisión se basa en que esta aplicación es de escritorio y residirá en la computadora del administrador del torneo y en la de nadie más.

Es decir, es una especie de sistema a dos niveles: un nivel solo recibe emails, y el otro nivel tiene control total.

**14) ¿El sistema debería poder avisar a los usuarios sobre próximos partidos?**

Sí, el sistema debe enviar un correo electrónico a los usuarios informándoles que deben jugar en una ronda y con quién están programados para jugar.

**15) ¿Al sistema lo usarán solo jugadores o también equipos?**

La aplicación debería poder manejar la adición de otros miembros. Todos los miembros deben ser tratados como iguales en el sentido de que todos reciben correos electrónicos del torneo. Los equipos también deberían poder nombrar a su equipo.
