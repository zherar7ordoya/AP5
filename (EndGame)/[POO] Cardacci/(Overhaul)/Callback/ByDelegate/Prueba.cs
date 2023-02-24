using static System.Console;

namespace ByDelegate
{
    public class Prueba
    {
        public void Probar()
        {
            DelegadoTarea callback = ProbarCallback;
            Tarea tarea = new Tarea();
            tarea.ComenzarTarea(callback);
        }
        public void ProbarCallback(string texto) => WriteLine(texto);
    }
}
