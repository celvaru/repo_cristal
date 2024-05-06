using CeluCenter.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Comercial_Cristal
{
    public partial class form_login : System.Windows.Forms.Form
    {

        public form_login()
        {
            InitializeComponent();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Controladores.login_controler login_controler = new Controladores.login_controler();
            string usuario = txt_usuario.Text;
            string password = txt_password.Text;
            bool login = login_controler.login(usuario, password);
            if (login==true)
            {
                this.Hide();
                form_menu form_menu = new form_menu();
                form_menu.Show();
                form_menu.FormClosing += cerrar_principal;
            }
            else
            {
              MessageBox.Show("Por favor, introduzca un usuario y contraseña válidos", "COMERCIAL CRISTAL - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Al volver a esta pantalla los datos se borran
        private void cerrar_principal(object sender, FormClosingEventArgs e)
        {
            txt_usuario.Text = "";
            txt_password.Text = "";
            this.Show();
        }

    }
}
