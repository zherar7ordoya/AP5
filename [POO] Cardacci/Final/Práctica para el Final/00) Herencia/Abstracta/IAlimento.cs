namespace Captura
{
    /** Por fin me toca explicar no el qué sino el por qué. ¿Por qué pongo estos
     * campos aquí, si ya están en las clases correspondientes? El DataGridView
     * no puede "alcanzar" (mostrar) los campos heredados de esas clases. Puesto
     * que, de todas maneras, tienen que cumplir con estos campos, esta
     * repetición no daña y posibilita la visibilidad de la lista DataSource */

    public interface IAlimento
    {
        string Nombre { get; }
        string FechaInstancia { get; }
        string HoraInstancia { get; }
    }
}