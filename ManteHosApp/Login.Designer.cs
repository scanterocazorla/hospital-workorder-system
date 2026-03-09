namespace ManteHosApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.logInFailedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IDLabel.Location = new System.Drawing.Point(124, 80);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(131, 25);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Identificación:";
            this.IDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordLabel.Location = new System.Drawing.Point(124, 131);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(120, 25);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Contraseña:";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDBox.Location = new System.Drawing.Point(287, 85);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(198, 26);
            this.IDBox.TabIndex = 2;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordBox.Location = new System.Drawing.Point(287, 130);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(150, 26);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginButton.Location = new System.Drawing.Point(287, 210);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(122, 29);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Iniciar Sesión";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // logInFailedLabel
            // 
            this.logInFailedLabel.AutoSize = true;
            this.logInFailedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInFailedLabel.ForeColor = System.Drawing.Color.Crimson;
            this.logInFailedLabel.Location = new System.Drawing.Point(265, 259);
            this.logInFailedLabel.Name = "logInFailedLabel";
            this.logInFailedLabel.Size = new System.Drawing.Size(172, 17);
            this.logInFailedLabel.TabIndex = 5;
            this.logInFailedLabel.Text = "Inicio de sesión incorrecto";
            this.logInFailedLabel.Visible = false;
            this.logInFailedLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 309);
            this.Controls.Add(this.logInFailedLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.IDLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label logInFailedLabel;
    }
}