---
/*
  @title        GESTOR DE CAMPEONATOS
  @description  Aplicación para crear, organizar y administrar campeonatos.
  @author       Gerardo Tordoya
  @date         2022-10-09
*/
---

# Respuestas

**1) ¿Cuántos jugadores participan en el campeonato? ¿Es un número fijo o variable?**

La aplicación debe poder manejar un número variable de jugadores en un campeonato.

**2) Si un campeonato tiene menos de la dotación completa de jugadores (_es decir, se cuenta con un número impar de jugadores_), ¿cómo lo manejamos?**

Un campeonato con menos del número perfecto (un múltiplo de 2: 4, 8, 16, 32, etc.) debe agregar "exentos". Básicamente, ciertas personas seleccionadas al azar pueden saltarse la primera ronda y actuar como si hubieran ganado.

**3) ¿El orden de quién juega entre sí debe ser aleatorio u ordenado por orden de entrada?**

El orden de los partidos debe ser aleatorio.

**4) ¿Deberíamos agendar el partido o se juega cuando sea?**

Los partidos se juegan cuando sea. Es decir, en cualquier momento que los jugadores quieran jugar en el orden que sea.

**5) Si los partidos están agendados, ¿cómo sabe la aplicación cuándo agendar los partidos?**

Los partidos no están agendados. Se juegan cuando sea.

**6) Si los partidos se juegan cuando sea, ¿se puede jugar un partido de la segunda ronda antes de que se complete la primera ronda?**

No. Cada ronda debe completarse antes de que comience la siguiente.

**7) ¿La aplicación necesita almacenar puntuaciones de algún tipo o solo los ganadores?**

Sería bueno almacenar una puntuación simple. Sólo un número para cada jugador. De esa manera, la aplicación puede ser lo suficientemente flexible para manejar un campeonato de damas (el ganador tendría un 1 y el perdedor un 0) o un campeonato de baloncesto.

**8) ¿Qué tipo de front-end debe tener esta aplicación (formulario, página web, aplicación, etc.)?**

Por ahora, la aplicación debería ser una aplicación de escritorio. Más adelante, se puede agregar una interfaz web o móvil.

**9) ¿Dónde se almacenarán los datos (base de datos, archivo, etc.)?**

Idealmente, los datos deben almacenarse en una base de datos de Microsoft SQL Server, pero agregue la opción de, en cambio, almacenarlos en un archivo de texto.

**10) ¿Esta aplicación manejará tarifas de entrada, premios u otros pagos?**

Sí, el campeonato debería tener la opción de cobrar una cuota de inscripción. Los premios también deberían ser una opción en la que el administrador del campeonato elija cuánto dinero otorgar a un número variable de posiciones. El monto total en efectivo no debe exceder los ingresos del campeonato. También sería bueno especificar una opción basada en porcentajes.

**11) ¿Qué tipo de reportes se necesitan?**

Un informe simple que especifique el resultado de los juegos por ronda, así como un informe que especifique quién ganó y cuánto ganó. Estos pueden mostrarse en un formulario o pueden enviarse por correo electrónico a los competidores del campeonato y al administrador.

**12) ¿Quién puede registrar los resultados de los partidos?**

Cualquiera que use la aplicación puede registrar los resultados de los partidos. (_Véase nota en la respuesta siguiente._)

**13) ¿Existen varios niveles de acceso (administrador, usuario, etc.)?**

No. El único método de acceso variado es que los competidores no puedan acceder a la aplicación y, en cambio, hagan todo por correo electrónico.

NOTA: El administrador del campeonato ha definido que los competidores no tengan acceso a la aplicación. Lo que hacen los competidores, lo hacen a través de un e-mail. Y esta decisión se basa en que esta aplicación es de escritorio y residirá en la computadora del administrador del campeonato y en la de nadie más.

Es decir, es una especie de aplicación a dos niveles: un nivel solo recibe emails, y el otro, tiene control total.

**14) ¿La aplicación debería poder avisar a los usuarios sobre próximos partidos?**

Sí, la aplicación debe enviar un correo electrónico a los usuarios informándoles que deben jugar en una ronda y con quién están agendados para jugar.

**15) ¿La aplicación será usada solo por jugadores o también por equipos?**

La aplicación debería poder manejar la adición de otros miembros. Todos los miembros deben ser tratados como iguales en el sentido de que todos reciben correos electrónicos del campeonato. Los equipos también deberían poder nombrar a su equipo.
