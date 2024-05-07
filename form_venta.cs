using CeluCenter.Vistas;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Comercial_Cristal
{
    public partial class form_venta : Form
    {
        public form_venta()
        {
            InitializeComponent();
            date_fecha.Value = DateTime.Today;
            label_total.Text = total_venta.ToString();
            form_venta_Load();
            combo_ci.SelectedIndex = 0;
        }

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);
        int total_venta = 0;
        string cant = "";

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

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            form_cliente form_cliente = new form_cliente();
            form_cliente.Show();
        }

        private void form_venta_Load()
        {
            this.clienteTableAdapter.Fill(this.ci_cliente_set_comercial_cristal.Cliente);

            string consulta_ci = "SELECT * FROM Cliente";
            conexion.Open();
            SqlCommand cmd_ci = new SqlCommand(consulta_ci, conexion);
            SqlDataReader datos = cmd_ci.ExecuteReader();
            while (datos.Read())
            {
                combo_ci.Items.Add(datos["ci_cliente"]);
            }
            datos.Close();

            string consulta_producto = "SELECT * FROM Producto";
            SqlCommand cmd_producto = new SqlCommand(consulta_producto, conexion);
            datos = cmd_producto.ExecuteReader();
            while (datos.Read())
            {
                combo_producto.Items.Add(datos["nombre_producto"]);
            }
            datos.Close();

            string consulta_num = "SELECT MAX(num_venta) FROM Venta";
            SqlCommand cmd_num_venta = new SqlCommand(consulta_num, conexion);
            SqlDataReader num = cmd_num_venta.ExecuteReader();
            num.Read();
            label_nro_venta.Text = Convert.ToString(num.GetInt32(0) + 1);
            num.Close();
            conexion.Close();
        }

        private void combo_ci_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta_cliente = "SELECT * FROM Cliente WHERE ci_cliente = '" + combo_ci.Text + "'";
            SqlCommand cmd_cliente = new SqlCommand(consulta_cliente, conexion);
            SqlDataReader cliente = cmd_cliente.ExecuteReader();
            while (cliente.Read())
            {
                txt_cliente.Text = cliente["nombre_cliente"].ToString();
            }
            cliente.Close();

            conexion.Close();
        }

        private void combo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta_codigo = "SELECT * FROM Producto WHERE nombre_producto = '" + combo_producto.SelectedItem + "'";
            conexion.Open();
            SqlCommand cmd_codigo = new SqlCommand(consulta_codigo, conexion);
            SqlDataReader codigo = cmd_codigo.ExecuteReader();
            while (codigo.Read())
            {
                txt_codigo.Text = codigo["codigo"].ToString();
                txt_precio.Text = codigo["precio"].ToString();
                cant = codigo["precio"].ToString();
                txt_subtotal.Text = Convert.ToString(Convert.ToDecimal(cant) * Convert.ToDecimal(txt_cantidad.Text));
            }
            codigo.Close();
            conexion.Close();
        }

        private void txt_cantidad_ValueChanged(object sender, EventArgs e)
        {
            txt_subtotal.Text = Convert.ToString(Convert.ToDecimal(cant) * Convert.ToDecimal(txt_cantidad.Value));
        }

        private void btn_aumentar_Click(object sender, EventArgs e)
        {
            label_total.Text = total_venta.ToString();
        }
    }
}
