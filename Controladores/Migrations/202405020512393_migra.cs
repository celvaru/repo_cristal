namespace Controladores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migra : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Detalles", "codigo", "dbo.Colors");
            DropForeignKey("dbo.Colors", "nombre_producto", "dbo.Productoes");
            DropForeignKey("dbo.Usuarios", "Administrador_ci", "dbo.Usuarios");
            DropForeignKey("dbo.Usuarios", "Cajero_ci", "dbo.Usuarios");
            DropIndex("dbo.Usuarios", new[] { "Administrador_ci" });
            DropIndex("dbo.Usuarios", new[] { "Cajero_ci" });
            DropIndex("dbo.Colors", new[] { "nombre_producto" });
            DropPrimaryKey("dbo.Productoes");
            AddColumn("dbo.Productoes", "codigo", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Productoes", "color", c => c.String(nullable: false));
            AddColumn("dbo.Productoes", "metros", c => c.Double(nullable: false));
            AddColumn("dbo.Productoes", "rollos", c => c.Int(nullable: false));
            AlterColumn("dbo.Productoes", "nombre_producto", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Productoes", "codigo");
            CreateIndex("dbo.Ventas", "ci");
            AddForeignKey("dbo.Detalles", "codigo", "dbo.Productoes", "codigo", cascadeDelete: true);
            AddForeignKey("dbo.Ventas", "ci", "dbo.Usuarios", "ci", cascadeDelete: true);
            DropColumn("dbo.Usuarios", "Discriminator");
            DropColumn("dbo.Usuarios", "Administrador_ci");
            DropColumn("dbo.Usuarios", "Cajero_ci");
            DropTable("dbo.Colors");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.codigo);
            
            AddColumn("dbo.Usuarios", "Cajero_ci", c => c.Int());
            AddColumn("dbo.Usuarios", "Administrador_ci", c => c.Int());
            AddColumn("dbo.Usuarios", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Ventas", "ci", "dbo.Usuarios");
            DropForeignKey("dbo.Detalles", "codigo", "dbo.Productoes");
            DropIndex("dbo.Ventas", new[] { "ci" });
            DropPrimaryKey("dbo.Productoes");
            AlterColumn("dbo.Productoes", "nombre_producto", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Productoes", "rollos");
            DropColumn("dbo.Productoes", "metros");
            DropColumn("dbo.Productoes", "color");
            DropColumn("dbo.Productoes", "codigo");
            AddPrimaryKey("dbo.Productoes", "nombre_producto");
            CreateIndex("dbo.Colors", "nombre_producto");
            CreateIndex("dbo.Usuarios", "Cajero_ci");
            CreateIndex("dbo.Usuarios", "Administrador_ci");
            AddForeignKey("dbo.Usuarios", "Cajero_ci", "dbo.Usuarios", "ci");
            AddForeignKey("dbo.Usuarios", "Administrador_ci", "dbo.Usuarios", "ci");
            AddForeignKey("dbo.Colors", "nombre_producto", "dbo.Productoes", "nombre_producto", cascadeDelete: true);
            AddForeignKey("dbo.Detalles", "codigo", "dbo.Colors", "codigo", cascadeDelete: true);
        }
    }
}
