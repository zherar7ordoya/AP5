using Menpos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menpos.Domain.Models
{
    public class Establecimiento : BaseModel
    {
        public int PersonaMoralId { get; set; }
        public int MonedaStandardId { get; set; }
        public int NivelCuentasContablesId { get; set; }
        public int RepositorioLogoId { get; set; }
    }
}
