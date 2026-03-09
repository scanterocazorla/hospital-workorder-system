using ManteHos.Entities;
using ManteHos.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManteHosApp 
{
    public partial class Tarea1Master : Form
    {
        //creo atributo incidencia
        IManteHosService service;
        private List<Incident> incidencias;
        public Tarea1Master(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;

            incidencias = service.GetMasterIncidents().ToList();
            foreach (var inc in incidencias)
                listBox1.Items.Add(inc.Description);

        }
       


        private void button1_Click(object sender, EventArgs e) //botón selecionar

        {

            //mirar si esta seleccionada una incidencia
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una incidencia.");
                return;
            }

            int indice = listBox1.SelectedIndex;
            Incident seleccionada = incidencias[indice];

            // Abrir el siguiente formulario pasándole el servicio y la incidencia
            Tarea2Master ventana = new Tarea2Master(service, seleccionada.Id);
            ventana.ShowDialog();


        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una incidencia.");
                return;
            }

            int indice = listBox1.SelectedIndex;
            Incident seleccionada = incidencias[indice];

            // Abrir el siguiente formulario pasándole el servicio y la incidencia
            Tarea2Master ventana = new Tarea2Master(service, seleccionada.Id);
            ventana.ShowDialog();
        }
    }
}
