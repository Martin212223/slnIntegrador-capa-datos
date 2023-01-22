using Entidades;
using Presentacion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AbmPaciente
    {

        private static DBPacientesClinicaContext context = new DBPacientesClinicaContext();

        public static List<Paciente> Listar()
        {
        
            return context.Pacientes.ToList();

        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);

            return context.SaveChanges();
        }

        public static int Eliminar(int id) //Paciente paciente
        {
            //Paciente pacienteOrigen = context.Pacientes.Find(paciente.PacienteId);

            //if (pacienteOrigen != null)
            //{
            //    context.Pacientes.Remove(pacienteOrigen);

            //    return context.SaveChanges();
            //}

            //return 0;

            context.Pacientes.Remove(context.Pacientes.Find(id));

            return context.SaveChanges();
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            Paciente pacienteDestino = new Paciente();

            foreach(Paciente paciente in context.Pacientes.ToList())
            {
                if(paciente.NroHistoriaClinica.Equals(nroHistoriaClinica))
                {
                    pacienteDestino.PacienteId = paciente.PacienteId;
                    pacienteDestino.Nombre = paciente.Nombre;
                    pacienteDestino.Apellido = paciente.Apellido;
                    pacienteDestino.Domicilio = paciente.Domicilio;
                    pacienteDestino.Telefono = paciente.Telefono;
                    pacienteDestino.Email = paciente.Email;
                    pacienteDestino.NroHistoriaClinica = paciente.NroHistoriaClinica;
                }
            }

            return pacienteDestino;
        }

        public static int Modificar(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente.PacienteId);

            if (pacienteOrigen != null)
            {
                pacienteOrigen.Nombre = paciente.Nombre;
                pacienteOrigen.Apellido = paciente.Apellido;
                pacienteOrigen.Domicilio = paciente.Domicilio;
                pacienteOrigen.Telefono = paciente.Telefono;
                pacienteOrigen.Email = paciente.Email;
                pacienteOrigen.NroHistoriaClinica = paciente.NroHistoriaClinica;
                pacienteOrigen.HabitacionId = paciente.HabitacionId;
                pacienteOrigen.MedicoId = paciente.MedicoId;

                return context.SaveChanges();
            }
            return 0;
        }

    }
}
