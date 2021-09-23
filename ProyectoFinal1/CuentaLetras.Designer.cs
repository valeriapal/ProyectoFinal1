namespace ProyectoFinal1
{
    partial class CuentaLetras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuentaLetras));
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtIngresar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.BackColor = System.Drawing.Color.Snow;
            this.lbLista.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 31;
            this.lbLista.Location = new System.Drawing.Point(55, 224);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(393, 190);
            this.lbLista.TabIndex = 0;
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContar.Image = ((System.Drawing.Image)(resources.GetObject("btnContar.Image")));
            this.btnContar.Location = new System.Drawing.Point(559, 224);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(94, 54);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtIngresar
            // 
            this.txtIngresar.BackColor = System.Drawing.Color.Snow;
            this.txtIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIngresar.Location = new System.Drawing.Point(461, 130);
            this.txtIngresar.Name = "txtIngresar";
            this.txtIngresar.Size = new System.Drawing.Size(290, 38);
            this.txtIngresar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(265, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuenta Letras";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(55, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa una Palabra o Frase --->";
            // 
            // CuentaLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngresar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.lbLista);
            this.Name = "CuentaLetras";
            this.Text = "Modulo 3:  Cuenta Letras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}