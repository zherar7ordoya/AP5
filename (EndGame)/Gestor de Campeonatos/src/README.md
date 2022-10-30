# Notas

## Convención de nombres

Sobre los nombres:

    * La cosa particular: en español.
    * La cosa en general: en inglés.

Ejemplos:

    * GC (Gestor de Campeonatos) + Library
    * Campeonato + Model

 Esto es para que sea más fácil de entender para los que no hablan español,  pero al mismo tiempo, para mantener la convención usada generalmente en el  desarrollo de software.

## Justificación de la DAL

¿Cómo justifico la necesidad de añadir complejidad a este proyecto que intenta ser lo más sencillo posible? Porque, justamente, la propuesta original es que puedan agregarse más Interfaces de Usuario o más tipos de repositorios en algún futuro indeterminado. Si la DAL no es independiente, entonces se complejizaría el proyecto, y por tanto, según lo comentado por TC (en cuanto al balance) justifico la inyección de complejidad al resolver una complejidad mayor.

Sobre esto, leí un artículo que me pareció muy interesante: [Entendiendo la programación en 3 (o más) capas](https://vfpavanzado.wordpress.com/2017/10/31/entendiendo-la-programacion-en-3-o-mas-capas/):

    Y ahora viene algo muy importante: NO DEPENDAMOS DEL ORIGEN DE LOS DATOS.
    
    Eso significa que en nuestra aplicación (si queremos) podemos usar tablas DBF,  o un motor SQL tal como Firebird, MySQL, MariaDb, PostgreSQL, SQL Server, etc. El que se nos ocurra. No importa. Nuestra aplicación funcionará igualmente bien con cualquiera de ellos. Será aquí, en la Capa de Acceso a Datos, donde escribiremos los comandos que se comunicarán con la Base de Datos y esos sí pueden ser específicos de nuestro origen de datos, pero la Capa de Presentación y la Capa de Lógica de Negocio no se verán afectadas.

    Por ejemplo, en Firebird para ejecutar un procedimiento almacenado se escribe: EXECUTE PROCEDURE MiProcedimientoAlmacenado 
    Y en SQL Server se escribe: EXEC MiProcedimientoAlmacenado.
    
    Como ves, los comandos aunque realizan la misma tarea tienen nombres distintos. Entonces en la Capa de Acceso a Datos escribimos el comando correcto para nuestro motor SQL y listo. Ya está. Las otras capas ni se enteraron que cambiamos nuestro origen de datos. Pero les sigue funcionando muy bien todo.

    ¿Y por qué ni la Capa de Presentación ni la Capa de Lógica de Negocio se enteraron de que cambiamos el origen de datos?

    Porque ellas reciben un cursor. No se involucran en ningún momento con el envío o la recepción de comandos a la Base de Datos. Esa es tarea exclusiva de la Capa de Acceso a Datos. Entonces, como trabajan con cursores, les resulta totalmente indiferente si nuestro origen de datos es Firebird, MySQL, MariaDb, SQL Server, Oracle, o el que sea.

    Y esto, como te puedes imaginar, es una gran ventaja.

## Justificación de la BEL

Al haber inaugurado una DAL, para hacer funcionar la Configuración Global de la librería (no sé si se seguirá llamando así en el futuro) necesito modelos y conexiones al mismo tiempo.

Pero eso me implica una referencia circular si conservo los modelos en la librería: la DAL necesita los modelos (ahí viene la necesidad de la primera referencia) y luego la Configuración Global necesita la DAL (ahí viene la necesidad de la segunda referencia), y como se ve, se hace circular.

Es por eso, y no por otra cosa, que se justifica la BEL. De tal forma que la librería, para que funcione, estará referenciando tanto a la DAL como a la BEL.
