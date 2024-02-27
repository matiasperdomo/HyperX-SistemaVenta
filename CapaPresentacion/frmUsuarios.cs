using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        //INICIALIZANDO TODAS LAS VARIABLES
        private static readonly Usuario filtroUsu = new Usuario();

        //PESTAÑA DE USUARIOS
        private List<Usuario> usuarios_completos = new List<Usuario>();
        private List<Usuario> usuarios_filtrados = new List<Usuario>();
        private List<Usuario> usuarios_paginados = new List<Usuario>();

        private int current_usu = 0;
        private int paginador_usu = 5;
        private int total_usua = 0;
        private int last_page_usua = 0;
        private int current_page_usu = 1;
        private int usuarios_totales_usu = 0;
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombosUsu();
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            //MOSTRAR TODOS LOS USUARIOS
            List<Usuario> lista = new CN_Usuario().Listar();
            usuarios_completos = lista;
            usuarios_filtrados = lista;
            total_usua = usuarios_completos.Count;
            last_page_usua = total_usua / paginador_usu;
            usuarios_totales_usu = usuarios_completos.Count;
            PaginarUsuarios(lista);




            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol) {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;

        }

        private void VisualizarUsuarios(List<Usuario> listaUsuarios)
        {
            //MOSTRAR TODOS LOS USUARIOS
            dgvdata.Rows.Clear();

            foreach (Usuario item in listaUsuarios)
            {

                int rowIndex = dgvdata.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1 : 0 ,
                    item.Estado == true ? "Activo" : "No Activo"
                });

                //SI EL ESTADO DEL USUARIO ES INACTIVO, PINTAR LAS CELDAS DE GRIS
                if (item.Estado == false)
                {
                    dgvdata.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Gray;
                }
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario() {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] {"",idusuariogenerado,txtdocumento.Text,txtnombrecompleto.Text,txtcorreo.Text,txtclave.Text,
                ((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
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
            else {
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Clave"].Value = txtclave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cborol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else {
                    MessageBox.Show(mensaje);
                }
            }


          
           
           
        }


        private void Limpiar() {

            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            txtdocumento.Select();
            FiltrarUsua2();

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0) {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x,y,w,h));
                e.Handled = true;
            }

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar") {

                int indice = e.RowIndex;

                if (indice >= 0) {

                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();


                    foreach (OpcionCombo oc in cborol.Items) {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value)) {
                            int indice_combo = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice_combo;
                            break;
                        }
                    }


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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0) {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
                    }
                    else {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        //LLENAR LOS COMBOBOX - USUARIOS
        private void LlenarCombosUsu()
        {
            LlenarComboPagsUsu();
            LlenarComboEstadoUsu();
            LlenarComboRolUsu();
        }

        //LLENADO DE COMBOBOX PAGINAS - USUARIOS
        private void LlenarComboPagsUsu()
        {
            comboPagsUsu.Items.Add("5");
            comboPagsUsu.Items.Add("10");
            comboPagsUsu.Items.Add("20");
            comboPagsUsu.SelectedItem = "5";
        }

        //LENADO DEL COMBO ESTADO - USUARIOS
        private void LlenarComboEstadoUsu()
        {
            cmbEstadoUsu.Items.Add("Activo");
            cmbEstadoUsu.Items.Add("Inactivo");
        }

        //LENADO DEL COMBO ROL - USUARIOS
        private void LlenarComboRolUsu()
        {
            cmbRolUsu.Items.Add("ADMINISTRADOR");
            cmbRolUsu.Items.Add("EMPLEADO");
        }

        public void PaginarUsuarios(List<Usuario> usuaMostrar)
        {
            usuarios_paginados = usuaMostrar.Skip(current_usu).Take(paginador_usu).ToList();
            VisualizarUsuarios(usuarios_paginados);
            labelMostrandoUsu.Text = "Mostrando " + (current_usu + paginador_usu) + " de " + total_usua;

            //SI LA PAGINA ACTUAL ES LA PRIMERA
            if (current_page_usu == 1)
            {
                btnFirstPagUsu.Hide();
                btnPrevPagUsu.Hide();
            }
            else
            {
                btnFirstPagUsu.Show();
                btnPrevPagUsu.Show();
            }

            //SI LA PAGINA ACTUAL SE ENCUENTRA EN LA ULTIMA PAGINA
            if (current_page_usu == last_page_usua)
            {
                btnLastPagUsu.Hide();
                btnNextPagUsu.Hide();
            }
            else
            {
                btnLastPagUsu.Show();
                btnNextPagUsu.Show();
            }

            //SI LA PAGINA ACTUAL TIENE TODOS LOS PRODUCTOS, NO MOSTRAR LA PROXIMA PAGINA
            if ((current_usu + paginador_usu) < total_usua)
            {
                btnLastPagUsu.Show();
                btnNextPagUsu.Show();
            }
            else
            {
                btnLastPagUsu.Hide();
                btnNextPagUsu.Hide();
            }
        }

        //FILTRADO - USUARIOS2
        private void FiltrarUsua2()
        {
            List<Usuario> lista = new CN_Usuario().Listar();
            usuarios_completos = lista;
            usuarios_filtrados = lista;
            usuarios_filtrados = usuarios_completos;

            if (filtroUsu.Documento != null)
            {
                usuarios_filtrados = usuarios_completos.Where(x => x.Documento.ToLower().Contains(filtroUsu.Documento)).ToList();
            }

            if (filtroUsu.NombreCompleto != null)
            {
                usuarios_filtrados = usuarios_completos.Where(x => x.NombreCompleto.ToLower().Contains(filtroUsu.NombreCompleto)).ToList();
            }

            if (filtroUsu.Correo != null)
            {
                usuarios_filtrados = usuarios_completos.Where(x => x.Correo.ToLower().Contains(filtroUsu.Correo)).ToList();
            }


            if (cmbEstadoUsu.SelectedItem != null)
            {
                if (filtroUsu.Estado == true)
                {
                    usuarios_filtrados = usuarios_filtrados.Where(x => x.Estado == true).ToList();
                }
                if (filtroUsu.Estado == false)
                {
                    usuarios_filtrados = usuarios_filtrados.Where(x => x.Estado == false).ToList();
                }
            }


            total_usua = usuarios_filtrados.Count;
            last_page_usua = (total_usua / paginador_usu) + 1;
            current_usu = 0;
            current_page_usu = 1;

            PaginarUsuarios(usuarios_filtrados);
        }


        //FILTRADO - USUARIOS
        private void FiltrarUsua()
        {
            if (filtroUsu.Documento != null)
            {
                usuarios_filtrados = usuarios_completos.Where(x => x.Documento.ToLower().Contains(filtroUsu.Documento)).ToList();
            }

            if (filtroUsu.NombreCompleto != null)
            {
                usuarios_filtrados = usuarios_completos.Where(x => x.NombreCompleto.ToLower().Contains(filtroUsu.NombreCompleto)).ToList();
            }

            if (filtroUsu.Correo != null)
            {
                usuarios_filtrados = usuarios_completos.Where(x => x.Correo.ToLower().Contains(filtroUsu.Correo)).ToList();
            }


            total_usua = usuarios_filtrados.Count;
            last_page_usua = (total_usua / paginador_usu) + 1;
            current_usu = 0;
            current_page_usu = 1;

            PaginarUsuarios(usuarios_filtrados);
        }

        //VOLVER A VALORES PREDETERMINADOS LA PAGINA - USUARIOS
        private void ResetPageUsua()
        {
            current_usu = 0;
            current_page_usu = 1;
            labelCurrentPagUsu.Text = current_page_usu.ToString();
            total_usua = usuarios_totales_usu;
            last_page_usua = (total_usua / paginador_usu) + 1;
            FiltrarUsua2();
        }

        //COMBO PAGINACION - USUARIOS
        private void ComboPagsUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginador_usu = int.Parse(comboPagsUsu.SelectedItem.ToString());
            current_usu = 0;
            current_page_usu = 1;
            labelCurrentPagUsu.Text = current_page_usu.ToString();
            last_page_usua = (total_usua / paginador_usu) + 1;

            if (filtroUsu.Documento != null || filtroUsu.NombreCompleto != null || filtroUsu.Correo != null)
            {
                PaginarUsuarios(usuarios_filtrados);
            }
            else
            {
                ResetPageUsua();
            }
        }

        //FILTRAR POR DOCUMENTO - USUARIOS
        private void TxtDocumentoUsu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumentoUsu.Text))
            {
                //LIMPIAMOS EL FILTRO
                filtroUsu.Documento = null;
                FiltrarUsua2();
            }
            else
            {
                string documentoFiltrar = txtDocumentoUsu.Text.ToString().ToLower();
                filtroUsu.Documento = documentoFiltrar;
                FiltrarUsua2();
            }
        }

        //LIMPIAR FILTRO DE DOCUMENTO - USUARIOS
        private void BtnCloseDocumentoUsua_Click(object sender, EventArgs e)
        {
            txtDocumentoUsu.Text = null;
            filtroUsu.Documento = null;
            FiltrarUsua();
        }

        //FILTRAR POR NOMBRE - USUARIOS
        private void TxtNombreUsu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsu.Text))
            {
                //LIMPIAMOS EL FILTRO
                filtroUsu.NombreCompleto = null;
                FiltrarUsua2();
            }
            else
            {
                string nombreFiltrar = txtNombreUsu.Text.ToString().ToLower();
                filtroUsu.NombreCompleto = nombreFiltrar;
                FiltrarUsua2();
            }
        }

        //LIMPIAR FILTRO DE NOMBRE - USUARIOS
        private void BtnCloseNombreUsua_Click(object sender, EventArgs e)
        {
            txtNombreUsu.Text = null;
            filtroUsu.NombreCompleto = null;
            FiltrarUsua();
        }

        //FILTRAR POR CORREO - USUARIOS
        private void TxtCorreoUsu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreoUsu.Text))
            {
                //LIMPIAMOS EL FILTRO
                filtroUsu.Correo = null;
                FiltrarUsua2();
            }
            else
            {
                string correoFiltrar = txtCorreoUsu.Text.ToString().ToLower();
                filtroUsu.Correo = correoFiltrar;
                FiltrarUsua2();
            }
        }

        //LIMPIAR FILTRO DE CORREO - USUARIOS
        private void BtnCloseCorreoUsua_Click(object sender, EventArgs e)
        {
            txtCorreoUsu.Text = null;
            filtroUsu.Correo = null;
            FiltrarUsua();
        }

        //BTN FILTRAR POR ROL - USUARIOS
        private void CmbRolUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRolUsu.SelectedItem != null)
            {
                string rolFiltrar = cmbRolUsu.SelectedItem.ToString();
                if (rolFiltrar == "ADMINISTRADOR")
                {
                    filtroUsu.oRol.IdRol = 1;
                }
                if (rolFiltrar == "EMPLEADO")
                {
                    filtroUsu.oRol.IdRol = 2;
                }
                FiltrarUsua2();
            }
        }

        //LIMPIAR FILTRO DE ROL - USUARIOS
        private void BtnCloseRolUsua_Click(object sender, EventArgs e)
        {
            cmbRolUsu.SelectedItem = null;
            //filtroUsu.oRol.IdRol = ;
            FiltrarUsua();
        }


        //BTN FILTRAR POR ESTADO - USUARIOS
        private void CmbEstadoUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoUsu.SelectedItem != null)
            {
                string estadoFiltrar = cmbEstadoUsu.SelectedItem.ToString();
                if (estadoFiltrar == "Activo")
                {
                    filtroUsu.Estado = true;
                }
                if (estadoFiltrar == "Inactivo")
                {
                    filtroUsu.Estado = false;
                }
                FiltrarUsua2();
            }
        }

        //LIMPIAR FILTRO DE ESTADO - USUARIOS
        private void BtnCloseEstadoUsua_Click(object sender, EventArgs e)
        {
            cmbEstadoUsu.SelectedItem = null;
            filtroUsu.Estado = false;
            FiltrarUsua2();
        }

        //BTN LIMPIAR FILTROS - USUARIOS
        private void BtnLimpiarFiltrosUsu_Click(object sender, EventArgs e)
        {
            txtDocumentoUsu.Text = null;
            txtNombreUsu.Text = null;
            txtCorreoUsu.Text = null;
            cmbEstadoUsu.SelectedItem = null;
            filtroUsu.Documento = null;
            filtroUsu.NombreCompleto = null;
            filtroUsu.Correo = null;
            filtroUsu.Estado = false;

            ResetPageUsua();
        }

        //BTN FIRST PAGE - USUARIOS
        private void BtnFirstPagCat_Click(object sender, EventArgs e)
        {
            current_usu = 0;
            current_page_usu = 1;
            labelCurrentPagUsu.Text = current_page_usu.ToString();
            PaginarUsuarios(usuarios_filtrados);
        }

        //BTN PREV PAGE - USUARIOS
        private void BtnPrevPagCat_Click(object sender, EventArgs e)
        {
            if (current_usu + 1 > paginador_usu)
            {
                current_usu -= paginador_usu;
                current_page_usu--;
            }

            labelCurrentPagUsu.Text = current_page_usu.ToString();
            PaginarUsuarios(usuarios_filtrados);
        }

        //BTN NEXT PAGE - USUARIOS
        private void BtnNextPagCat_Click(object sender, EventArgs e)
        {
            current_usu += paginador_usu;
            current_page_usu++;
            labelCurrentPagUsu.Text = current_page_usu.ToString();
            PaginarUsuarios(usuarios_filtrados);
        }

        //BTN LAST PAGE - USUARIOS
        private void BtnLastPagCat_Click(object sender, EventArgs e)
        {
            current_usu = total_usua;
            current_page_usu = last_page_usua;
            labelCurrentPagUsu.Text = current_page_usu.ToString();
            PaginarUsuarios(usuarios_filtrados);
        }



    }
}
