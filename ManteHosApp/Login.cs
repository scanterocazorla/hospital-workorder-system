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
    public partial class Login : Form
    {
        IManteHosService service;

        public Login(IManteHosService service)
        {
            InitializeComponent();
            LoginButton.Enabled = false;
            this.service = service;
            logInFailedLabel.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String user = IDBox.Text;
            String password = PasswordBox.Text;
            try { service.LogIn(user, password);
                this.Close();
            }
            catch {
                IDBox.ResetText();
                PasswordBox.ResetText();
                logInFailedLabel.Visible = true;

            }
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = !string.IsNullOrEmpty(IDBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text);
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = !string.IsNullOrEmpty(IDBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
