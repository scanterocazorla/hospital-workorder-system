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
    public partial class Tarea2Master : Form
    {
        IManteHosService service;
        Incident inc;
        WorkOrder wo;
        bool cancelar = false;

        public Tarea2Master(IManteHosService service, int incidentId)
        {
            InitializeComponent();
            this.service = service;

            // Obtener la incidencia 
            inc = service.GetIncident(incidentId);

            // comprobar si tiene WorkOrder 
            if (inc.WorkOrder == null)
            {
                DialogResult r = MessageBox.Show(
                    "Esta incidencia no tiene WorkOrder.\n¿Desea crear una?",
                    "Crear WorkOrder",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    // Crear WorkOrder
                    service.CreateWorkOrder(incidentId);

                    // Recargar la incidencia con su nueva WorkOrder
                    inc = service.GetIncident(incidentId);
                }
                else
                {
                    //si NO, volver a atrás
                    cancelar = true;
                    return;
                }
            }
            //ahora, si hay workorder
            wo = inc.WorkOrder;

        }
        private void Tarea2Master_Load(object sender, EventArgs e)
        {   //si no queremos work order no carga la pantalla
            if (cancelar)
            {
                this.Close();
                return;
            }
            //si la creamos, pues ya mosramos info sobre la incidencia, workorder y los operarios
            MostrarInformacion();
            CargarAsignados();
            CargarAsignables();
        }
        private void MostrarInformacion()
        {   //esto es para que no se pueda poner el curso, o pulsar etc en donde se muestra la info
            richTextBox1.ReadOnly = true;      
            richTextBox1.TabStop = false;     
            richTextBox1.Cursor = Cursors.Arrow; 
            richTextBox1.HideSelection = true; 


            richTextBox1.Clear();

            richTextBox1.AppendText("INCIDENCIA\n");
            richTextBox1.AppendText("Descripción: " + inc.Description + "\n");
            richTextBox1.AppendText("Fecha: " + inc.ReportDate + "\n");
            richTextBox1.AppendText("Área: " + inc.Area.Name + "\n");
            richTextBox1.AppendText("Prioridad: " + inc.Priority + "\n");
            richTextBox1.AppendText("Estado: " + inc.Status + "\n");

            richTextBox1.AppendText("\nWORK ORDER\n");
            richTextBox1.AppendText("ID: " + wo.Id + "\n");
            richTextBox1.AppendText("Fecha inicio: " + wo.StartDate + "\n");
            //aqui si que no sabemos si la wo ha sido cerrada o no
            if (wo.EndDate != null)
                richTextBox1.AppendText("Fecha fin: " + wo.EndDate + "\n");
            else
                richTextBox1.AppendText("Fecha fin: No cerrada\n");
        }
        private void CargarAsignados()
        {
            listBoxAsignados.Items.Clear();

            foreach (var op in wo.Operators)
            {
                listBoxAsignados.Items.Add(op.FullName+ " (" + op.Id + ")");
            }
        }

        private void CargarAsignables()
        {
            listBoxDisponibles.Items.Clear();

            // Obtener TODOS los operadores del sistema 
            var allOps = service.GetAllOperators();

            // Filtrar operadores que pueden asignarse a la WorkOrder
            var disponibles = wo.GetAssignableOperators(allOps);

            // Mostrar en la lista
            foreach (var op in disponibles)
            {
                listBoxDisponibles.Items.Add(op.FullName + " (" + op.Id + ")");
            }
        }
 

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            //poner message box si no selecciona ninguno?
            if (listBoxDisponibles.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debes seleccionar un operario asignado",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string texto = listBoxDisponibles.SelectedItem.ToString();
            string opId = ExtraerIdOperario(texto);

            try
            {
               
                service.AddOperatortoWorkOrder(wo.Id, opId);

                // Recargar la incidencia y su workorder desde BD
                inc = service.GetIncident(inc.Id);
                wo = inc.WorkOrder;
                //actualizo las listas
                CargarAsignados();
                CargarAsignables();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private string ExtraerIdOperario(string texto)
        {
            int ini = texto.LastIndexOf('(') + 1;
            int fin = texto.LastIndexOf(')');
            return texto.Substring(ini, fin - ini);
        }

        

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxAsignados.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debes seleccionar un operario asignado",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            string texto = listBoxAsignados.SelectedItem.ToString();
            string opId = ExtraerIdOperario(texto);

            try
            {
                
                service.RemoveOperatortoWorkOrder(wo.Id, opId);

                
                inc = service.GetIncident(inc.Id);
                wo = inc.WorkOrder;

                
                CargarAsignados();
                CargarAsignables();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Orden de Trabajo Asignada",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }


        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
    }
}
