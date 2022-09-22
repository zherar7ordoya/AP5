namespace MediadorConsola
{
    public interface IColega
    {
        void Recibir(string emisor, string mensaje);
        void Enviar(string mensaje);
    }
}
