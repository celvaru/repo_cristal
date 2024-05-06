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
    public partial class form_hventas : Form
    {
        public form_hventas()
        {
            InitializeComponent();
        }

        private void form_hventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'set_ventas_comercial_cristal.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.set_ventas_comercial_cristal.Venta);

        }
    }
}
