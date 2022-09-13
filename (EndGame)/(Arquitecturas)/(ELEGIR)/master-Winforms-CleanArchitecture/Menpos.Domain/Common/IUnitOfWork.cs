using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Menpos.Domain.Common
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
