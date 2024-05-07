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
    public partial class form_usuario : Form
    {
        public form_usuario()
        {
            InitializeComponent();
            inicia_combo();
        }

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);

        //Iniciar combo
        public void inicia_combo()
        {
            combo_cargo.SelectedIndex = 0;
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar el usuario seleccionado?\nEsta acción no se puede deshacer", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                conexion.Open();
                string ci = tabla_usuarios.CurrentRow.Cells[0].Value.ToString();
                string consulta_producto = "DELETE FROM Usuario WHERE ci =" + ci;
                SqlCommand cmd_producto = new SqlCommand(consulta_producto, conexion);
                cmd_producto.ExecuteNonQuery();

                consulta_producto = "SELECT * FROM Usuario";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta_producto, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabla_usuarios.DataSource = dt;
                conexion.Close();


            }

        }

        private void form_usuario_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this.set_usuarios_comercial_cristal.Usuario);

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombres.Text != "" && txt_ci.Text != "" && txt_apellidos.Text != "" && txt_telefono.Text != "" && combo_cargo.Text != "")
            {
                string pass = txt_nombres.Text[0].ToString() + txt_apellidos.Text[0].ToString() + "cristal";
                txt_usuario.Text = txt_nombres.Text.Substring(0, 3) + txt_apellidos.Text.Substring(0, 3);
                conexion.Open();
                string ci = tabla_usuarios.CurrentRow.Cells[0].Value.ToString();
                string consulta_usuario = "INSERT INTO Usuario VALUES (" + txt_ci.Text + ",'" + txt_nombres.Text + "','" + txt_apellidos.Text + "'," + txt_telefono.Text + ",'" + txt_usuario.Text + "','" + pass + "','" + combo_cargo.SelectedItem + "')";
                
                try
                {
                    SqlCommand cmd_usuario = new SqlCommand(consulta_usuario, conexion);
                    cmd_usuario.ExecuteNonQuery();
                    consulta_usuario = "SELECT * FROM Usuario";

                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta_usuario, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    tabla_usuarios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "COMERCIAL CRISTAL - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                

                
                conexion.Close();
            }
        }
    }
}
