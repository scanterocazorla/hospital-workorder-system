namespace ManteHosApp
{
    partial class CrearIncidencia
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
            this.descpTextBox = new System.Windows.Forms.TextBox();
            this.incLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.crearIncidenciaButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descpTextBox
            // 
            this.descpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descpTextBox.Location = new System.Drawing.Point(291, 102);
            this.descpTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descpTextBox.Name = "descpTextBox";
            this.descpTextBox.Size = new System.Drawing.Size(331, 33);
            this.descpTextBox.TabIndex = 0;
            this.descpTextBox.TextChanged += new System.EventHandler(this.descpTextBox_TextChanged);
            // 
            // incLabel
            // 
            this.incLabel.AutoSize = true;
            this.incLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel.Location = new System.Drawing.Point(212, 21);
            this.incLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incLabel.Name = "incLabel";
            this.incLabel.Size = new System.Drawing.Size(359, 53);
            this.incLabel.TabIndex = 1;
            this.incLabel.Text = "Crear Incidencia";
            this.incLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departamento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTextBox.Location = new System.Drawing.Point(291, 192);
            this.departmentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(331, 33);
            this.departmentTextBox.TabIndex = 3;
            this.departmentTextBox.TextChanged += new System.EventHandler(this.departmentTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 279);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(323, 30);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // crearIncidenciaButton
            // 
            this.crearIncidenciaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearIncidenciaButton.Location = new System.Drawing.Point(340, 358);
            this.crearIncidenciaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crearIncidenciaButton.Name = "crearIncidenciaButton";
            this.crearIncidenciaButton.Size = new System.Drawing.Size(174, 32);
            this.crearIncidenciaButton.TabIndex = 7;
            this.crearIncidenciaButton.Text = "Crear Incidencia";
            this.crearIncidenciaButton.UseVisualStyleBackColor = true;
            this.crearIncidenciaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(711, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CrearIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.crearIncidenciaButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incLabel);
            this.Controls.Add(this.descpTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearIncidencia";
            this.Text = "CrearIncidencia";
            this.Load += new System.EventHandler(this.CrearIncidencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descpTextBox;
        private System.Windows.Forms.Label incLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button crearIncidenciaButton;
        private System.Windows.Forms.Button button2;
    }
}