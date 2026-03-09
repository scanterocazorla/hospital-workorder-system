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
    public partial class RevisarIncidencia : Form
    {
        IManteHosService service;
        private List<Incident> incidencias;
        public RevisarIncidencia(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void RevisarIncidencia_Load(object sender, EventArgs e)
        {
            CargarIncidencias();
        }
        private void CargarIncidencias()
        {
            //Limpio el ListBox para evitar duplicación
            incidenciaListBox.Items.Clear();
            //Coge incidencias creadas, la convierte en lista
            incidencias = service.GetIncidentCreated().ToList();
            //Añades cada incidencia al ListBox
            foreach (Incident inc in incidencias) //recorre cada incidencia de la lista
            {
                incidenciaListBox.Items.Add(inc);
            }
        }
        private void atrasButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incidenciaListBox_DoubleClick(object sender, EventArgs e)
        {
            //si no hay incidencia seleccionada mostrar mensaje error
            if(incidenciaListBox.SelectedItem == null)
            {
                MessageBox.Show(this, //formulario REvisarIncidencia que esta abierto en ese momento puedes no ponerlo
                    "Debes seleccionar una incidencia primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); 
                return;
            }
            //queremos q lo q haya seleccionada el usuario se trate como una incidencia
            //(Incident) hace falta pq el listBox no sabe q es una incidencia entonces se lo tienes q especificar
            Incident incidenciaSelect = (Incident)incidenciaListBox.SelectedItem;
            InfoIncidencia ventana = new InfoIncidencia(service, incidenciaSelect);
            ventana.ShowDialog();

            CargarIncidencias();
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            if (incidenciaListBox.SelectedIndex == -1)
            {
                MessageBox.Show(this, //formulario REvisarIncidencia que esta abierto en ese momento puedes no ponerlo
                    "Debes seleccionar una incidencia primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //queremos q lo q haya seleccionada el usuario se trate como una incidencia
            //(Incident) hace falta pq el listBox no sabe q es una incidencia entonces se lo tienes q especificar
            Incident incidenciaSelect = (Incident)incidenciaListBox.SelectedItem;
            InfoIncidencia ventana = new InfoIncidencia(service, incidenciaSelect);
            ventana.ShowDialog();

            CargarIncidencias();
        }
    }
}
