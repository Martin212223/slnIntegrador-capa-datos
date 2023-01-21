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

        //public static List<Medico> Listar(string especialidad)
        //{
            
        //    return context.Medicos.Find(keyValues: especialidad);
        //}

        public static int Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            
            return context.SaveChanges();
        }



        public static int Eliminar(int id)
        {
            //TODO...
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            //TODO...
            return null;
        }
    }
}
