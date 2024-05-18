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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Comercial_Cristal
{
    public partial class form_reportes : Form
    {
        public form_reportes()
        {
            InitializeComponent();
            form_reportes_Load();
            inicia_combo();
        }

        static string conexion_cadena = "server= (localdb)\\ServidorCeleste ; database= comercial_cristal ; integrated security= true";
        SqlConnection conexion = new SqlConnection(conexion_cadena);

        //Iniciar combo
        public void inicia_combo()
        {
            combo_reporte.SelectedIndex = 0;
            combo_anio.SelectedIndex = 0;
            combo_mes.SelectedIndex = 0;
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
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_reportes_Load()
        {

            string consulta_anio = "SELECT YEAR(fecha) FROM Venta";
            conexion.Open();
            SqlCommand cmd_anio = new SqlCommand(consulta_anio, conexion);
            SqlDataReader datos = cmd_anio.ExecuteReader();
            while (datos.Read())
            {
                combo_anio.Items.Add(datos[0]);
            }
            datos.Close();
            conexion.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(combo_reporte.SelectedIndex == 0)
            {
                string consulta_ventas =    "SELECT SUM(cantidad) AS 'Metros vendidos', p.codigo AS 'Código producto', p.nombre_producto AS 'Producto' " +
                                            "FROM Detalle d, Producto p, Venta v " +
                                            "WHERE v.num_venta = d.num_venta AND d.codigo = p.codigo AND YEAR(fecha) = " + combo_anio.Text + " AND MONTH(fecha) = " + Convert.ToString(combo_mes.SelectedIndex + 1) + 
                                            "GROUP BY p.codigo, p.nombre_producto " +
                                            "ORDER BY [Metros vendidos]";
                conexion.Open();
                SqlCommand cmd_ventas = new SqlCommand(consulta_ventas, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta_ventas, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabla_reporte.DataSource = dt;
                conexion.Close();

            }
            if(combo_reporte.SelectedIndex == 1)
            {
                string consulta_ventas =    "SELECT MONTH(fecha) AS 'Mes',DAY(fecha) AS 'Día', COUNT(*) AS 'Ventas', SUM(total) AS 'Ganancias'" +
                                            "FROM Venta " +
                                            "WHERE YEAR(fecha) = " + combo_anio.Text + " AND MONTH(fecha) = " + Convert.ToString(combo_mes.SelectedIndex + 1) + 
                                            "GROUP BY MONTH(fecha),DAY(fecha)";
                conexion.Open();
                SqlCommand cmd_ventas = new SqlCommand(consulta_ventas, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta_ventas, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabla_reporte.DataSource = dt;
                conexion.Close();
            }
        }

        private void btn_documento_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "Reporte de " + combo_reporte.Text + " " + combo_mes.Text + " de " + combo_anio.Text + ".pdf";
            guardar.ShowDialog();


        }
    }
}
