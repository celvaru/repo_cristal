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
    public partial class form_inventario : Form
    {
        public form_inventario()
        {
            InitializeComponent();
        }

        private void form_inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'set_comercial_cristal.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.set_comercial_cristal.Producto);

        }
    }
}
