using ManteHos.Entities;
using ManteHos.Services;
using ManteHos.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManteHosApp
{
    public partial class Operario2 : Form
    {
        IManteHosService service;
        WorkOrder wo;
        //DateTime cierre;
        //String descripcion;
        public Operario2(IManteHosService service, int woId)
        {
            InitializeComponent();
            this.service = service;

            wo = service.GetWorkOrder(woId);
            
            MostrarInf();
            MostrarPiezas();
            MostrarPrecio();
            
            fechaCierre.Value=DateTime.Now;
            Descripcion.Text=string.Empty;
        }

        public void MostrarInf()
        {
            var inc = wo.Incident;
            InfOrden.Clear();
            InfOrden.Text =
            $"Orden Nº: {wo.Id}\r\n" +
            $"Fecha de inicio: {wo.StartDate:dd/MM/yyyy}\r\n" +//startdate ya sale en el formato bn, tengo q poner dd/MM/yyyy?
            $"Incidencia: {inc.Description}\r\n" +
            $"Área: {inc.Area?.Name}\r\n" +
            $"Prioridad: {inc.Priority}\r\n" + //la prioridad esta puesta?
            $"Operarios asignados: {string.Join(", ", wo.Operators.Select(o => o.FullName))}";
            InfOrden.ReadOnly = true;
            InfOrden.ScrollBars = ScrollBars.Vertical;
        }

        public void MostrarPiezas()
        {
            InfPiezas.Clear();
            if (wo.UsedParts.Count == 0 || wo.UsedParts == null) {
                InfPiezas.Text = $"La orden de trabajo no ha utilizado piezas.";
            }
            else
            {
                // piezas utilizadas Needed es false
                InfPiezas.AppendText("Piezas utilizadas:\r\n");
                var usadas = wo.UsedParts.Where(up => !up.Needed).ToList();
                if (usadas.Any()){
                    foreach (var up in usadas){
                        InfPiezas.AppendText(
                            $" - {up.Part.Code} | Cantidad: {up.Quantity} | Coste/u: {up.Part.UnitPrice} | Descripción: {up.Part.Description}\r\n"
                        );
                    }
                }
                else { InfPiezas.AppendText("  (Ninguna)\r\n");}

                // piezas pendientes Needed es true
                InfPiezas.AppendText("\r\nPiezas pendientes:\r\n");
                var pendientes = wo.UsedParts.Where(up => up.Needed).ToList();
                if (pendientes.Any()) {
                    foreach (var up in pendientes){
                        InfPiezas.AppendText(
                            $" - {up.Part.Code} | Cantidad: {up.Quantity} | Coste/u: {up.Part.UnitPrice} | Descripción: {up.Part.Description}\r\n"
                        );
                    }
                }
                else { InfPiezas.AppendText("  (Ninguna)\r\n"); }
            }
            InfPiezas.ReadOnly = true;
            InfPiezas.ScrollBars = ScrollBars.Vertical;
        }

        public void MostrarPrecio()
        {
            double precio = 0;

            foreach (var up in wo.UsedParts)
                precio += up.Quantity * up.Part.UnitPrice;

            coste.Text = precio.ToString("0.00") + " €";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Orden cerrada correctamente.");
                service.CloseWorkOrder(wo.Id, fechaCierre.Value, Descripcion.Text);
                this.Close();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, "No se puede cerrar la orden");
                this.Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
