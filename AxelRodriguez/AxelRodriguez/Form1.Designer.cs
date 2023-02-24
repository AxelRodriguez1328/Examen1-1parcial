namespace AxelRodriguez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcularButton = new System.Windows.Forms.Button();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.interesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(160, 197);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(95, 22);
            this.calcularButton.TabIndex = 0;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Location = new System.Drawing.Point(198, 98);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(98, 20);
            this.capitalTextBox.TabIndex = 1;
            // 
            // interesListBox
            // 
            this.interesListBox.FormattingEnabled = true;
            this.interesListBox.Location = new System.Drawing.Point(401, 82);
            this.interesListBox.Name = "interesListBox";
            this.interesListBox.Size = new System.Drawing.Size(154, 251);
            this.interesListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su deposito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interesListBox);
            this.Controls.Add(this.capitalTextBox);
            this.Controls.Add(this.calcularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.ListBox interesListBox;
        private System.Windows.Forms.Label label1;
    }
}

