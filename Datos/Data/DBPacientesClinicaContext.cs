using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Data
{
    public class DBPacientesClinicaContext : DbContext
    {
        public DBPacientesClinicaContext():base("KeyDB") { }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
