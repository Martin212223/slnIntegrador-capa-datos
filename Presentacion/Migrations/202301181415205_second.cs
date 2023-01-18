namespace Presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Enfermeroes", newName: "Enfermeros");
            AlterColumn("dbo.Clinicas", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Clinicas", "Domicilio", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Clinicas", "Telefono", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Clinicas", "Email", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Enfermeros", "Cuil", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enfermeros", "Cuil", c => c.String());
            AlterColumn("dbo.Clinicas", "Email", c => c.String());
            AlterColumn("dbo.Clinicas", "Telefono", c => c.String());
            AlterColumn("dbo.Clinicas", "Domicilio", c => c.String());
            AlterColumn("dbo.Clinicas", "Nombre", c => c.String());
            RenameTable(name: "dbo.Enfermeros", newName: "Enfermeroes");
        }
    }
}
