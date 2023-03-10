using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Base;

namespace Entidades
{
    public class Director : Medico
    {
        public Director() { }

        public Director(string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, int matricula, string postGrado):base(nombre, apellido, domicilio, telefono, email, especialidad, matricula)
        {
            PostGrado = postGrado;
        }

        public string PostGrado { get; set; }
    }
}
