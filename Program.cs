using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_Cristal
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_login());
        }

        public static string usuario_activo;
        public static string usuario_tipo;

        //Validar numeros
        public bool numeros(string cadena, int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                if (cadena[i] < 48 || cadena[i] > 57)
                {
                    return false;
                }
            }
            return true;
        }
        //Validar texto
        public bool texto(string cadena, int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                if ((cadena[i] < 65 && cadena[i] != 32) || (cadena[i] > 90 && cadena[i] < 97) || cadena[i] > 122)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
