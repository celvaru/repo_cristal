using Modelos;
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
    public partial class form_datos : Form
    {

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);
        public form_datos()
        {
            InitializeComponent();
            ver_datos();
        }

        private void ver_datos()
        {
            label_cargo.Text = Program.usuario_tipo;
            txt_ci.Text = Program.usuario_activo;

            string consulta_usuario = "SELECT * FROM Usuario WHERE ci = '" + Program.usuario_activo + "'";
            conexion.Open();
            SqlCommand cmd_usuario = new SqlCommand(consulta_usuario, conexion);
            SqlDataReader datos = cmd_usuario.ExecuteReader();
            datos.Read();
            label_usuario.Text = datos["nom_usuario"].ToString();
            txt_nombres.Text = datos["nombre"].ToString();
            txt_apellidos.Text = datos["apellido"].ToString();
            txt_telefono.Text = datos["telefono"].ToString();
            datos.Close();
            conexion.Close();
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            form_password form_password = new form_password();
            form_password.Show();
        }
    }
}
