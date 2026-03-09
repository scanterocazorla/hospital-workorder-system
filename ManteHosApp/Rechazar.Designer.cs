namespace ManteHosApp
{
    partial class Rechazar
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
            this.razonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.rechazarButton = new System.Windows.Forms.Button();
            this.atrasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rechazar Incidencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Razón de rechazo:";
            // 
            // razonRichTextBox
            // 
            this.razonRichTextBox.Location = new System.Drawing.Point(37, 149);
            this.razonRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.razonRichTextBox.Name = "razonRichTextBox";
            this.razonRichTextBox.Size = new System.Drawing.Size(498, 109);
            this.razonRichTextBox.TabIndex = 12;
            this.razonRichTextBox.Text = "";
            // 
            // rechazarButton
            // 
            this.rechazarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rechazarButton.Location = new System.Drawing.Point(347, 310);
            this.rechazarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rechazarButton.Name = "rechazarButton";
            this.rechazarButton.Size = new System.Drawing.Size(117, 34);
            this.rechazarButton.TabIndex = 13;
            this.rechazarButton.Text = "Rechazar";
            this.rechazarButton.UseVisualStyleBackColor = true;
            this.rechazarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // atrasButton
            // 
            this.atrasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.atrasButton.Location = new System.Drawing.Point(486, 308);
            this.atrasButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(89, 37);
            this.atrasButton.TabIndex = 14;
            this.atrasButton.Text = "Atrás";
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // Rechazar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.rechazarButton);
            this.Controls.Add(this.razonRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Rechazar";
            this.Text = "Rechazar";
            this.Load += new System.EventHandler(this.Rechazar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox razonRichTextBox;
        private System.Windows.Forms.Button rechazarButton;
        private System.Windows.Forms.Button atrasButton;
    }
}