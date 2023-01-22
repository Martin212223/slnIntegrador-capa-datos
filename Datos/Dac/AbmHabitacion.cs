using Entidades;
using Presentacion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AbmHabitacion
    {

        private static DBPacientesClinicaContext context = new DBPacientesClinicaContext();

        public static List<Habitacion> Listar()
        {
            
            return context.Habitaciones.ToList();

        }

        public static List<Habitacion> Listar(bool estado)
        {
            List<Habitacion> habitacionesPorEst = new List<Habitacion>();

            foreach (Habitacion habitacion in context.Habitaciones.ToList())
            {
                if(habitacion.Estado.Equals(estado))
                {
                    habitacionesPorEst.Add(habitacion);
                }
            }

            return habitacionesPorEst;
        }

        public static int Insertar(Habitacion habitacion)
        {
            context.Habitaciones.Add(habitacion);
            
            return context.SaveChanges();
        }

        public static int Eliminar(int id)
        {
            context.Habitaciones.Remove(context.Habitaciones.Find(id));

            return context.SaveChanges();
        }

        public static Habitacion TraerUno(int numero)
        {

            Habitacion habitacionDestino = new Habitacion();

            foreach (Habitacion habitacion in context.Habitaciones.ToList())
            {
                if (habitacion.Numero.Equals(numero)) 
                {
                    habitacionDestino.HabitacionId = habitacion.HabitacionId;
                    habitacionDestino.Numero = habitacion.Numero;
                    habitacionDestino.Estado = habitacion.Estado;
                }
            }
             
            return habitacionDestino;

        }

        public static int Modificar(Habitacion habitacion)
        {
            Habitacion habitacionOrigen = context.Habitaciones.Find(habitacion.HabitacionId);

            if (habitacionOrigen != null)
            {
                habitacionOrigen.Numero = habitacion.Numero;
                habitacionOrigen.Estado = habitacion.Estado;

                return context.SaveChanges();
            }

            return 0;
        }
    }
}
