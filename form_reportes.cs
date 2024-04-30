using CeluCenter.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_Cristal
{
    public partial class form_reportes : Form
    {
        public form_reportes()
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
    }
}
