namespace ManteHosApp
{
    partial class InfoIncidencia
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
            this.aceptarButton = new System.Windows.Forms.Button();
            this.rechazarButton = new System.Windows.Forms.Button();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptarButton
            // 
            this.aceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aceptarButton.Location = new System.Drawing.Point(394, 306);
            this.aceptarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(84, 31);
            this.aceptarButton.TabIndex = 0;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // rechazarButton
            // 
            this.rechazarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rechazarButton.Location = new System.Drawing.Point(482, 306);
            this.rechazarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rechazarButton.Name = "rechazarButton";
            this.rechazarButton.Size = new System.Drawing.Size(88, 31);
            this.rechazarButton.TabIndex = 1;
            this.rechazarButton.Text = "Rechazar";
            this.rechazarButton.UseVisualStyleBackColor = true;
            this.rechazarButton.Click += new System.EventHandler(this.rechazarButton_Click);
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Location = new System.Drawing.Point(37, 80);
            this.infoRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(517, 201);
            this.infoRichTextBox.TabIndex = 2;
            this.infoRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Información Incidencia";
            // 
            // InfoIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.rechazarButton);
            this.Controls.Add(this.aceptarButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoIncidencia";
            this.Text = "InfoIncidencia";
            this.Load += new System.EventHandler(this.InfoIncidencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button rechazarButton;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.Label label1;
    }
}