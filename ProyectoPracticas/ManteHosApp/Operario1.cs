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
    public partial class Operario1 : Form
    {
        IManteHosService service;
        private List<WorkOrder> ordenes;
        public Operario1(IManteHosService service)
        {
            InitializeComponent();
            this.service = service;
            ordenes = service.GetOperatorOpenWorkOrders().ToList();
            //ListaOrdenes.DataSource = ordenes;
            foreach (var wo in ordenes)
            {
                string texto = $"{wo.Id} - Incidencia: {wo.Incident.Description}";
                ListaOrdenes.Items.Add(texto);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bottonSel_Click(object sender, EventArgs e)
        {
            seleccionado();
        }

        private void ListaOrdenes_DoubleClick(object sender, EventArgs e)
        {
            seleccionado();
        }

        private void seleccionado()
        {
        if (ListaOrdenes.SelectedIndex == -1){
               MessageBox.Show("Debe seleccionar una orden de trabajo");
               return;
        }
        int n = ListaOrdenes.SelectedIndex;
        WorkOrder wo = ordenes[n];
        Operario2 operario2 = new Operario2(service, wo.Id);
        operario2.ShowDialog();

        ordenes = service.GetOperatorOpenWorkOrders().ToList();
        ListaOrdenes.Items.Clear();
            foreach (var o in ordenes)
            {
                string texto = $"{o.Id} - Incidencia: {wo.Incident.Description}";
                ListaOrdenes.Items.Add(texto);
            }
        }
    }
}
