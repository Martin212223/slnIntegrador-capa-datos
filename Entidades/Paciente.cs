using Entidades.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Paciente")]
    public class Paciente : Persona
    {
        public Paciente() { }

        public Paciente(string nombre, string apellido, string domicilio, string telefono, string email, int nroHistoriaClinica) : base(nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }

        public Paciente(string nombre, string apellido, string domicilio, string telefono, string email, int pacienteId, int nroHistoriaClinica):base(nombre, apellido, domicilio, telefono, email) 
        {
            PacienteId = pacienteId;
            NroHistoriaClinica = nroHistoriaClinica;
        }

        public int PacienteId { get; set; }

        public int NroHistoriaClinica { get; set; }

        
        public int HabitacionId { get; set; }

        [ForeignKey("HabitacionId")]
        public Habitacion Habitacion { get; set; }

        public int MedicoId { get; set; }

        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
    }
}
