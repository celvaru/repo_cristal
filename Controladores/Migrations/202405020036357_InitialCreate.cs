namespace Controladores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ci = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        apellido = c.String(nullable: false),
                        telefono = c.Int(nullable: false),
                        nom_usuario = c.String(nullable: false),
                        password = c.String(nullable: false),
                        cargo = c.String(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Administrador_ci = c.Int(),
                        Cajero_ci = c.Int(),
                    })
                .PrimaryKey(t => t.ci)
                .ForeignKey("dbo.Usuarios", t => t.Administrador_ci)
                .ForeignKey("dbo.Usuarios", t => t.Cajero_ci)
                .Index(t => t.Administrador_ci)
                .Index(t => t.Cajero_ci);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ci_cliente = c.Int(nullable: false, identity: true),
                        nombre_cliente = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ci_cliente);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        num_venta = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        total = c.Double(nullable: false),
                        ci = c.Int(nullable: false),
                        ci_cliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.num_venta)
                .ForeignKey("dbo.Clientes", t => t.ci_cliente, cascadeDelete: true)
                .Index(t => t.ci_cliente);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        num_venta = c.Int(nullable: false, identity: true),
                        cantidad = c.Double(nullable: false),
                        subtotal = c.Double(nullable: false),
                        codigo = c.Int(nullable: false),
                        Venta_num_venta = c.Int(),
                    })
                .PrimaryKey(t => t.num_venta)
                .ForeignKey("dbo.Colors", t => t.codigo, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.Venta_num_venta)
                .Index(t => t.codigo)
                .Index(t => t.Venta_num_venta);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        codigo = c.Int(nullable: false, identity: true),
                        nombre_color = c.String(),
                        metros = c.Double(nullable: false),
                        rollos = c.Int(nullable: false),
                        nombre_producto = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.codigo)
                .ForeignKey("dbo.Productoes", t => t.nombre_producto, cascadeDelete: true)
                .Index(t => t.nombre_producto);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        nombre_producto = c.String(nullable: false, maxLength: 128),
                        ancho = c.Double(nullable: false),
                        metro_rollo = c.Int(nullable: false),
                        precio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.nombre_producto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Cajero_ci", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "Administrador_ci", "dbo.Usuarios");
            DropForeignKey("dbo.Detalles", "Venta_num_venta", "dbo.Ventas");
            DropForeignKey("dbo.Colors", "nombre_producto", "dbo.Productoes");
            DropForeignKey("dbo.Detalles", "codigo", "dbo.Colors");
            DropForeignKey("dbo.Ventas", "ci_cliente", "dbo.Clientes");
            DropIndex("dbo.Colors", new[] { "nombre_producto" });
            DropIndex("dbo.Detalles", new[] { "Venta_num_venta" });
            DropIndex("dbo.Detalles", new[] { "codigo" });
            DropIndex("dbo.Ventas", new[] { "ci_cliente" });
            DropIndex("dbo.Usuarios", new[] { "Cajero_ci" });
            DropIndex("dbo.Usuarios", new[] { "Administrador_ci" });
            DropTable("dbo.Productoes");
            DropTable("dbo.Colors");
            DropTable("dbo.Detalles");
            DropTable("dbo.Ventas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Usuarios");
        }
    }
}
