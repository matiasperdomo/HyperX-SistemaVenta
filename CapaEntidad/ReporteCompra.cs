using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteCompra
    {
        public string NumeroDocumento { get; set; }
        public string DocumentoProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
