using Entidades.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Medicos")]
    public class Medico : Persona
    {

        public Medico(string nombre, string apellido, string domicilio, string telefono, string email, int medicoId, string especialidad, int matricula):base(nombre, apellido, domicilio, telefono, email)
        {
            MedicoId = medicoId;
            Especialidad = especialidad;
            Matricula = matricula;
        }
        
        public int MedicoId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Especialidad { get; set; }

        public int Matricula { get; set; }

        public List<Paciente> Pacientes { get; set; }

        public Clinica Clinica { get; set; }
    }
}
