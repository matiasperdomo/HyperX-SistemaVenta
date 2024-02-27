using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        //INICIALIZANDO TODAS LAS VARIABLES
        private static readonly Categoria filtroCat = new Categoria();

        //PESTAÑA DE CATEGORIAS
        private List<Categoria> categorias_completas = new List<Categoria>();
        private List<Categoria> categorias_filtradas = new List<Categoria>();
        private List<Categoria> categorias_paginadas = new List<Categoria>();

        private int current_cat = 0;
        private int paginador_cat = 5;
        private int total_cats = 0;
        private int last_page_cats = 0;
        private int current_page_cat = 1;
        private int categorias_totales_cat = 0;
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            LlenarCombosCat();
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;



            //MOSTRAR TODAS LAS CATEGORIAS
            List<Categoria> lista = new CN_Categoria().Listar();
            categorias_completas = lista;
            categorias_filtradas = lista;
            total_cats = categorias_completas.Count;
            last_page_cats = total_cats / paginador_cat;
            categorias_totales_cat = categorias_completas.Count;
            PaginarCategorias(lista);
        }

        private void VisualizarCategorias(List<Categoria> listaCategorias)
        {
            //MOSTRAR TODOS LOS USUARIOS
            dgvdata.Rows.Clear();
            foreach (Categoria item in listaCategorias)
            {

                int rowIndex = dgvdata.Rows.Add(new object[] {"",item.IdCategoria,
                    item.Descripcion,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });


                //SI EL ESTADO DE LA CATEGORIA ES INACTIVO, PINTAR LAS CELDAS DE GRIS
                if (item.Estado == false)
                {
                    dgvdata.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Gray;
                }

            }
        }

        //BTN GUARDAR CATEGORIA
        private void btnguardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Categoria obj = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                Descripcion = txtdescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.IdCategoria == 0)
            {
                int idgenerado = new CN_Categoria().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {"",idgenerado,txtdescripcion.Text,
                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN_Categoria().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();
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
            txtdescripcion.Text = "";
            cboestado.SelectedIndex = 0;

            txtdescripcion.Select();
            FiltrarCats2();
        }

        //AGREGA CHECK A TABLA
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

        //BTN SELECCIONAR CHECK
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();
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

        //BTN ELIMINAR CATEGORIA
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la categoria", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Categoria().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }


        //BTN LIMPIAR CAMPOS
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        //LLENAR LOS COMBOBOX - CATEGORIAS
        private void LlenarCombosCat()
        {
            LlenarComboPagsCat();
            LlenarComboEstadoCat();
        }

        //LLENADO DE COMBOBOX PAGINAS - CATEGORIAS
        private void LlenarComboPagsCat()
        {
            comboPagsCat.Items.Add("5");
            comboPagsCat.Items.Add("10");
            comboPagsCat.Items.Add("20");
            comboPagsCat.SelectedItem = "5";
        }

        //LENADO DEL COMBO ESTADO - CATEGORIAS
        private void LlenarComboEstadoCat()
        {
            cmbEstadoCat.Items.Add("Activo");
            cmbEstadoCat.Items.Add("Inactivo");
        }

        public void PaginarCategorias(List<Categoria> catsMostrar)
        {
            categorias_paginadas = catsMostrar.Skip(current_cat).Take(paginador_cat).ToList();
            VisualizarCategorias(categorias_paginadas);
            labelMostrandoCat.Text = "Mostrando " + (current_cat + paginador_cat) + " de " + total_cats;

            //SI LA PAGINA ACTUAL ES LA PRIMERA
            if (current_page_cat == 1)
            {
                btnFirstPagCat.Hide();
                btnPrevPagCat.Hide();
            }
            else
            {
                btnFirstPagCat.Show();
                btnPrevPagCat.Show();
            }

            //SI LA PAGINA ACTUAL SE ENCUENTRA EN LA ULTIMA PAGINA
            if (current_page_cat == last_page_cats)
            {
                btnLastPagCat.Hide();
                btnNextPagCat.Hide();
            }
            else
            {
                btnLastPagCat.Show();
                btnNextPagCat.Show();
            }

            //SI LA PAGINA ACTUAL TIENE TODOS LOS PRODUCTOS, NO MOSTRAR LA PROXIMA PAGINA
            if ((current_cat + paginador_cat) < total_cats)
            {
                btnLastPagCat.Show();
                btnNextPagCat.Show();
            }
            else
            {
                btnLastPagCat.Hide();
                btnNextPagCat.Hide();
            }
        }

        //FILTRADO - CATEGORIAS2
        private void FiltrarCats2()
        {
            List<Categoria> lista = new CN_Categoria().Listar();
            categorias_completas = lista;
            categorias_filtradas = lista;
            categorias_filtradas = categorias_completas;

            if (filtroCat.Descripcion != null)
            {
                categorias_filtradas = categorias_completas.Where(x => x.Descripcion.ToLower().Contains(filtroCat.Descripcion)).ToList();
            }

            if (cmbEstadoCat.SelectedItem != null)
            {
                if (filtroCat.Estado == true)
                {
                    categorias_filtradas = categorias_filtradas.Where(x => x.Estado == true).ToList();
                }
                if (filtroCat.Estado == false)
                {
                    categorias_filtradas = categorias_filtradas.Where(x => x.Estado == false).ToList();
                }
            }

            total_cats = categorias_filtradas.Count;
            last_page_cats = (total_cats / paginador_cat) + 1;
            current_cat = 0;
            current_page_cat = 1;

            PaginarCategorias(categorias_filtradas);
        }


        //FILTRADO - CATEGORIAS
        private void FiltrarCats()
        {
            categorias_filtradas = categorias_completas;

            if (filtroCat.Descripcion != null)
            {
                categorias_filtradas = categorias_completas.Where(x => x.Descripcion.ToLower().Contains(filtroCat.Descripcion)).ToList();
            }


            total_cats = categorias_filtradas.Count;
            last_page_cats = (total_cats / paginador_cat) + 1;
            current_cat = 0;
            current_page_cat = 1;

            PaginarCategorias(categorias_filtradas);
        }

        //VOLVER A VALORES PREDETERMINADOS LA PAGINA - CATEGORIAS
        private void ResetPageCats()
        {
            current_cat = 0;
            current_page_cat = 1;
            labelCurrentPagCat.Text = current_page_cat.ToString();
            total_cats = categorias_totales_cat;
            last_page_cats = (total_cats / paginador_cat) + 1;
            FiltrarCats2();
        }

        //COMBO PAGINACION - CATEGORIAS
        private void ComboPagsCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginador_cat = int.Parse(comboPagsCat.SelectedItem.ToString());
            current_cat = 0;
            current_page_cat = 1;
            labelCurrentPagCat.Text = current_page_cat.ToString();
            last_page_cats = (total_cats / paginador_cat) + 1;

            if (filtroCat.Descripcion != null || cboestado != null)
            {
                PaginarCategorias(categorias_filtradas);
            }
            else
            {
                ResetPageCats();
            }
        }

        //FILTRAR POR NOMBRE - CATEGORIAS
        private void TxtNombreCat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCat.Text))
            {
                //LIMPIAMOS EL FILTRO
                filtroCat.Descripcion = null;
                FiltrarCats2();
            }
            else
            {
                string nombreFiltrar = txtNombreCat.Text.ToString().ToLower();
                filtroCat.Descripcion = nombreFiltrar;
                FiltrarCats2();
            }
        }

        //LIMPIAR FILTRO DE NOMBRE - CATEGORIAS
        private void BtnCloseNombreCats_Click(object sender, EventArgs e)
        {
            txtNombreCat.Text = null;
            filtroCat.Descripcion = null;
            FiltrarCats();
        }

        //BTN FILTRAR POR ESTADO - CATEGORIAS
        private void CmbEstadoCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoCat.SelectedItem != null)
            {
                string estadoFiltrar = cmbEstadoCat.SelectedItem.ToString();
                if(estadoFiltrar == "Activo")
                {
                    filtroCat.Estado = true;
                }
                if(estadoFiltrar == "Inactivo")
                {
                    filtroCat.Estado = false;
                }
                FiltrarCats2();
            }
        }

        //LIMPIAR FILTRO DE ESTADO - CATEGORIAS
        private void BtnCloseEstadoCats_Click(object sender, EventArgs e)
        {
            cmbEstadoCat.SelectedItem = null;
            filtroCat.Estado = false;
            FiltrarCats2();
        }

        //BTN LIMPIAR FILTROS - CATEGORIAS
        private void BtnLimpiarFiltrosCat_Click(object sender, EventArgs e)
        {
            txtNombreCat.Text = null;
            cmbEstadoCat.SelectedItem = null;
            filtroCat.Descripcion = null;
            filtroCat.Estado = false;

            ResetPageCats();
        }

        //BTN FIRST PAGE - CATEGORIAS
        private void BtnFirstPagCat_Click(object sender, EventArgs e)
        {
            current_cat = 0;
            current_page_cat = 1;
            labelCurrentPagCat.Text = current_page_cat.ToString();
            PaginarCategorias(categorias_filtradas);
        }

        //BTN PREV PAGE - CATEGORIAS
        private void BtnPrevPagCat_Click(object sender, EventArgs e)
        {
            if (current_cat + 1 > paginador_cat)
            {
                current_cat -= paginador_cat;
                current_page_cat--;
            }

            labelCurrentPagCat.Text = current_page_cat.ToString();
            PaginarCategorias(categorias_filtradas);
        }

        //BTN NEXT PAGE - CATEGORIAS
        private void BtnNextPagCat_Click(object sender, EventArgs e)
        {
            current_cat += paginador_cat;
            current_page_cat++;
            labelCurrentPagCat.Text = current_page_cat.ToString();
            PaginarCategorias(categorias_filtradas);
        }

        //BTN LAST PAGE - CATEGORIAS
        private void BtnLastPagCat_Click(object sender, EventArgs e)
        {
            current_cat = total_cats;
            current_page_cat = last_page_cats;
            labelCurrentPagCat.Text = current_page_cat.ToString();
            PaginarCategorias(categorias_filtradas);
        }





    }
}
