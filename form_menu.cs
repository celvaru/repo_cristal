using Comercial_Cristal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
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
            mostrar_forms(new form_principal());

        }

        private Form form_activo = null;
        
        //Alternamos la vista de los formularios
        private void mostrar_forms(Form formhijo)
        {
            if (form_activo != null)
                form_activo.Close();
            if(formhijo.Name != "form_principal")
                btn_menu.Enabled = true;
            form_activo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(formhijo);
            panel_principal.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();

        }
        //hace que todas las pestañas del menu estén sin seleccionar
        private void color_base()
        {
            if(btn_datos.BackColor != Color.DeepSkyBlue)
            {
                btn_datos.BackColor = Color.DeepSkyBlue;
                btn_datos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
                btn_datos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
                btn_datos.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            if (btn_hventas.BackColor != Color.DeepSkyBlue)
            {
                btn_hventas.BackColor = Color.DeepSkyBlue;
                btn_hventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
                btn_hventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
                btn_hventas.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
                
            if (btn_inventario.BackColor != Color.DeepSkyBlue)
            {
                btn_inventario.BackColor = Color.DeepSkyBlue;
                btn_inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
                btn_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
                btn_inventario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
               
            if (btn_usuario.BackColor != Color.DeepSkyBlue)
            {
                btn_usuario.BackColor = Color.DeepSkyBlue;
                btn_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
                btn_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
                btn_usuario.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
                
        }
        //alterna la selección de las pestañas del menu
        private void seleccionar_boton(Button seleccion)
        {
            if (seleccion.BackColor == Color.DeepSkyBlue)
            {
                color_base();
                seleccion.BackColor = Color.LightCyan;
                seleccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
                seleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
                seleccion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btn_datos_Click(object sender, EventArgs e)
        {
            mostrar_forms(new form_datos());
            seleccionar_boton(btn_datos);
        }

        private void btn_hventas_Click(object sender, EventArgs e)
        {
            mostrar_forms(new form_hventas());
            seleccionar_boton(btn_hventas);
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            mostrar_forms(new form_inventario());
            seleccionar_boton(btn_inventario);
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            mostrar_forms(new form_usuario());
            seleccionar_boton(btn_usuario);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            mostrar_forms(new form_principal());
            color_base();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //botones del menu



    }
}
