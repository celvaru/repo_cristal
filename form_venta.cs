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
    public partial class form_venta : Form
    {
        public form_venta()
        {
            InitializeComponent();
        }

        private void ncliente_btn_Click(object sender, EventArgs e)
        {
            form_cliente form_cliente = new form_cliente();
            form_cliente.Show();
        }
    }
}
