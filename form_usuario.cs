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
    public partial class form_usuario : Form
    {
        public form_usuario()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(tabla_usuarios.SelectedRows.Count == 1)
            {
                MessageBox.Show("¿Está seguro de eliminar el usuario seleccionado?\nEsta acción no se puede deshacer","Confirmación",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un usuario","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
