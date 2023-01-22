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

        public static List<Paciente> ListarTodos()
        {
        
            return context.Pacientes.ToList();

        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            return context.Pacientes.Find(nroHistoriaClinica);
        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            
            return context.SaveChanges();
        }

        public static int ModificarPaciente(Paciente paciente)
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
                //pacienteOrigen.ClinicaId = paciente.ClinicaId;
                pacienteOrigen.MedicoId = paciente.MedicoId;

                return context.SaveChanges();
            }
            return 0;
        }

        public static int Eliminar(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente.PacienteId);

            if (pacienteOrigen != null)
            {
                context.Pacientes.Remove(pacienteOrigen);

                return context.SaveChanges();
            }

            return 0;
        }

        
    }
}
