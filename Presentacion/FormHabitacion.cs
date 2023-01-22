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
    public partial class FormHabitacion : Form
    {
        public FormHabitacion()
        {
            InitializeComponent();
        }

        private void MostrarTodos()
        {
            gridFormHabit.DataSource = AbmHabitacion.Listar();
        }

        private void Limpiar()
        {
            txtIdHabit.Text = string.Empty;
            txtNroHabit.Text = string.Empty;
        }

        private void btnRegHabit_Click(object sender, EventArgs e)
        {

            bool estBool = true;

            if (comboEstHabit.Text.Equals("Disponible")) estBool = false; 

            Habitacion habitacion = new Habitacion(Convert.ToInt32(txtNroHabit.Text), estBool);

            int filasAfectadas = AbmHabitacion.Insertar(habitacion);

            if (filasAfectadas > 0)
            {
                MostrarTodos();
            }
        }

        private void FormHabitacion_Load(object sender, EventArgs e)
        {
            comboEstHabit.Items.Add("Ocupada");
            comboEstHabit.Items.Add("Disponible");

            MostrarTodos();
        }

        private void btnModHabit_Click(object sender, EventArgs e)
        {

            bool estBool = true;

            if (comboEstHabit.Text.Equals("Disponible")) estBool = false;

            Habitacion habitacion = new Habitacion(Convert.ToInt32(txtIdHabit.Text), Convert.ToInt32(txtNroHabit.Text), estBool);

            AbmHabitacion.Modificar(habitacion);

            MostrarTodos();
        }

        private void btnTodasHabit_Click(object sender, EventArgs e)
        {
            MostrarTodos();
        }

        private void btnEstHabit_Click(object sender, EventArgs e)
        {
            bool estBool = true;

            if (comboEstHabit.Text.Equals("Disponible")) estBool = false;

            gridFormHabit.DataSource = AbmHabitacion.Listar(estBool);

        }

        private void btnIdHabit_Click(object sender, EventArgs e)
        {
            List<Habitacion> habitacion = new List<Habitacion>();

            habitacion.Add(AbmHabitacion.TraerUno(Convert.ToInt32(txtNroHabit.Text)));

            gridFormHabit.DataSource = habitacion;
        }

        private void btnEliminarHabit_Click(object sender, EventArgs e)
        {
            AbmHabitacion.Eliminar(Convert.ToInt32(txtIdHabit.Text));

            MostrarTodos();
        }
    }
}
