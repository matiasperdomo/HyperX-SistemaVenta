using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Properties;
using CapaPresentacion.Utilidades;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;
using Rectangle = System.Drawing.Rectangle;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();

            //CARGA LAS VENTAS EN LA TABLA
            List<Venta> lista = new CN_Venta().Listar();
            dgvdatav.Rows.Clear();

            foreach (Venta item in lista)
            {
                dgvdatav.Rows.Add(new object[] {
                    "",
                    item.IdVenta,
                    item.NumeroDocumento,
                    item.DocumentoCliente,
                    item.NombreCliente,
                    item.MontoTotal,
                    item.FechaRegistro
                });
            }
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();

        }

        //CARGA IMAGEN CHECK EN DGV
        private void dgvdatav_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        //BTN SELECCIONAR CHECK
        private void dgvdatav_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdatav.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtbusqueda.Text = dgvdatav.Rows[indice].Cells["NumeroDocumento"].Value.ToString();
                    btnbuscar_Click(sender, e);
                }
            }
        }

        //BTN BUSCAR VENTA
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0) {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;


                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");
            }

        }


        //BTN BORRAR CAMPOS
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = "";
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";
            txtbusqueda.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";
        }

        //BTN ABRIR FACTURA
        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (txtnumerodocumento.Text != "")
            {
                string path = Path.GetFullPath("..\\..\\Resources\\Archivos\\facturas\\Venta_" + txtnumerodocumento.Text + ".pdf");
                using (var modal = new mdFactura())
                {
                    modal.AbrirArchivo(path);
                }
            }
            

        }

        private void btnbuscarreporte_Click(object sender, EventArgs e)
        {
            //CARGA LAS VENTAS EN LA TABLA
            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_Reporte().Venta(
                txtfechainicio.Value.ToString(),
                txtfechafin.Value.ToString()
                );

            dgvdatav.Rows.Clear();

            foreach (ReporteVenta rv in lista)
            {
                dgvdatav.Rows.Add(new object[] {
                    "",
                    "",
                    rv.NumeroDocumento,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.MontoTotal,
                    rv.FechaRegistro
                });
            }
        }

        private void btnlimpiarreporte_Click(object sender, EventArgs e)
        {
            //RESETEAR TABLA
            List<Venta> lista = new CN_Venta().Listar();
            dgvdatav.Rows.Clear();

            foreach (Venta item in lista)
            {
                dgvdatav.Rows.Add(new object[] {
                    "",
                    item.IdVenta,
                    item.NumeroDocumento,
                    item.DocumentoCliente,
                    item.NombreCliente,
                    item.MontoTotal,
                    item.FechaRegistro
                });
            }
        }
    }
}
