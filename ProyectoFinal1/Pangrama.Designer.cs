namespace ProyectoFinal1
{
    partial class Pangrama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pangrama));
            this.btnPregunta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPregunta
            // 
            this.btnPregunta.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPregunta.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPregunta.ForeColor = System.Drawing.Color.Navy;
            this.btnPregunta.Location = new System.Drawing.Point(213, 252);
            this.btnPregunta.Name = "btnPregunta";
            this.btnPregunta.Size = new System.Drawing.Size(270, 45);
            this.btnPregunta.TabIndex = 0;
            this.btnPregunta.Text = "¿Es un Pangrama?";
            this.btnPregunta.UseVisualStyleBackColor = false;
            this.btnPregunta.Click += new System.EventHandler(this.btnPregunta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(273, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pangramas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(73, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escribe una frase y te diremos si es un pangrama --->";
            // 
            // txtIngresar
            // 
            this.txtIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIngresar.Location = new System.Drawing.Point(106, 166);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(494, 31);
            this.txtIngresar.TabIndex = 2;
            // 
            // Pangrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.txtIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPregunta);
            this.Name = "Pangrama";
            this.Text = "Modulo 5: Pangrama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngresar;
    }
}