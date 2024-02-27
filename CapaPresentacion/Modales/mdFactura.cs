using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modales
{
    public partial class mdFactura : Form
    {
        public mdFactura()
        {
            InitializeComponent();
            
        }

        public void AbrirArchivo(string ruta)
        {
            axAcroPDF1.src = ruta;
            ShowDialog();
            
        }

    }
}
