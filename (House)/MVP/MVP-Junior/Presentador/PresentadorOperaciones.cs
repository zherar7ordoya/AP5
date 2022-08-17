using Modelo;

namespace Presentador
{
    public class PresentadorOperaciones
    {

        // *-------------------------------------------------------=> ATRIBUTOS

        private readonly IVistaOperaciones IVISTA_OPERACIONES;
        private readonly ModeloOperaciones MODELO_OPERACIONES;

        // *-----------------------------------------------------=> CONSTRUCTOR

        public PresentadorOperaciones(IVistaOperaciones vista)
        {
            IVISTA_OPERACIONES = vista;
            MODELO_OPERACIONES = new ModeloOperaciones();
        }

        // *---------------------------------------------------------=> MÉTODOS

        public void IniciarVista()
        {
            IVISTA_OPERACIONES.Num1 = 0;
            IVISTA_OPERACIONES.Num2 = 0;
            IVISTA_OPERACIONES.Resultado = 0;
        }

        public void ActualizarVista()
        {
            IVISTA_OPERACIONES.Resultado = MODELO_OPERACIONES.Sumar(IVISTA_OPERACIONES.Num1, IVISTA_OPERACIONES.Num2);
        }

        // *------------------------------------------------------=> Ç'EST FINI

    }
}
