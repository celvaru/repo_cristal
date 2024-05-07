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
        }

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);

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
            // TODO: esta línea de código carga datos en la tabla 'set_usuarios_comercial_cristal.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.set_usuarios_comercial_cristal.Usuario);

        }
    }
}
