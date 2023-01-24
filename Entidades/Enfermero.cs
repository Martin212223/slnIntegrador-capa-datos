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
    public class Enfermero : Persona
    {

        public Enfermero(string nombre, string apellido, string domicilio, string telefono, string email, int enfermeroId, string cuil):base(nombre, apellido, domicilio, telefono, email)
        {
            EnfermeroId = enfermeroId;
            Cuil = cuil;
        }

        public int EnfermeroId { get; set; }

        public string Cuil { get; set; }

    }
}
