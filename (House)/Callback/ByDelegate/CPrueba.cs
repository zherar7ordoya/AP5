using static System.Console;

namespace ByDelegate
{
    public class CPrueba
    {
        public void Probar()
        {
            DTarea callback = ProbarCallback;
            CTarea tarea = new CTarea();
            tarea.ComenzarTarea(callback);
        }
        public void ProbarCallback(string texto) => WriteLine(texto);
    }
}
