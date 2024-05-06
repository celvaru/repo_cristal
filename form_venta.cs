using CeluCenter.Vistas;
using System;
using System.Windows.Forms;

namespace Comercial_Cristal
{
    public partial class form_venta : Form
    {
        public form_venta()
        {
            InitializeComponent();
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

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            form_cliente form_cliente = new form_cliente();
            form_cliente.Show();
        }

        //cargar datos en la tabla
        private void form_venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'producto_comercial_cristal.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.producto_comercial_cristal.Producto);
            this.detalleTableAdapter.Fill(this.detalle_comercial_cristal.Detalle);

        }
        //mostrar datos en campos
    }
}
