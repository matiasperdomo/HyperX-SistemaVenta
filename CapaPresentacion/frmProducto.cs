using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Org.BouncyCastle.Pkix;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        //INICIALIZANDO TODAS LAS VARIABLES
        private static readonly Producto filtroProd = new Producto();

        //PESTAÑA DE USUARIOS
        private List<Producto> productos_completos = new List<Producto>();
        private List<Producto> productos_filtrados = new List<Producto>();
        private List<Producto> productos_paginados = new List<Producto>();

        private int current_prod = 0;
        private int paginador_prod = 5;
        private int total_prods = 0;
        private int last_page_prods = 0;
        private int current_page_prod = 1;
        private int productos_totales_prod = 0;

        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            LlenarCombosProd();
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS
            List<Producto> lista = new CN__Producto().Listar();
            productos_completos = lista;
            productos_filtrados = lista;
            total_prods = productos_completos.Count;
            last_page_prods = total_prods / paginador_prod;
            productos_totales_prod = productos_completos.Count;
            PaginarProductos(lista);

            List<Categoria> listacategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listacategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cbocategoria.DisplayMember = "Texto";
            cbocategoria.ValueMember = "Valor";
            cbocategoria.SelectedIndex = 0;
        }


        private void cargarProductos(List<Producto> listaProductos) {

            //MOSTRAR TODOS LOS USUARIOS
            dgvdata.Rows.Clear();

            foreach (Producto item in listaProductos)
            {
                Bitmap Img;
                

                int rowIndex = dgvdata.Rows.Add(new object[] {
                    "",
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                    
                }); ;

                
                try
                {
                    Img = new Bitmap(@"../../Resources/Imagenes/productos/" + item.Codigo + ".jpg");
                    dgvdata.Rows[rowIndex].Cells[1].Value = Img;
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

        }

        //BTN GUARDAR PRODUCTO
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (File.Image != null)
            {
                try
                {
                    File.Image.Save(@"../../Resources/Imagenes/productos/" + txtcodigo.Text + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    //NO SE PUDO GUARDAR LA IMAGEN
                }
            }


            //VALIDAR CAMPO STOCK
            int stock;
            if(txtstock.Text == "")
            {
                stock = 0;
            }
            else
            {
                stock = Convert.ToInt32(txtstock.Text);
            }

            //VALIDAR CAMPO PRECIO
            decimal precio;
            if(txtprecio.Text == "")
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDecimal(txtprecio.Text);
            }

            Producto obj = new Producto()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                Codigo = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Descripcion = txtdescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).Valor) },
                Stock = stock,
                PrecioVenta = precio,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false,
                img = "@../../Resources/Imagenes/productos/" + txtcodigo.Text + ".jpg"
            };

            if (obj.IdProducto == 0)
            {
                int idgenerado = new CN__Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN__Producto().Editar(obj, out mensaje);

                if (resultado)
                {
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }


        //LIMPIAR CAMPOS
        private void Limpiar()
        {

            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            cbocategoria.SelectedIndex = 0;
            txtstock.Text = "";
            txtprecio.Text = "";
            cboestado.SelectedIndex = 0;
            File.Image = null;
            txtcodigo.Select();

            FiltrarProd2();
        }

        //AGREGA CHECK A TABLE
        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        //BTN CHECK CLICK
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();

                    txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtnombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();
            

                    foreach (OpcionCombo oc in cbocategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbocategoria.Items.IndexOf(oc);
                            cbocategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    txtstock.Text = dgvdata.Rows[indice].Cells["Stock"].Value.ToString();
                    txtprecio.Text = dgvdata.Rows[indice].Cells["PrecioVenta"].Value.ToString();


                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }


                }
            }
        }

        //BTN ELIMINAR PRODUCTO
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN__Producto().Eliminar(obj, out mensaje);

                    Limpiar();

                    //EN EL CASO DE QUE SE QUIERA DAR DE BAJA
                    if (respuesta)
                    {
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    //EN EL CASO DE QUE SE QUIERA ELIMINAR
                    /*if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }*/

                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //BTN EXPORTAR EXCEL LISTADO PRODUCTOS
        private void btnexportar_Click(object sender, EventArgs e)
        {
            List<Producto> lista = new CN__Producto().Listar();
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                DataTable dt = new DataTable();

                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Descripcion", typeof(string));
                dt.Columns.Add("Categoria", typeof(string));
                dt.Columns.Add("Stock", typeof(string));
                dt.Columns.Add("Precio Compra", typeof(string));
                dt.Columns.Add("Precio Venta", typeof(string));
                dt.Columns.Add("Estado", typeof(string));

                foreach (Producto item in lista) {
                        dt.Rows.Add(new object[] {

                            item.Codigo.ToString(),
                            item.Nombre.ToString(),
                            item.Descripcion.ToString(),
                            item.oCategoria.Descripcion.ToString(),
                            item.Stock.ToString(),
                            item.PrecioCompra.ToString(),
                            item.PrecioVenta.ToString(),
                            item.Estado.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx",DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK) {

                    try {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
        }

        //BTN CARGAR IMAGEN
        private void Btn_OpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG(*.JPG)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.Image = Image.FromFile(ofd.FileName);
            }
        }


        //LLENAR LOS COMBOBOX - USUARIOS
        private void LlenarCombosProd()
        {
            LlenarComboPagsUsu();
            LlenarComboEstadoUsu();
            LlenarComboCategoria();

        }

        //LLENADO DE COMBOBOX PAGINAS - USUARIOS
        private void LlenarComboPagsUsu()
        {
            comboPagsProd.Items.Add("5");
            comboPagsProd.Items.Add("10");
            comboPagsProd.Items.Add("20");
            comboPagsProd.SelectedItem = "5";
        }

        //LENADO DEL COMBO ESTADO - USUARIOS
        private void LlenarComboEstadoUsu()
        {
            cmbEstadoProd.Items.Add("Activo");
            cmbEstadoProd.Items.Add("Inactivo");
        }

        //LLENADO DEL COMBO CATEGORIA - PRODUCTOS
        private void LlenarComboCategoria()
        {
            List<Categoria> listacategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listacategoria)
            {
                cmbCategoriaProd.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cmbCategoriaProd.DisplayMember = "Texto";
            cmbCategoriaProd.ValueMember = "Valor";
            cmbCategoriaProd.SelectedIndex = -1;
            cmbCategoriaProd.Text = null;
        }

        public void PaginarProductos(List<Producto> prodsMostrar)
        {
            productos_paginados = prodsMostrar.Skip(current_prod).Take(paginador_prod).ToList();
            cargarProductos(productos_paginados);
            labelMostrandoProd.Text = "Mostrando " + (current_prod + paginador_prod) + " de " + total_prods;

            //SI LA PAGINA ACTUAL ES LA PRIMERA
            if (current_page_prod == 1)
            {
                btnFirstPagProd.Hide();
                btnPrevPagProd.Hide();
            }
            else
            {
                btnFirstPagProd.Show();
                btnPrevPagProd.Show();
            }

            //SI LA PAGINA ACTUAL SE ENCUENTRA EN LA ULTIMA PAGINA
            if (current_page_prod == last_page_prods)
            {
                btnLastPagProd.Hide();
                btnNextPagProd.Hide();
            }
            else
            {
                btnLastPagProd.Show();
                btnNextPagProd.Show();
            }

            //SI LA PAGINA ACTUAL TIENE TODOS LOS PRODUCTOS, NO MOSTRAR LA PROXIMA PAGINA
            if ((current_prod + paginador_prod) < total_prods)
            {
                btnLastPagProd.Show();
                btnNextPagProd.Show();
            }
            else
            {
                btnLastPagProd.Hide();
                btnNextPagProd.Hide();
            }
        }

        //FILTRADO - USUARIOS2
        private void FiltrarProd2()
        {
            List<Producto> lista = new CN__Producto().Listar();
            productos_completos = lista;
            productos_filtrados = lista;
            productos_filtrados = productos_completos;

            if (filtroProd.Codigo != null)
            {
                productos_filtrados = productos_completos.Where(x => x.Codigo.ToLower().Contains(filtroProd.Codigo)).ToList();
            }

            if (filtroProd.Nombre != null)
            {
                productos_filtrados = productos_completos.Where(x => x.Nombre.ToLower().Contains(filtroProd.Nombre)).ToList();
            }


            if (cmbCategoriaProd.SelectedIndex != -1)
            {
                productos_filtrados = productos_completos.Where(x => x.oCategoria.IdCategoria == (cmbCategoriaProd.SelectedIndex+1)).ToList();
            }

            if (cmbEstadoProd.SelectedItem != null)
            {
                if (filtroProd.Estado == true)
                {
                    productos_filtrados = productos_filtrados.Where(x => x.Estado == true).ToList();
                }
                if (filtroProd.Estado == false)
                {
                    productos_filtrados = productos_filtrados.Where(x => x.Estado == false).ToList();
                }
            }


            total_prods = productos_filtrados.Count;
            last_page_prods = (total_prods / paginador_prod) + 1;
            current_prod = 0;
            current_page_prod = 1;

            PaginarProductos(productos_filtrados);
        }


        //FILTRADO - USUARIOS
        private void FiltrarProd()
        {
            if (filtroProd.Codigo != null)
            {
                productos_filtrados = productos_completos.Where(x => x.Codigo.ToLower().Contains(filtroProd.Codigo)).ToList();
            }

            if (filtroProd.Nombre != null)
            {
                productos_filtrados = productos_completos.Where(x => x.Nombre.ToLower().Contains(filtroProd.Nombre)).ToList();
            }


            if (cmbEstadoProd.SelectedItem != null)
            {
                if (filtroProd.Estado == true)
                {
                    productos_filtrados = productos_filtrados.Where(x => x.Estado == true).ToList();
                }
                if (filtroProd.Estado == false)
                {
                    productos_filtrados = productos_filtrados.Where(x => x.Estado == false).ToList();
                }
            }


            total_prods = productos_filtrados.Count;
            last_page_prods = (total_prods / paginador_prod) + 1;
            current_prod = 0;
            current_page_prod = 1;

            PaginarProductos(productos_filtrados);
        }

        //VOLVER A VALORES PREDETERMINADOS LA PAGINA - USUARIOS
        private void ResetPageProds()
        {
            current_prod = 0;
            current_page_prod = 1;
            labelCurrentPagProd.Text = current_page_prod.ToString();
            total_prods = productos_totales_prod;
            last_page_prods = (total_prods / paginador_prod) + 1;
            FiltrarProd2();
        }

        //COMBO PAGINACION - USUARIOS
        private void ComboPagsProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginador_prod = int.Parse(comboPagsProd.SelectedItem.ToString());
            current_prod = 0;
            current_page_prod = 1;
            labelCurrentPagProd.Text = current_page_prod.ToString();
            last_page_prods = (total_prods / paginador_prod) + 1;

            if (filtroProd.Codigo != null || filtroProd.Nombre != null)
            {
                PaginarProductos(productos_filtrados);
            }
            else
            {
                ResetPageProds();
            }
        }

        //FILTRAR POR CODIGO - PRODUCTOS
        private void TxtCodigoProd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoProd.Text))
            {
                //LIMPIAMOS EL FILTRO
                filtroProd.Codigo = null;
                FiltrarProd2();
            }
            else
            {
                string codigoFiltrar = txtCodigoProd.Text.ToString().ToLower();
                filtroProd.Codigo = codigoFiltrar;
                FiltrarProd2();
            }
        }

        //LIMPIAR FILTRO DE CODIGO - PRODUCTOS
        private void BtnCloseCodigoProd_Click(object sender, EventArgs e)
        {
            txtCodigoProd.Text = null;
            filtroProd.Codigo = null;
            FiltrarProd();
        }

        //FILTRAR POR NOMBRE - USUARIOS
        private void TxtNombreProd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreProd.Text))
            {
                //LIMPIAMOS EL FILTRO
                filtroProd.Nombre = null;
                FiltrarProd2();
            }
            else
            {
                string nombreFiltrar = txtNombreProd.Text.ToString().ToLower();
                filtroProd.Nombre = nombreFiltrar;
                FiltrarProd2();
            }
        }

        //LIMPIAR FILTRO DE NOMBRE - PRODUCTOS
        private void BtnCloseNombreProd_Click(object sender, EventArgs e)
        {
            txtNombreProd.Text = null;
            filtroProd.Nombre = null;
            FiltrarProd();
        }

        //FILTRAR POR CATEGORIA - PRODUCTOS
        private void CmbCategoriaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCategoriaProd.Text))
            {
                //LIMPIAMOS EL FILTRO
                FiltrarProd2();
            }
            else
            {
                string categoriaFiltrar = cmbCategoriaProd.Text.ToString().ToLower();
                FiltrarProd2();
            }

        }

        //LIMPIAR FILTRO DE CATEGORIAS - USUARIOS
        private void BtnCloseCategoriaoProd_Click(object sender, EventArgs e)
        {
            cmbCategoriaProd.Text = null;
            cmbCategoriaProd.SelectedIndex = -1;
            FiltrarProd();
        }

        //BTN FILTRAR POR ESTADO - USUARIOS
        private void CmbEstadoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoProd.SelectedItem != null)
            {
                string estadoFiltrar = cmbEstadoProd.SelectedItem.ToString();
                if (estadoFiltrar == "Activo")
                {
                    filtroProd.Estado = true;
                }
                if (estadoFiltrar == "Inactivo")
                {
                    filtroProd.Estado = false;
                }
                FiltrarProd2();
            }
        }

        //LIMPIAR FILTRO DE ESTADO - USUARIOS
        private void BtnCloseEstadoProd_Click(object sender, EventArgs e)
        {
            cmbEstadoProd.SelectedItem = null;
            filtroProd.Estado = false;
            FiltrarProd2();
        }

        //BTN LIMPIAR FILTROS - USUARIOS
        private void BtnLimpiarFiltrosProd_Click(object sender, EventArgs e)
        {
            txtCodigoProd.Text = null;
            txtNombreProd.Text = null;
            cmbEstadoProd.SelectedItem = null;
            filtroProd.Codigo = null;
            filtroProd.Nombre = null;
            filtroProd.Estado = false;
            cmbCategoriaProd.Text = null;

            ResetPageProds();
        }

        //BTN FIRST PAGE - USUARIOS
        private void BtnFirstPagProd_Click(object sender, EventArgs e)
        {
            current_prod = 0;
            current_page_prod = 1;
            labelCurrentPagProd.Text = current_page_prod.ToString();
            PaginarProductos(productos_filtrados);
        }

        //BTN PREV PAGE - USUARIOS
        private void BtnPrevPagProd_Click(object sender, EventArgs e)
        {
            if (current_prod + 1 > paginador_prod)
            {
                current_prod -= paginador_prod;
                current_page_prod--;
            }

            labelCurrentPagProd.Text = current_page_prod.ToString();
            PaginarProductos(productos_filtrados);
        }

        //BTN NEXT PAGE - USUARIOS
        private void BtnNextPagProd_Click(object sender, EventArgs e)
        {
            current_prod += paginador_prod;
            current_page_prod++;
            labelCurrentPagProd.Text = current_page_prod.ToString();
            PaginarProductos(productos_filtrados);
        }

        //BTN LAST PAGE - USUARIOS
        private void BtnLastPagProd_Click(object sender, EventArgs e)
        {
            current_prod = total_prods;
            current_page_prod = last_page_prods;
            labelCurrentPagProd.Text = current_page_prod.ToString();
            PaginarProductos(productos_filtrados);
        }

    }
}
