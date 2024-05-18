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
    public partial class form_cliente : Form
    {
        public form_cliente()
        {
            InitializeComponent();
        }

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);

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

        private void form_cliente_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.set_cilente_comercial_cristal.Cliente);

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar el usuario seleccionado?\nEsta acción no se puede deshacer",
                                        "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                conexion.Open();
                string ci = tabla_cliente.CurrentRow.Cells[0].Value.ToString();
                string consulta_cliente = "DELETE FROM Cliente WHERE ci_cliente =" + ci;
                SqlCommand cmd_cliente = new SqlCommand(consulta_cliente, conexion);
                cmd_cliente.ExecuteNonQuery();

                consulta_cliente = "SELECT * FROM Cliente";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta_cliente, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabla_cliente.DataSource = dt;
                conexion.Close();


            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(txt_nombre.Text != "" && txt_ci.Text != "")
            {
                conexion.Open();
                string ci = tabla_cliente.CurrentRow.Cells[0].Value.ToString();
                string consulta_cliente = "INSERT INTO Cliente VALUES ("+txt_ci.Text+",'"+ txt_nombre.Text + "')";
                SqlCommand cmd_cliente = new SqlCommand(consulta_cliente, conexion);
                cmd_cliente.ExecuteNonQuery();

                consulta_cliente = "SELECT * FROM Cliente";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta_cliente, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabla_cliente.DataSource = dt;
                conexion.Close();
            }
        }
    }
}
