using Entidades;
using Negocio;
using Presentacion.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPaciente : Form
    {

        private DBPacientesClinicaContext context = new DBPacientesClinicaContext();

        public FormPaciente()
        {
            InitializeComponent();
        }

        private int ObtenerIdHabitacion()
        {
            string[] selectedOp = new string[4];

            selectedOp = comboPacientesHabit.Text.Split(' ');

            int idObtenido = Convert.ToInt32(selectedOp[3]);

            //MessageBox.Show(idObtenido.ToString());

            return idObtenido;
        }

        private int ObtenerIdMedico()
        {
            string[] selectedOp = new string[4];

            selectedOp = comboPacientesMed.Text.Split(' ');

            int idObtenido = Convert.ToInt32(selectedOp[3]);

            return idObtenido;
        }

        private void VerTodos()
        {
            gridFormPacnte.DataSource = context.Pacientes.ToList();
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            foreach (Medico medico in context.Medicos.ToList())
            {
                comboPacientesMed.Items.Add(medico.Nombre + " " + medico.Apellido + " Id: " + medico.MedicoId);
            }

            foreach (Habitacion habitacion in context.Habitaciones.ToList())
            {
                comboPacientesHabit.Items.Add("Número: " + habitacion.Numero + " Id: " + habitacion.HabitacionId);
            }
        }

        private void btnRegPacnte_Click(object sender, EventArgs e)
        {
            //Paciente paciente = new Paciente(txtNombrePacnte.Text, txtApellPacnte.Text, txtDomicPacnte.Text, txtTelPacnte.Text, txtEmailPacnte.Text, Convert.ToInt32(txtNroHistPacnte.Text))
            //{
            //    HabitacionId = ObtenerId(comboPacientesHabit.Text),
            //    MedicoId = ObtenerId(comboPacientesMed.Text)
            //};

            Paciente paciente = new Paciente();

            paciente.Nombre = txtNombrePacnte.Text;
            paciente.Apellido = txtApellPacnte.Text;
            paciente.Domicilio = txtDomicPacnte.Text;
            paciente.Telefono = txtTelPacnte.Text;
            paciente.Email = txtEmailPacnte.Text;
            paciente.NroHistoriaClinica = Convert.ToInt32(txtNroHistPacnte.Text);
            paciente.HabitacionId = ObtenerIdHabitacion();
            paciente.MedicoId = ObtenerIdMedico();

            AbmPaciente.Insertar(paciente);

            VerTodos();
        }

        private void btnElimPacnte_Click(object sender, EventArgs e)
        {
            AbmPaciente.Eliminar(Convert.ToInt32(txtIdPacnte.Text));
        }

        private void btnTodosPacnte_Click(object sender, EventArgs e)
        {
            VerTodos();
        }

        private void btnHistClinPacnte_Click(object sender, EventArgs e)
        {
            List<Paciente> paciente = new List<Paciente>();

            paciente.Add(AbmPaciente.TraerUno(Convert.ToInt32(txtNroHistPacnte.Text)));

            gridFormPacnte.DataSource = paciente;
        }

        private void btnModPacnte_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(txtNombrePacnte.Text, txtApellPacnte.Text, txtDomicPacnte.Text, txtTelPacnte.Text, txtEmailPacnte.Text, Convert.ToInt32(txtIdPacnte.Text), Convert.ToInt32(txtNroHistPacnte.Text))
            {
                HabitacionId = ObtenerIdHabitacion(),
                MedicoId = ObtenerIdMedico()
            };

            AbmPaciente.Modificar(paciente);

            VerTodos();
        }
    }
}
