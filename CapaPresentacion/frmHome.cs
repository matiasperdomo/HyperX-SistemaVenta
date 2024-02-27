using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CapaPresentacion
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            List<Producto> lista = new CN__Producto().BajoStock();


            foreach (Producto item in lista)
            {
                Bitmap Img;


                int rowIndex = dgvdata.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"

                }); ;


                try
                {
                    Img = new Bitmap(@"../../Resources/Imagenes/productos/" + item.Codigo + ".jpg");
                    dgvdata.Rows[rowIndex].Cells[0].Value = Img;
                    //((DataGridViewImageCell)dgvdata.Rows[rowIndex].Cells[1]).Value = Img;
                }
                catch
                {
                    //NO HAY IMAGEN
                }


                //SI EL ESTADO DEL PRODUCTO ES INACTIVO, PINTAR LAS CELDAS DE GRIS
                if (item.Estado == false)
                {
                    dgvdata.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Gray;
                }

            }

            //CANTIDAD DE PRODUCTOS
            int cantidad = new CN__Producto().ObtenerCantidadProd();
            cantProd.Text = cantidad.ToString();

            //MONTO TOTAL
            decimal monto = new CN_Venta().ObtenerRecaudacionTotal();
            montoTotal.Text = monto.ToString();

            //PROMEDIO DE VENTA
            decimal promedio = new CN_Venta().ObtenerPromedioVenta();
            montoPromedio.Text = promedio.ToString();

            //MAYOR VENTA
            decimal ventaMax = new CN_Venta().ObtenerMayorVenta();
            mayorVenta.Text = ventaMax.ToString();

            //MENOR VENTA
            decimal ventaMin = new CN_Venta().ObtenerMenorVenta();
            menorVenta.Text = ventaMin.ToString();

            //USUARIOS ACTIVOS
            int cantUsua = new CN_Usuario().ObtenerUsuariosActivos();
            usuaActivos.Text = cantUsua.ToString();

        }
    }
}
