using System;

namespace Evento
{
    public class Termostato
    {
        // Declaración (declaración de un evento en una variable a nivel clase)
        public event EventHandler TemperaturaPeligrosaEventHandler;
        int temperatura;

        // El desencadenamiento del evento se consigue a través del setter de la propiedad
        public int Temperatura
        {
            get { return temperatura; }
            set
            {
                temperatura = value;

                // Desencadenamiento
                if (value > 100)
                {
                    /* Esto fue un verdadero misterio pues no es fácil hallar
                     * en la documentación de Microsoft una explicación clara
                     * sobre los operadores condicionales, y específicamente,
                     * sobre el uso que aquí se ve. Ésto es lo que encontré:
                     * https://learn.microsoft.com/es-mx/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
                     * A éste, específicamente, se la llama "operador
                     * condicional nulo" y se usa para evitar que se produzca
                     * un error de referencia nula (NullReferenceException). */
                    TemperaturaPeligrosaEventHandler?.Invoke(this, null);
                }
            }
        }
    }
}
