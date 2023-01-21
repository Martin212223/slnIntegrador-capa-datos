using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Clinicas")]
    public class Clinica
    {
        public int ClinicaId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Domicilio { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        public Director Director { get; set; }

        public List<Medico> Medicos { get; set; }

        public List<Paciente> Pacientes { get; set; }

        public List<Enfermero> Enfermeros { get; set; }

        //public List<Habitacion> Habitaciones { get; set; }
    }
}
