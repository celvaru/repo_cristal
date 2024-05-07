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
    public partial class form_inventario : Form
    {
        public form_inventario()
        {
            InitializeComponent();
        }

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);


        private void form_inventario_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter1.Fill(this.set_producto_comercial_cristal.Producto);


        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string consulta_producto = "SELECT * FROM Producto WHERE nombre_producto LIKE '" + txt_buscar.Text + "%'";
            conexion.Open();
            
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_producto, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            tabla_inventario.DataSource = dt;
            SqlCommand cmd_producto = new SqlCommand(consulta_producto, conexion);
            SqlDataReader datos = cmd_producto.ExecuteReader();

            while (datos.Read())
            {
                txt_producto.Text = datos["nombre_producto"].ToString();
                txt_codigo.Text = datos["codigo"].ToString();
                txt_precio.Text = datos["precio"].ToString();
                txt_ancho.Text = datos["ancho"].ToString();
                txt_metros_rollo.Text = datos["metro_rollo"].ToString();
                txt_metros.Text = datos["metros"].ToString();
                txt_rollos.Text = datos["rollos"].ToString();
            }

            datos.Close();

            conexion.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            string consulta_producto = "SELECT * FROM Producto";
            conexion.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta_producto, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            tabla_inventario.DataSource = dt;
            conexion.Close();

            txt_buscar.Text = "";
            txt_producto.Text = "";
            txt_codigo.Text = "";
            txt_precio.Text = "";
            txt_ancho.Text = "";
            txt_metros_rollo.Text = "";
            txt_metros.Text = "";
            txt_rollos.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?\nEsta acción no se puede deshacer", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.OK)
            {
                conexion.Open();
                string codigo = tabla_inventario.CurrentRow.Cells[0].Value.ToString();
                string consulta_producto = "DELETE FROM Producto WHERE codigo =" +codigo;
                SqlCommand cmd_producto = new SqlCommand(consulta_producto, conexion);
                cmd_producto.ExecuteNonQuery();

                consulta_producto = "SELECT * FROM Producto";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta_producto, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabla_inventario.DataSource = dt;
                conexion.Close();


            }

        }



    }
}
