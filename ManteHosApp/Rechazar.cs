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
    public partial class Rechazar : Form
    {
        IManteHosService service;
        Incident incident;
        InfoIncidencia info;
        public Rechazar(IManteHosService service, Incident incidenciaSelect, InfoIncidencia infoIncidencia)
        {
            InitializeComponent();
            this.service = service;
            this.incident = incidenciaSelect;
            this.info = infoIncidencia;
        }
        private void Rechazar_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Guardar lo q usuario escribe
            string razon = razonRichTextBox.Text;
            //si no se escribe nada o solo hay un espacio salta un error
            if (string.IsNullOrWhiteSpace(razon))
            {
                MessageBox.Show(this, //formulario REvisarIncidencia que esta abierto en ese momento puedes no ponerlo
                    "Debes indicar una razón de rechazo",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //llamo a metodo
            service.RejectIncident(incident, razon);
            //Avisar a usuario que se ha rechazado la incidencia correctamente
            MessageBox.Show(this,
                "Incidencia rechazada correctamente",
                "Rechazar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            //Cerraar ventana
            info.Close();
            this.Close();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
