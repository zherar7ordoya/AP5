namespace BE
{
    public class Localidad : Entidad
    {
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Id + " " + Descripcion;
        }
    }
}
