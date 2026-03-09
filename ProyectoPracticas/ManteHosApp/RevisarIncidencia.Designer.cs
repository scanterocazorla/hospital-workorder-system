namespace ManteHosApp
{
    partial class RevisarIncidencia
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
            this.incidenciaListBox = new System.Windows.Forms.ListBox();
            this.atrasButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seleccionarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // incidenciaListBox
            // 
            this.incidenciaListBox.FormattingEnabled = true;
            this.incidenciaListBox.Location = new System.Drawing.Point(9, 64);
            this.incidenciaListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incidenciaListBox.Name = "incidenciaListBox";
            this.incidenciaListBox.Size = new System.Drawing.Size(476, 277);
            this.incidenciaListBox.TabIndex = 0;
            this.incidenciaListBox.DoubleClick += new System.EventHandler(this.incidenciaListBox_DoubleClick);
            // 
            // atrasButton
            // 
            this.atrasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atrasButton.Location = new System.Drawing.Point(506, 322);
            this.atrasButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(72, 27);
            this.atrasButton.TabIndex = 1;
            this.atrasButton.Text = "Atrás";
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Revisar Incidencia:";
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seleccionarButton.Location = new System.Drawing.Point(498, 64);
            this.seleccionarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(104, 29);
            this.seleccionarButton.TabIndex = 3;
            this.seleccionarButton.Text = "Seleccionar";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            this.seleccionarButton.Click += new System.EventHandler(this.seleccionarButton_Click);
            // 
            // RevisarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 371);
            this.Controls.Add(this.seleccionarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.incidenciaListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RevisarIncidencia";
            this.Text = "RevisarIncidencia";
            this.Load += new System.EventHandler(this.RevisarIncidencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox incidenciaListBox;
        private System.Windows.Forms.Button atrasButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seleccionarButton;
    }
}