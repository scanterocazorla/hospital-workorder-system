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
    public partial class ManteHosFormBase : Form
    {
        protected IManteHosService service;
        public ManteHosFormBase()
        {
            InitializeComponent();
        }

        public ManteHosFormBase(IManteHosService service)
        {
            this.service = service;
        }

        private void ManteHosFormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
