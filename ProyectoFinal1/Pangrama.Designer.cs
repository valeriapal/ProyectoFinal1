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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalLetras = new System.Windows.Forms.Label();
            this.lblLetrasTotal = new System.Windows.Forms.Label();
            this.lblFaltar = new System.Windows.Forms.Label();
            this.txtFaltar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(274, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pangramas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(74, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escribe una frase y te diremos si es un pangrama --->";
            // 
            // txtIngresar
            // 
            this.txtIngresar.BackColor = System.Drawing.Color.Honeydew;
            this.txtIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIngresar.Location = new System.Drawing.Point(107, 158);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(494, 31);
            this.txtIngresar.TabIndex = 2;
            this.txtIngresar.TextChanged += new System.EventHandler(this.txtIngresar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(38, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número Total de Letras";
            // 
            // lblTotalLetras
            // 
            this.lblTotalLetras.AutoSize = true;
            this.lblTotalLetras.BackColor = System.Drawing.Color.LightGreen;
            this.lblTotalLetras.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalLetras.ForeColor = System.Drawing.Color.Navy;
            this.lblTotalLetras.Location = new System.Drawing.Point(-552, 78);
            this.lblTotalLetras.Name = "lblTotalLetras";
            this.lblTotalLetras.Size = new System.Drawing.Size(0, 38);
            this.lblTotalLetras.TabIndex = 1;
            // 
            // lblLetrasTotal
            // 
            this.lblLetrasTotal.AutoSize = true;
            this.lblLetrasTotal.BackColor = System.Drawing.Color.LightGreen;
            this.lblLetrasTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLetrasTotal.ForeColor = System.Drawing.Color.Navy;
            this.lblLetrasTotal.Location = new System.Drawing.Point(380, 249);
            this.lblLetrasTotal.Name = "lblLetrasTotal";
            this.lblLetrasTotal.Size = new System.Drawing.Size(0, 38);
            this.lblLetrasTotal.TabIndex = 1;
            // 
            // lblFaltar
            // 
            this.lblFaltar.AutoSize = true;
            this.lblFaltar.BackColor = System.Drawing.Color.LightSalmon;
            this.lblFaltar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFaltar.ForeColor = System.Drawing.Color.Navy;
            this.lblFaltar.Location = new System.Drawing.Point(38, 320);
            this.lblFaltar.Name = "lblFaltar";
            this.lblFaltar.Size = new System.Drawing.Size(345, 38);
            this.lblFaltar.TabIndex = 1;
            this.lblFaltar.Text = "Las Letras que Faltan Son:";
            // 
            // txtFaltar
            // 
            this.txtFaltar.BackColor = System.Drawing.Color.Honeydew;
            this.txtFaltar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFaltar.Location = new System.Drawing.Point(426, 320);
            this.txtFaltar.Name = "txtFaltar";
            this.txtFaltar.Size = new System.Drawing.Size(215, 31);
            this.txtFaltar.TabIndex = 2;
            // 
            // Pangrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.txtFaltar);
            this.Controls.Add(this.lblFaltar);
            this.Controls.Add(this.lblLetrasTotal);
            this.Controls.Add(this.lblTotalLetras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pangrama";
            this.Text = "Modulo 5: Pangrama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalLetras;
        private System.Windows.Forms.Label lblLetrasTotal;
        private System.Windows.Forms.Label lblFaltar;
        private System.Windows.Forms.TextBox txtFaltar;
    }
}