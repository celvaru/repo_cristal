using CeluCenter.Vistas;
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
    public partial class form_compra : Form
    {
        public form_compra()
        {
            InitializeComponent();
            habilitar_campos();
        }
        //Habilitar/deshabilitar campos
        private void habilitar_campos()
        {
            if(combo_producto.SelectedItem == "Nuevo producto")
            {
                txt_producto.Text = "";
                txt_codigo.Text = "";
                txt_metros_rollo.Text = "";
                txt_ancho.Text = "";
                txt_precio.Text = "";
                txt_rollos.Text = "";

                txt_producto.Enabled = true;
                txt_metros_rollo.Enabled = true;
                txt_precio.Enabled = true;
                txt_ancho.Enabled = true;
                btn_registrar.Enabled = true;
                btn_actualizar.Enabled = false;
            }

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
        Program program = new Program();
        //Validar compra
        public bool validar_compra()
        {
            if(combo_producto.SelectedIndex == 0
                || txt_rollos.Text == ""
                || program.numeros(txt_rollos.Text, txt_rollos.TextLength) == false)
            {
                return false;
            }
            return true;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if(validar_compra())
            {
               // string script_actualizar = "Update Color set Rollos = '""', ";
                //SqlConnection conexion = new SqlConnection("server= (localdb)\\ServidorCeleste ; database= Cristal ; integrated security= true");
                //SqlCommand comando = new SqlCommand(script_actualizar, conexion);
            }
            else
            {
                MessageBox.Show("Por favor, introduzca todos los datos correctamente", "COMERCIAL CRISTAL - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
