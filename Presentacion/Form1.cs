using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Presentacion.Data;

namespace Presentacion
{
    public partial class formPresentacion : Form
    {

        private DBPacientesClinicaContext context = new DBPacientesClinicaContext();

        public formPresentacion()
        {
            InitializeComponent();
        }

        public void MostrarInfo()
        {
            gridMedicos.DataSource = context.Medicos.ToList();

            gridPacientes.DataSource = context.Pacientes.ToList();


            foreach (Medico medico in context.Medicos.ToList())
            {
                if (medico.Especialidad.Equals("Clínico"))
                {
                    listClinicos.Items.Add("Nombre: " + medico.Nombre + " " + medico.Apellido + " Matrícula: " + medico.Matricula + " Espec: " + medico.Especialidad);
                }
            }

            string estado;

            foreach (Habitacion habitacion in context.Habitaciones.ToList())
            {
                if (habitacion.Estado) estado = "Ocupada";
                else estado = "Disponible";

                listHabitaciones.Items.Add("Numero: " + habitacion.Numero + " Estado: " + estado);
            }
        }

        private void formPresentacion_Load(object sender, EventArgs e)
        {
            MostrarInfo();
        }

        private void btnFormMed_Click(object sender, EventArgs e)
        {
            FormMedico formMedico = new FormMedico();

            formMedico.ShowDialog();
        }

        private void btnFormPacnte_Click(object sender, EventArgs e)
        {
            FormPaciente formPaciente = new FormPaciente();

            formPaciente.ShowDialog();
        }

        private void btnDatHabitacion_Click(object sender, EventArgs e)
        {
            FormHabitacion formHabitacion = new FormHabitacion();

            formHabitacion.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarInfo();
        }
    }
}
