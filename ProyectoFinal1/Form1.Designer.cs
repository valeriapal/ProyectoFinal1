
namespace ProyectoFinal1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbbopciones = new System.Windows.Forms.ComboBox();
            this.lblopciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbopciones
            // 
            this.cbbopciones.BackColor = System.Drawing.Color.AliceBlue;
            this.cbbopciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbopciones.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbbopciones.FormattingEnabled = true;
            this.cbbopciones.Location = new System.Drawing.Point(50, 296);
            this.cbbopciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbopciones.Name = "cbbopciones";
            this.cbbopciones.Size = new System.Drawing.Size(429, 45);
            this.cbbopciones.TabIndex = 0;
            this.cbbopciones.SelectedIndexChanged += new System.EventHandler(this.cbbopciones_SelectedIndexChanged);
            // 
            // lblopciones
            // 
            this.lblopciones.AutoSize = true;
            this.lblopciones.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblopciones.Image = ((System.Drawing.Image)(resources.GetObject("lblopciones.Image")));
            this.lblopciones.Location = new System.Drawing.Point(169, 204);
            this.lblopciones.Name = "lblopciones";
            this.lblopciones.Size = new System.Drawing.Size(181, 32);
            this.lblopciones.TabIndex = 1;
            this.lblopciones.Text = "Elegir Opciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(50, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al Controlador de Versiones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(529, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblopciones);
            this.Controls.Add(this.cbbopciones);
            this.Name = "Form1";
            this.Text = "Controlador de Versiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbopciones;
        private System.Windows.Forms.Label lblopciones;
        private System.Windows.Forms.Label label1;
    }
}

