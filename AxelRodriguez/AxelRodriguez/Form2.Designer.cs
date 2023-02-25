namespace AxelRodriguez
{
    partial class Form2
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subtotaltextBox = new System.Windows.Forms.TextBox();
            this.descuentotextBox = new System.Windows.Forms.TextBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el precio";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(478, 81);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 20);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal";
            // 
            // cantidadtextBox
            // 
            this.cantidadtextBox.Location = new System.Drawing.Point(238, 153);
            this.cantidadtextBox.Name = "cantidadtextBox";
            this.cantidadtextBox.Size = new System.Drawing.Size(156, 20);
            this.cantidadtextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingrese la cantidad";
            // 
            // preciotextBox
            // 
            this.preciotextBox.Location = new System.Drawing.Point(238, 109);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(151, 20);
            this.preciotextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total a pagar";
            // 
            // subtotaltextBox
            // 
            this.subtotaltextBox.Location = new System.Drawing.Point(103, 307);
            this.subtotaltextBox.Name = "subtotaltextBox";
            this.subtotaltextBox.Size = new System.Drawing.Size(94, 20);
            this.subtotaltextBox.TabIndex = 12;
            // 
            // descuentotextBox
            // 
            this.descuentotextBox.Location = new System.Drawing.Point(300, 305);
            this.descuentotextBox.Name = "descuentotextBox";
            this.descuentotextBox.Size = new System.Drawing.Size(78, 20);
            this.descuentotextBox.TabIndex = 13;
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(490, 304);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(96, 20);
            this.totaltextBox.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.descuentotextBox);
            this.Controls.Add(this.subtotaltextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.preciotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidadtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cantidadtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox preciotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox subtotaltextBox;
        private System.Windows.Forms.TextBox descuentotextBox;
        private System.Windows.Forms.TextBox totaltextBox;
    }
}