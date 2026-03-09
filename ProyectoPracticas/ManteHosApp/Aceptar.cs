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
    public partial class Aceptar : Form
    {
        IManteHosService service;
        Incident incident;
        InfoIncidencia info;
        public Aceptar(IManteHosService service, Incident incidenciaSelect, InfoIncidencia infoIncidencia)
        {
            InitializeComponent();
            this.service = service;
            this.incident = incidenciaSelect;
            this.info = infoIncidencia;
        }

        private void Aceptar_Load(object sender, EventArgs e)
        {
            //cogemos todas las areas existentes
            var areas = service.GetAreas().ToList();
            //Metemos areas en comboBox para que usuario elija una
            areaComboBox.Items.Clear();
            areaComboBox.Items.AddRange(areas.ToArray());

            //añadir prioridades posibles
            prioridadComboBox.Items.Clear();
            prioridadComboBox.Items.Add(Priority.Low);
            prioridadComboBox.Items.Add(Priority.Medium);
            prioridadComboBox.Items.Add(Priority.High);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //si no añade area, mensaje de error
            if (areaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(this, //formulario REvisarIncidencia que esta abierto en ese momento puedes no ponerlo
                    "Debes seleccionar un área",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //si no añade prioridad, mensaje de error
            if (prioridadComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(this, //formulario REvisarIncidencia que esta abierto en ese momento puedes no ponerlo
                    "Debes seleccionar una prioridad",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //Guardar prioridad seleccionada y convertir lo seleccionado en Area
            Area areaSelect = areaComboBox.SelectedItem as Area;
            //Lo mismo pero con prioridad
            Priority prioridadSelect = (Priority)prioridadComboBox.SelectedItem;

            service.AcceptIncident(incident, prioridadSelect, areaSelect);
            //Mensaje de confirmación
            MessageBox.Show(this,
                "Incidencia aceptada correctamente",
                "Aceptar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //Cerrar ventana
            info.Close();
            this.Close();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
