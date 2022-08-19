using Menpos.Domain.Common;
using Menpos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menpos.Domain.Interfaces
{
    public interface IEmpresaRepository : IBaseRepository<Empresa>
    {
        IEnumerable<Empresa> GetTopEmpresas(int count);
        IEnumerable<Empresa> GetEmpresasWithEstablishment(int pageIndex, int pageSize);

    }
}
