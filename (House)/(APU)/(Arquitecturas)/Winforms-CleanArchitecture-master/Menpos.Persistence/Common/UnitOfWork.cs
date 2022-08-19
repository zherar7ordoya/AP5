using Menpos.Domain.Common;
using Menpos.Domain.Interfaces;
using Menpos.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Menpos.Persistence.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PosContext _context;

        public IEmpresaRepository Empresas { get; private set; }


        public UnitOfWork(PosContext context)
        {
            _context = context;
            Empresas = new EmpresaRepository(context);
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
