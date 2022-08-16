namespace BE
{
    public class BE_Empleado : Entidad
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string DepartamentoID { get; set; }
        public string RolID { get; set; }
        public string Instruccion { get; set; }
    }
}
