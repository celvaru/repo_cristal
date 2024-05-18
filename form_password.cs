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

namespace Comercial_Cristal
{
    public partial class form_password : Form
    {
        public form_password()
        {
            InitializeComponent();
            ver_datos();
        }

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);

        //Ver usuario
        private void ver_datos()
        {

            string consulta_usuario = "SELECT * FROM Usuario WHERE ci = '" + Program.usuario_activo + "'";
            conexion.Open();
            SqlCommand cmd_usuario = new SqlCommand(consulta_usuario, conexion);
            SqlDataReader datos = cmd_usuario.ExecuteReader();
            datos.Read();
            label_usuario.Text = datos["nom_usuario"].ToString();
            datos.Close();

            conexion.Close();
        }

        //Cerrar ventana al cerrar sesión de usuario 
        private void cerrar_salida(object sender, EventArgs e)
        {
            form_menu form_menu = new form_menu();
            form_menu.FormClosing += cerrar_ventana;
        }
        private void cerrar_ventana(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
