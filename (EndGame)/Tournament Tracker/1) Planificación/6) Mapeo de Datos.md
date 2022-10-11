---
/*
  @title        GESTOR DE CAMPEONATOS
  @description  Aplicación para crear, organizar y administrar campeonatos.
  @author       Gerardo Tordoya
  @date         2022-10-09
*/
---

# Mapa de Datos

**RECOMENDACIÓN DEL SENIOR DEVELOPER:**

Nunca se pueden hacer las cosas perfectas desde el principio. Si intentas hacer eso, pasarás demasiado tiempo planificando y nunca sacarás tu aplicación por la puerta: Una aplicación bien planificada que todavía está en tu bloc de notas es inútil. Lo que se necesita es algo fuera de la puerta.

    Así que existe ese equilibrio en el cual definitivamente planeamos antes de comenzar a construir, pero en el que no nos atascamos tanto que no construimos.

Esta es solo una tensión en la que todos trabajamos. Y vuelvo a señalar que la nota clave más importante aquí es: No te preocupes, no pienses demasiado, está bien, así que sigamos adelante.

**OBSERVACIÓN DEL JUNIOR DEVELOPER:**

Lo único que sabes de un anciano es que ha sobrevivido a mucho más y mucho peor que tú.

---

## Equipo

* EquipoMiembros (List\<Persona>)
* EquipoNombre (String)

## Persona

* PersonaNombre (String)
* PersonaApellido (String)
* PersonaEmail (String)
* PersonaTelefono (String)

## Campeonato

* CampeonatoNombre (String)
* CampeonatoTarifa (Decimal)
* EquiposInscritos (List\<Equipo>)
* Premios (List\<Premio>)
* Rondas (List<List\<Partido>>)

## Premio

* PuestoNumero (Integer)
* PuestoNombre (String)
* PremioMonto (Decimal)
* PremioPorcentaje (Double)

## Partido

* Participante (List\<Participante>)
* Ganador (Equipo)
* PartidoRonda (Integer)

## Participante

* ParticipanteEquipo (Equipo)
* ParticipantePuntos (Double)
* PartidoAnterior (Partido)
