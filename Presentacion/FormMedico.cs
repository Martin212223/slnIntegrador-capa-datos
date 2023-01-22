using Entidades;
using Negocio;
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
    public partial class FormMedico : Form
    {
        public FormMedico()
        {
            InitializeComponent();
        }

        private void MedicosTodos()
        {
            gridFormMed.DataSource = AbmMedico.Listar();
        }

        private void Limpiar()
        {
            txtIdMed.Text = string.Empty;
            txtNombreMed.Text = string.Empty;
            txtApellidoMed.Text = string.Empty;
            txtDomicilioMed.Text = string.Empty;
            txtTelMed.Text = string.Empty;
            txtEmailMed.Text = string.Empty;
            txtEspecMed.Text = string.Empty;
            txtMatrMed.Text = string.Empty;
        }

        private void btnRegMed_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico(txtNombreMed.Text.ToString(), txtApellidoMed.Text.ToString(), txtDomicilioMed.Text.ToString(), txtTelMed.Text.ToString(), txtEmailMed.Text.ToString(), txtEspecMed.Text.ToString(), Convert.ToInt32(txtMatrMed.Text));

            int filasAfectadas = AbmMedico.Insertar(medico);

            if (filasAfectadas > 0)
            {
                MedicosTodos();
                Limpiar();
            }
        }

        private void btnElimMed_Click(object sender, EventArgs e)
        {
            
            AbmMedico.Eliminar(Convert.ToInt32(txtIdMed.Text));

            MedicosTodos();

            Limpiar();

        }

        private void FormMedico_Load(object sender, EventArgs e)
        {
            MedicosTodos();
        }

        private void btnTodosMed_Click(object sender, EventArgs e)
        {
            MedicosTodos();
        }

        private void btnIdMed_Click(object sender, EventArgs e)
        {
            try
            {
                List<Medico> medico = new List<Medico>();

                medico.Add(AbmMedico.TraerUno(Convert.ToInt32(txtIdMed.Text)));

                gridFormMed.DataSource = medico;

                Limpiar();
            }
            catch
            {
                MessageBox.Show("Ingrese un valor válido.");
                Limpiar();
            }

        }

        private void btnEsplddMed_Click(object sender, EventArgs e)
        {
            gridFormMed.DataSource = AbmMedico.Listar(txtEspecMed.Text);
        }

        private void btnModMed_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico(Convert.ToInt32(txtIdMed.Text), txtNombreMed.Text, txtApellidoMed.Text, txtDomicilioMed.Text, txtTelMed.Text, txtEmailMed.Text, txtEspecMed.Text, Convert.ToInt32(txtMatrMed.Text));

            AbmMedico.Modificar(medico);

            MedicosTodos();
            Limpiar();
        }
    }
}
