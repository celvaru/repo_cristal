using Modelos.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public partial class contexto : DbContext
    {
        public contexto()
            : base("contexto")
        {
        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<Detalle> Detalle { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
    }
}
