using Menpos.Domain.Interfaces;
using Menpos.Domain.Models;
using Menpos.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Menpos.Persistence.Repositories
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {




        public EmpresaRepository(DbContext context) : base(context)
        {

        }

        public IEnumerable<Empresa> GetEmpresasWithEstablishment(int pageIndex, int pageSize)
        {
            return null;
        }

        public IEnumerable<Empresa> GetTopEmpresas(int count)
        {
            return null;
        }
    }
}
