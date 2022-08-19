using Menpos.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Menpos.Domain.Models
{
    public class Empresa : BaseModel
    {
        public string RFC { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public int TitularId { get; set; }
        public int MonedaStandardId { get; set; }
        public int LicenciaId { get; set; }
    }
}
