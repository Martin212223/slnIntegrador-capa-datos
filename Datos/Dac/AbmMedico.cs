using Entidades;
using Presentacion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AbmMedico
    {

        private static DBPacientesClinicaContext context = new DBPacientesClinicaContext();

        public static List<Medico> ListarTodos()
        {
            
            return context.Medicos.ToList();
        }

        public static List<Medico> Listar(string especialidad)
        {

            List<Medico> medicosPorEspecialidad = new List<Medico>();

            foreach (Medico medico in context.Medicos.ToList())
            {
                if (medico.Especialidad.Equals(especialidad))
                {
                    medicosPorEspecialidad.Add(medico);
                }
            }

            return medicosPorEspecialidad;

        }

        public static int Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            
            return context.SaveChanges();
        }

        public static int Modificar(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.MedicoId);

            if (medicoOrigen != null)
            {
                medicoOrigen.Nombre = medico.Nombre;
                medicoOrigen.Apellido = medico.Apellido;
                medicoOrigen.Domicilio = medico.Domicilio;
                medicoOrigen.Telefono = medico.Telefono;
                medicoOrigen.Email = medico.Email;
                medicoOrigen.Especialidad = medico.Especialidad;
                medicoOrigen.Matricula = medico.Matricula;

                return context.SaveChanges();

                //string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, int matricula
            }

            return 0;
        }

        public static int Eliminar(int id) //int id
        {
            context.Medicos.Remove(context.Medicos.Find(id));

            return context.SaveChanges();
        }

        public static Medico TraerUno(int id)
        {

            return context.Medicos.Find(id);

        }
    }
}
