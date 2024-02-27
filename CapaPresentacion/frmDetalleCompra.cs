using CapaEntidad;
using CapaNegocio;
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
using Rectangle = System.Drawing.Rectangle;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();

            //CARGA LAS VENTAS EN LA TABLA
            List<Compra> lista = new CN_Compra().Listar();
            dgvdatac.Rows.Clear();

            foreach (Compra item in lista)
            {
                dgvdatac.Rows.Add(new object[] {
                    "",
                    item.IdCompra,
                    item.NumeroDocumento,
                    item.oProveedor.Documento,
                    item.oProveedor.RazonSocial,
                    item.MontoTotal,
                    item.FechaRegistro
                });
            }
        }

        //CARGA IMAGEN CHECK EN DGV
        private void dgvdatac_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void dgvdatac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdatac.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtbusqueda.Text = dgvdatac.Rows[indice].Cells["NumeroDocumento"].Value.ToString();
                    btnbuscar_Click(sender, e);
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtbusqueda.Text);

            if (oCompra.IdCompra != 0) {

                txtnumerodocumento.Text = oCompra.NumeroDocumento;

                txtfecha.Text = oCompra.FechaRegistro;
                txttipodocumento.Text = oCompra.TipoDocumento;
                txtusuario.Text = oCompra.oUsuario.NombreCompleto;
                txtdocproveedor.Text = oCompra.oProveedor.Documento;
                txtnombreproveedor.Text = oCompra.oProveedor.RazonSocial;

                dgvdata.Rows.Clear();
                foreach (Detalle_Compra dc in oCompra.oDetalleCompra) {
                    dgvdata.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }

                txtmontototal.Text = oCompra.MontoTotal.ToString("0.00");

            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdocproveedor.Text = "";
            txtnombreproveedor.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
        }

        private void btnbuscarreporte_Click(object sender, EventArgs e)
        {
            //CARGA LAS VENTAS EN LA TABLA
            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                txtfechainicio.Value.ToString(),
                txtfechafin.Value.ToString()
                );

            dgvdatac.Rows.Clear();

            foreach (ReporteCompra rv in lista)
            {
                dgvdatac.Rows.Add(new object[] {
                    "",
                    "",
                    rv.NumeroDocumento,
                    rv.DocumentoProveedor,
                    rv.RazonSocial,
                    rv.MontoTotal,
                    rv.FechaRegistro
                });
            }
        }

        private void btnlimpiarreporte_Click(object sender, EventArgs e)
        {
            //RESETEAR TABLA
            List<Compra> lista = new CN_Compra().Listar();
            dgvdatac.Rows.Clear();

            foreach (Compra item in lista)
            {
                dgvdatac.Rows.Add(new object[] {
                    "",
                    item.IdCompra,
                    item.NumeroDocumento,
                    item.oProveedor.Documento,
                    item.oProveedor.RazonSocial,
                    item.MontoTotal,
                    item.FechaRegistro
                });
            }
        }
    }
}
