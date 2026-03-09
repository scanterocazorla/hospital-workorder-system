namespace ManteHosApp
{
    partial class ManteHosApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBInitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentToolStripMenuItem,
            this.workOrderToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incidentToolStripMenuItem
            // 
            this.incidentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.revisarIncidenciaToolStripMenuItem});
            this.incidentToolStripMenuItem.Name = "incidentToolStripMenuItem";
            this.incidentToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.incidentToolStripMenuItem.Text = "Incidencia";
            this.incidentToolStripMenuItem.Click += new System.EventHandler(this.incidentToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.crearToolStripMenuItem.Text = "Crear incidencia";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // revisarIncidenciaToolStripMenuItem
            // 
            this.revisarIncidenciaToolStripMenuItem.Name = "revisarIncidenciaToolStripMenuItem";
            this.revisarIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.revisarIncidenciaToolStripMenuItem.Text = "Revisar incidencia";
            this.revisarIncidenciaToolStripMenuItem.Click += new System.EventHandler(this.revisarIncidenciaToolStripMenuItem_Click);
            // 
            // workOrderToolStripMenuItem
            // 
            this.workOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarOrdenToolStripMenuItem,
            this.cerrarOrdenToolStripMenuItem});
            this.workOrderToolStripMenuItem.Name = "workOrderToolStripMenuItem";
            this.workOrderToolStripMenuItem.Size = new System.Drawing.Size(128, 23);
            this.workOrderToolStripMenuItem.Text = "Orden de trabajo";
            this.workOrderToolStripMenuItem.Click += new System.EventHandler(this.workOrderToolStripMenuItem_Click);
            // 
            // asignarOrdenToolStripMenuItem
            // 
            this.asignarOrdenToolStripMenuItem.Name = "asignarOrdenToolStripMenuItem";
            this.asignarOrdenToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.asignarOrdenToolStripMenuItem.Text = "Asignar orden";
            this.asignarOrdenToolStripMenuItem.Click += new System.EventHandler(this.asignarOrdenToolStripMenuItem_Click);
            // 
            // cerrarOrdenToolStripMenuItem
            // 
            this.cerrarOrdenToolStripMenuItem.Name = "cerrarOrdenToolStripMenuItem";
            this.cerrarOrdenToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.cerrarOrdenToolStripMenuItem.Text = "Cerrar orden";
            this.cerrarOrdenToolStripMenuItem.Click += new System.EventHandler(this.cerrarOrdenToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.dBInitToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // dBInitToolStripMenuItem
            // 
            this.dBInitToolStripMenuItem.Name = "dBInitToolStripMenuItem";
            this.dBInitToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.dBInitToolStripMenuItem.Text = "DBInit";
            this.dBInitToolStripMenuItem.Click += new System.EventHandler(this.dBInitToolStripMenuItem_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(18, 47);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(185, 35);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Bienvenido: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManteHosApp.Properties.Resources.logo2;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ManteHosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManteHosApp";
            this.Text = "ManteHosApp";
            this.Load += new System.EventHandler(this.ManteHosApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarIncidenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBInitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}