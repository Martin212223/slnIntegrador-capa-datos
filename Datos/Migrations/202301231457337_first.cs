namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habitacion",
                c => new
                    {
                        HabitacionId = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.HabitacionId);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        PacienteId = c.Int(nullable: false, identity: true),
                        NroHistoriaClinica = c.Int(nullable: false),
                        HabitacionId = c.Int(nullable: false),
                        MedicoId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.PacienteId)
                .ForeignKey("dbo.Habitacion", t => t.HabitacionId, cascadeDelete: false)
                .ForeignKey("dbo.Medico", t => t.MedicoId, cascadeDelete: false)
                .Index(t => t.HabitacionId)
                .Index(t => t.MedicoId);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        MedicoId = c.Int(nullable: false, identity: true),
                        Especialidad = c.String(nullable: false, maxLength: 50, unicode: false),
                        Matricula = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        PostGrado = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MedicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paciente", "MedicoId", "dbo.Medico");
            DropForeignKey("dbo.Paciente", "HabitacionId", "dbo.Habitacion");
            DropIndex("dbo.Paciente", new[] { "MedicoId" });
            DropIndex("dbo.Paciente", new[] { "HabitacionId" });
            DropTable("dbo.Medico");
            DropTable("dbo.Paciente");
            DropTable("dbo.Habitacion");
        }
    }
}
