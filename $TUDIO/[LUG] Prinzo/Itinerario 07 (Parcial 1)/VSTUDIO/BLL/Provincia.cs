using System;
using System.Collections.Generic;

namespace BLL
{
    public class Provincia : ABS.IGestor<BEL.Provincia>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.Provincia provincia;
        public Provincia() => this.provincia = new DML.Provincia();

        // *------------------------------------------------=> IMPLEMENTACIONES
        public BEL.Provincia Detallar(BEL.Provincia provincia) => throw new NotImplementedException();
        public bool Eliminar(BEL.Provincia provincia) => throw new NotImplementedException();
        public bool Guardar(BEL.Provincia provincia) => throw new NotImplementedException();
        public List<BEL.Provincia> Listar() => this.provincia.Listar();
    }
}
