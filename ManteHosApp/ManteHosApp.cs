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
    public partial class ManteHosApp : ManteHosFormBase
    {

        public ManteHosApp():base()
        {
            InitializeComponent();
        }
        public ManteHosApp(IManteHosService service) : base(service)
        {
            InitializeComponent();
            this.service = service;
            //el load está abajo del todo
        }

        private void deshabilitarMenus()
        {
            Employee e = service.GetLogged();
            revisarIncidenciaToolStripMenuItem.Enabled = false;
            workOrderToolStripMenuItem.Enabled = false;
            if (service.isHead(e))
            {
               revisarIncidenciaToolStripMenuItem.Enabled=true;
            }
            else if (service.isMaster(e))
            {
                workOrderToolStripMenuItem.Enabled=true;
                cerrarOrdenToolStripMenuItem.Enabled = false;
                asignarOrdenToolStripMenuItem.Enabled = true;
            }
            else if (service.isOperator(e))
            {
                workOrderToolStripMenuItem.Enabled = true;
                asignarOrdenToolStripMenuItem.Enabled = false;
                cerrarOrdenToolStripMenuItem.Enabled = true;
            }
        }


        private void incidentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = string.Empty;
            service.LogOut();
            Login login = new Login(service);
            login.ShowDialog();
            Employee emp = service.GetLogged();


            if (emp == null)
            {
                Application.Exit();
                return;//para que salga del método si e es null
            }

            deshabilitarMenus(); //función para que se habiliten los menús correspondientes de cada empleado
            welcomeLabel.Text = "Bienvenido " + emp.FullName;
        }

        private void dBInitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service.DBInitialization();
            welcomeLabel.Text = string.Empty;
            service.LogOut();
            Login login = new Login(service);
            login.ShowDialog();
            Employee emp = service.GetLogged();


            if (emp == null)
            {
                Application.Exit();
                return;//para que salga del método si emp es null
            }

            deshabilitarMenus(); //función para que se habiliten los menús correspondientes de cada empleado
            welcomeLabel.Text = "Bienvenido " + emp.FullName;
        }


        private void workOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {  
      

        }

        private void asignarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Tarea1Master ventana = new Tarea1Master(service);
            ventana.ShowDialog();
        }

        private void cerrarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operario1 operario = new Operario1(service);
            operario.ShowDialog();
        }

        private void revisarIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevisarIncidencia revisar = new RevisarIncidencia(service);
            revisar.ShowDialog();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearIncidencia crearIncidencia = new CrearIncidencia(service); crearIncidencia.ShowDialog();
        }

        private void ManteHosApp_Load(object sender, EventArgs e)
        {
            service.DBInitialization();
            Login login = new Login(service);
            login.ShowDialog();
            Employee emp = service.GetLogged();


            if (emp == null)
            {
                Application.Exit();
                return;//para que salga del método si e es null
            }

            deshabilitarMenus(); //función para que se habiliten los menús correspondientes de cada empleado
            welcomeLabel.Text = "Bienvenido " + emp.FullName;
        }
    }
}
