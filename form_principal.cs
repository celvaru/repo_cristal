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
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
        }

        private void btn_ncompra_Click(object sender, EventArgs e)
        {
            form_compra form_compra = new form_compra();
            form_compra.Show();
        }

        private void btn_nventa_Click(object sender, EventArgs e)
        {
            form_venta form_venta = new form_venta();
            form_venta.Show();
        }

        private void btn_nreporte_Click(object sender, EventArgs e)
        {
            form_reportes form_reportes = new form_reportes();
            form_reportes.Show();
        }
    }
}
