
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
            this.cbbopciones = new System.Windows.Forms.ComboBox();
            this.lblopciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbopciones
            // 
            this.cbbopciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbopciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbbopciones.FormattingEnabled = true;
            this.cbbopciones.Location = new System.Drawing.Point(92, 45);
            this.cbbopciones.Name = "cbbopciones";
            this.cbbopciones.Size = new System.Drawing.Size(206, 23);
            this.cbbopciones.TabIndex = 0;
            this.cbbopciones.SelectedIndexChanged += new System.EventHandler(this.cbbopciones_SelectedIndexChanged);
            // 
            // lblopciones
            // 
            this.lblopciones.AutoSize = true;
            this.lblopciones.Location = new System.Drawing.Point(92, 27);
            this.lblopciones.Name = "lblopciones";
            this.lblopciones.Size = new System.Drawing.Size(89, 15);
            this.lblopciones.TabIndex = 1;
            this.lblopciones.Text = "Elegir Opciones";
        
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 344);
            this.Controls.Add(this.lblopciones);
            this.Controls.Add(this.cbbopciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Controlador de Versiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbopciones;
        private System.Windows.Forms.Label lblopciones;
    }
}

