using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteVenta
    {
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
