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
    public partial class form_hventas : Form
    {
        public form_hventas()
        {
            InitializeComponent();
            inicia_combo();
        }

        string consulta;
        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);

        private void form_hventas_Load(object sender, EventArgs e)
        {
            this.ventaTableAdapter.Fill(this.set_ventas_comercial_cristal.Venta);

        }

        //Iniciar combo
        public void inicia_combo()
        {
            combo_buscar.SelectedIndex = 0;
        }

        //Asignar tipo de busqueda
        public void tipo_busqueda()
        {
            switch (combo_buscar.SelectedIndex)
            {
                case 0: consulta = "num_venta ="; break;
                case 1: consulta = "ci_cliente LIKE"; break;
                default: MessageBox.Show("Por favor seleccione una de las opciones", "COMERCIAL CRISTAL - Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta_producto = "SELECT * FROM Venta WHERE " + consulta + " '" + txt_buscar.Text + "%'";
            conexion.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_producto, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            tabla_ventas.DataSource = dt;
            SqlCommand cmd_producto = new SqlCommand(consulta_producto, conexion);
            SqlDataReader datos = cmd_producto.ExecuteReader();

            datos.Close();

            conexion.Close();
        }
    }
}
