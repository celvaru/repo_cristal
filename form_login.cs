using Comercial_Cristal;
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
        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);

        public form_login()
        {
            InitializeComponent();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Validar datos de inicio de sesion
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Controladores.login_controler login_controler = new Controladores.login_controler();
            string usuario = txt_usuario.Text;
            string password = txt_password.Text;
            string consulta_log = "SELECT * FROM Usuario WHERE nom_usuario = '" + usuario + "' AND password = '" + password+"'";
            conexion.Open();
            SqlCommand cmd = new SqlCommand(consulta_log, conexion);
            SqlDataReader log = cmd.ExecuteReader();

            if (log.Read())
            {
                this.Hide();
                form_menu form_menu = new form_menu();
                form_menu.Show();
                form_menu.FormClosing += cerrar_principal;
                log.Close();

                string consulta_usuario = "SELECT * FROM Usuario WHERE nom_usuario = '" + usuario + "' AND password = '" + password + "'";
                SqlCommand cmd_usuario = new SqlCommand(consulta_usuario, conexion);
                SqlDataReader ci = cmd_usuario.ExecuteReader();
                ci.Read();
                Program.usuario_activo = ci["ci"].ToString();
                Program.usuario_tipo = ci["cargo"].ToString();
                ci.Close();

                conexion.Close();
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un usuario y contraseña válidos",
                                "COMERCIAL CRISTAL - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
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
