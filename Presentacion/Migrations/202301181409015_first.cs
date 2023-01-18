namespace Presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinicas",
                c => new
                    {
                        ClinicaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Domicilio = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                        Director_MedicoId = c.Int(),
                    })
                .PrimaryKey(t => t.ClinicaId)
                .ForeignKey("dbo.Medicos", t => t.Director_MedicoId)
                .Index(t => t.Director_MedicoId);
            
            CreateTable(
                "dbo.Medicos",
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
                        Clinica_ClinicaId = c.Int(),
                    })
                .PrimaryKey(t => t.MedicoId)
                .ForeignKey("dbo.Clinicas", t => t.Clinica_ClinicaId)
                .Index(t => t.Clinica_ClinicaId);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        PacienteId = c.Int(nullable: false, identity: true),
                        NroHistoriaClinica = c.Int(nullable: false),
                        ClinicaId = c.Int(nullable: false),
                        MedicoId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.PacienteId)
                .ForeignKey("dbo.Clinicas", t => t.ClinicaId, cascadeDelete: true)
                .ForeignKey("dbo.Medicos", t => t.MedicoId, cascadeDelete: true)
                .Index(t => t.ClinicaId)
                .Index(t => t.MedicoId);
            
            CreateTable(
                "dbo.Enfermeroes",
                c => new
                    {
                        EnfermeroId = c.Int(nullable: false, identity: true),
                        Cuil = c.String(),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Domicilio = c.String(nullable: false, maxLength: 50, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Clinica_ClinicaId = c.Int(),
                    })
                .PrimaryKey(t => t.EnfermeroId)
                .ForeignKey("dbo.Clinicas", t => t.Clinica_ClinicaId)
                .Index(t => t.Clinica_ClinicaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enfermeroes", "Clinica_ClinicaId", "dbo.Clinicas");
            DropForeignKey("dbo.Clinicas", "Director_MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Medicos", "Clinica_ClinicaId", "dbo.Clinicas");
            DropForeignKey("dbo.Pacientes", "ClinicaId", "dbo.Clinicas");
            DropIndex("dbo.Enfermeroes", new[] { "Clinica_ClinicaId" });
            DropIndex("dbo.Pacientes", new[] { "MedicoId" });
            DropIndex("dbo.Pacientes", new[] { "ClinicaId" });
            DropIndex("dbo.Medicos", new[] { "Clinica_ClinicaId" });
            DropIndex("dbo.Clinicas", new[] { "Director_MedicoId" });
            DropTable("dbo.Enfermeroes");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Medicos");
            DropTable("dbo.Clinicas");
        }
    }
}
