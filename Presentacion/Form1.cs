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

namespace Presentacion
{
    public partial class formPresentacion : Form
    {
        public formPresentacion()
        {
            InitializeComponent();
        }

        private void formPresentacion_Load(object sender, EventArgs e)
        {

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
    }
}
