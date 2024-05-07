using Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Detalle> Detalle { get; set; }
        public DbSet<Producto> Producto { get; set; }
    }
}
