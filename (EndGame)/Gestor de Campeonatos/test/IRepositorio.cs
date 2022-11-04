namespace ABS
{
    public interface IRepositorio <T> where T : IEntidad
    {
        bool Create(T IEntidad)
        IEnumerable<T>ReadAll()
        T ReadByID(T IEntidad)
        bool Update(T IEntidad)
        bool Delete(T IEntidad)
    }
}
