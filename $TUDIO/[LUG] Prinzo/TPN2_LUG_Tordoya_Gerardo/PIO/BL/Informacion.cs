namespace BLL
{
    public class Informacion
    {
        public virtual void Informar()
        {
            System
                .Diagnostics
                .Debug
                .WriteLine(
                "Soy la clase INFORMACIÓN " +
                "y no tengo participación activa.");
        }
    }
}
