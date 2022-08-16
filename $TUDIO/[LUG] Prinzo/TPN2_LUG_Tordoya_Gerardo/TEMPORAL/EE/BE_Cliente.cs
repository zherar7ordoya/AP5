namespace BE
{
    public class BE_Cliente : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public Localidad Localidad { get; set; }
        public bool Activo { get; set; }
    }
}
