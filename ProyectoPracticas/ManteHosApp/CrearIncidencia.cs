using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManteHos.Services;

namespace ManteHosApp
{
    public partial class CrearIncidencia : Form
    {

        IManteHosService service;
        public CrearIncidencia(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrearIncidencia_Load(object sender, EventArgs e)
        {
            crearIncidenciaButton.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void departmentTextBox_TextChanged(object sender, EventArgs e)
        {
            crearIncidenciaButton.Enabled = !string.IsNullOrEmpty(departmentTextBox.Text) && !string.IsNullOrEmpty(descpTextBox.Text);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dep = departmentTextBox.Text;
            string desc = descpTextBox.Text;
            DateTime date = dateTimePicker1.Value;
            if (!service.IncidentAlreadyExists(dep, desc))
            {
                service.ReportIncident(dep, desc, date);
                MessageBox.Show("Incidencia creada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Esta incidencia ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void descpTextBox_TextChanged(object sender, EventArgs e)
        {
            crearIncidenciaButton.Enabled = !string.IsNullOrEmpty(departmentTextBox.Text) && !string.IsNullOrEmpty(descpTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
