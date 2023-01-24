using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Habitacion")]
    public class Habitacion
    {
        public Habitacion() { }

        public Habitacion(int numero, bool estado)
        {
            Numero = numero;
            Estado = estado;
        }

        public Habitacion(int habitacionId, int numero, bool estado)
        {
            HabitacionId = habitacionId;
            Numero = numero;
            Estado = estado;
        }

        public int HabitacionId { get; set; }

        public int Numero { get; set; }

        public bool Estado { get; set; }

        public List<Paciente> Paciente { get; set; }
    }
}
