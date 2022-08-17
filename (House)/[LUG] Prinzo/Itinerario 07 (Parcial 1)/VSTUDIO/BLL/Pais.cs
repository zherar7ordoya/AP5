using System.Collections.Generic;

namespace BLL
{
    public class Pais : ABS.IGestor<BEL.Pais>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.Pais pais;
        public Pais() => this.pais = new DML.Pais();

        // *------------------------------------------------=> IMPLEMENTACIONES
        public BEL.Pais Detallar(BEL.Pais pais) => this.pais.Detallar(pais);
        public bool Eliminar(BEL.Pais pais) => this.pais.Eliminar(pais);
        public bool Guardar(BEL.Pais pais) => this.pais.Guardar(pais);
        public List<BEL.Pais> Listar() => this.pais.Listar();
    }
}
