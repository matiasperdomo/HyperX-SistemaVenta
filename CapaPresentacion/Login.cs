using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text).FirstOrDefault();


            if (ousuario != null && ousuario.Estado != false)
            {

                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;

            }
            else if(ousuario != null && ousuario.Estado == false){
                MessageBox.Show("Su usuario se encuentra inactivo. Debe comunicarse con el administrador para solicitar nuevamente su alta","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            

        }

        private void frm_closing(object sender, FormClosingEventArgs e) {

            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }


        //MOSTRAR/OCULTAR CONTRASEÑA
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtclave.PasswordChar == '*')
                {
                    txtclave.PasswordChar = '\0';
                }
            }
            else
            {
                txtclave.PasswordChar = '*';
            }
        }
    }
}
