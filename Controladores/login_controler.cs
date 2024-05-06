using Modelos.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controladores;
using System.Data.SqlClient;

namespace Controladores
{
    public class login_controler
    {
        contexto contexto = new contexto();
        public bool login(string usuario, string password)
        {
                var log = contexto.Usuario.Where(x => x.nom_usuario == usuario && x.password == password).SingleOrDefault();
                if (log != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}
