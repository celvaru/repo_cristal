using Comercial_Cristal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeluCenter.Vistas
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }
        private Form formactivo = null;
        //Alternamos la vista de los formularios
        private void mostrar_forms(Form formhijo)
        {
            if (formactivo != null)
                formactivo.Close();
            formactivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(formhijo);
            panel_principal.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();

        }

        private void btn_ncompra_Click(object sender, EventArgs e)
        {
            mostrar_forms(new form_compra());
        }

        private void btn_nventa_Click(object sender, EventArgs e)
        {
            mostrar_forms(new form_venta());
        }
        //botones del menu



    }
}
