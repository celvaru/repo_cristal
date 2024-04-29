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
    public partial class form_datos : Form
    {
        public form_datos()
        {
            InitializeComponent();
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            form_password form_password = new form_password();
            form_password.Show();
        }
    }
}
