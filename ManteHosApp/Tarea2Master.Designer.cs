namespace ManteHosApp
{
    partial class Tarea2Master
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.listBoxDisponibles = new System.Windows.Forms.ListBox();
            this.listBoxAsignados = new System.Windows.Forms.ListBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operarios de la orden:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asignados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asignables";
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonAñadir.Location = new System.Drawing.Point(909, 310);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(120, 44);
            this.buttonAñadir.TabIndex = 5;
            this.buttonAñadir.Text = "Añadir ";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // listBoxDisponibles
            // 
            this.listBoxDisponibles.FormattingEnabled = true;
            this.listBoxDisponibles.ItemHeight = 22;
            this.listBoxDisponibles.Location = new System.Drawing.Point(545, 310);
            this.listBoxDisponibles.Name = "listBoxDisponibles";
            this.listBoxDisponibles.Size = new System.Drawing.Size(317, 290);
            this.listBoxDisponibles.TabIndex = 6;
            // 
            // listBoxAsignados
            // 
            this.listBoxAsignados.FormattingEnabled = true;
            this.listBoxAsignados.ItemHeight = 22;
            this.listBoxAsignados.Location = new System.Drawing.Point(26, 310);
            this.listBoxAsignados.Name = "listBoxAsignados";
            this.listBoxAsignados.Size = new System.Drawing.Size(317, 290);
            this.listBoxAsignados.TabIndex = 7;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(901, 612);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(137, 46);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonEliminar.Location = new System.Drawing.Point(369, 310);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(120, 44);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.button4.Location = new System.Drawing.Point(12, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Atrás";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 12;
            this.label5.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1003, 147);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Tarea2Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 683);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.listBoxAsignados);
            this.Controls.Add(this.listBoxDisponibles);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Tarea2Master";
            this.Text = "Tarea2Master";
            this.Load += new System.EventHandler(this.Tarea2Master_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.ListBox listBoxDisponibles;
        private System.Windows.Forms.ListBox listBoxAsignados;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}