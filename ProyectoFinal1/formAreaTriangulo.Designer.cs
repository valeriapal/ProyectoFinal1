
namespace ProyectoFinal1
{
    partial class formAreaTriangulo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(69, 143);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(31, 15);
            this.lblTexto1.TabIndex = 4;
            this.lblTexto1.Text = "Base";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(252, 143);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(39, 15);
            this.lblTexto2.TabIndex = 5;
            this.lblTexto2.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(187, 239);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // formAreaTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 344);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formAreaTriangulo";
            this.Text = "Area de un Triangulo";
            this.Load += new System.EventHandler(this.formAreaTriangulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Button btnCalcular;
    }
}

