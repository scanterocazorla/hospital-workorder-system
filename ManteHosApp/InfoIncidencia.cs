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
    public partial class InfoIncidencia : Form
    {
        IManteHosService service;
        Incident incident;
        public InfoIncidencia(IManteHosService service, Incident incidenciaSelect)
        {
            InitializeComponent();
            this.service = service;
            this.incident = incidenciaSelect;
        }
        private void InfoIncidencia_Load(object sender, EventArgs e)
        {
            infoRichTextBox.ReadOnly = true;

            infoRichTextBox.Text =
                "ID: " + incident.Id + "\n" +
                "Fecha del reporte: " + incident.ReportDate + "\n" +
                "Departamento: " + incident.Department + "\n" +
                "Descripción: " + incident.Description + "\n" +
                "Empleado: " + incident.Reporter.FullName + "\n" +
                "Status: " + incident.Status + "\n";
        }
        private void aceptarButton_Click(object sender, EventArgs e)
        {
            //el this es la ventana InfoIncidencia que esta abierta en ese momento
            Aceptar ventana = new Aceptar(service, incident, this);
            ventana.ShowDialog();
        }

        private void rechazarButton_Click(object sender, EventArgs e)
        {
            //el this es la ventana InfoIncidencia que esta abierta en ese momento
            Rechazar ventana = new Rechazar(service, incident, this);
            ventana.ShowDialog();
        }

        
    }
}
