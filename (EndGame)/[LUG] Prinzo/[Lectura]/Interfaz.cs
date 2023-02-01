using System.Collections.Generic;

public interface IABMC<T>
{
    void Alta(ref T QueObjeto = default(T));
    void Baja(ref T QueObjeto = default(T));
    void Modificacion(ref T QueObjeto = default(T));
    List<T> Consulta(ref T QueObjeto = default(T));
    List<T> ConsultaRango(ref T QueObjeto1 = default(T), ref T QueObjeto2 = default(T));
}


public interface IID
{
    int RetornaId();
}
