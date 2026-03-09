namespace ManteHosApp
{
    partial class Operario1
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
            this.ListaOrdenes = new System.Windows.Forms.ListBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bottonSel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaOrdenes
            // 
            this.ListaOrdenes.FormattingEnabled = true;
            this.ListaOrdenes.Location = new System.Drawing.Point(49, 58);
            this.ListaOrdenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaOrdenes.Name = "ListaOrdenes";
            this.ListaOrdenes.Size = new System.Drawing.Size(589, 264);
            this.ListaOrdenes.TabIndex = 0;
            this.ListaOrdenes.DoubleClick += new System.EventHandler(this.ListaOrdenes_DoubleClick);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(556, 346);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(95, 32);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Órdenes de trabajo:";
            // 
            // bottonSel
            // 
            this.bottonSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottonSel.Location = new System.Drawing.Point(428, 346);
            this.bottonSel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottonSel.Name = "bottonSel";
            this.bottonSel.Size = new System.Drawing.Size(124, 32);
            this.bottonSel.TabIndex = 3;
            this.bottonSel.Text = "Seleccionar";
            this.bottonSel.UseVisualStyleBackColor = true;
            this.bottonSel.Click += new System.EventHandler(this.bottonSel_Click);
            // 
            // Operario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 402);
            this.Controls.Add(this.bottonSel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.ListaOrdenes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Operario1";
            this.Text = "Operario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaOrdenes;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bottonSel;
    }
}