namespace ManteHosApp
{
    partial class Operario2
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
            this.coste = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaCierre = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InfOrden = new System.Windows.Forms.TextBox();
            this.InfPiezas = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información de la orden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Información piezas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coste total:";
            // 
            // coste
            // 
            this.coste.AutoSize = true;
            this.coste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coste.Location = new System.Drawing.Point(649, 128);
            this.coste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coste.Name = "coste";
            this.coste.Size = new System.Drawing.Size(18, 20);
            this.coste.TabIndex = 5;
            this.coste.Text = "0";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(43, 275);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(396, 107);
            this.Descripcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción de trabajo:";
            // 
            // fechaCierre
            // 
            this.fechaCierre.Location = new System.Drawing.Point(503, 275);
            this.fechaCierre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaCierre.Name = "fechaCierre";
            this.fechaCierre.Size = new System.Drawing.Size(184, 20);
            this.fechaCierre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de cierre:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cerrar orden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 332);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // InfOrden
            // 
            this.InfOrden.Location = new System.Drawing.Point(43, 46);
            this.InfOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InfOrden.Multiline = true;
            this.InfOrden.Name = "InfOrden";
            this.InfOrden.Size = new System.Drawing.Size(644, 73);
            this.InfOrden.TabIndex = 14;
            // 
            // InfPiezas
            // 
            this.InfPiezas.Location = new System.Drawing.Point(46, 156);
            this.InfPiezas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InfPiezas.Multiline = true;
            this.InfPiezas.Name = "InfPiezas";
            this.InfPiezas.Size = new System.Drawing.Size(644, 73);
            this.InfPiezas.TabIndex = 15;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(608, 349);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(95, 32);
            this.botonCancelar.TabIndex = 16;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // Operario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 416);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.InfPiezas);
            this.Controls.Add(this.InfOrden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaCierre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.coste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Operario2";
            this.Text = "Operario2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label coste;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaCierre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InfOrden;
        private System.Windows.Forms.TextBox InfPiezas;
        private System.Windows.Forms.Button botonCancelar;
    }
}