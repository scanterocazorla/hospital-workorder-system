namespace ManteHosApp
{
    partial class Aceptar
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
            this.prioridadLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.prioridadComboBox = new System.Windows.Forms.ComboBox();
            this.atrasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aceptar Incidencia";
            // 
            // prioridadLabel
            // 
            this.prioridadLabel.AutoSize = true;
            this.prioridadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.prioridadLabel.Location = new System.Drawing.Point(41, 180);
            this.prioridadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prioridadLabel.Name = "prioridadLabel";
            this.prioridadLabel.Size = new System.Drawing.Size(105, 26);
            this.prioridadLabel.TabIndex = 7;
            this.prioridadLabel.Text = "Prioridad:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.areaLabel.Location = new System.Drawing.Point(78, 111);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(64, 26);
            this.areaLabel.TabIndex = 5;
            this.areaLabel.Text = "Area:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(380, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // areaComboBox
            // 
            this.areaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(148, 105);
            this.areaComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(285, 33);
            this.areaComboBox.TabIndex = 11;
            // 
            // prioridadComboBox
            // 
            this.prioridadComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.prioridadComboBox.FormattingEnabled = true;
            this.prioridadComboBox.Location = new System.Drawing.Point(148, 174);
            this.prioridadComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prioridadComboBox.Name = "prioridadComboBox";
            this.prioridadComboBox.Size = new System.Drawing.Size(210, 33);
            this.prioridadComboBox.TabIndex = 12;
            // 
            // atrasButton
            // 
            this.atrasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.atrasButton.Location = new System.Drawing.Point(491, 306);
            this.atrasButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(89, 37);
            this.atrasButton.TabIndex = 13;
            this.atrasButton.Text = "Atrás";
            this.atrasButton.UseVisualStyleBackColor = true;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // Aceptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 380);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.prioridadComboBox);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prioridadLabel);
            this.Controls.Add(this.areaLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Aceptar";
            this.Text = "Aceptar";
            this.Load += new System.EventHandler(this.Aceptar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prioridadLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.ComboBox prioridadComboBox;
        private System.Windows.Forms.Button atrasButton;
    }
}