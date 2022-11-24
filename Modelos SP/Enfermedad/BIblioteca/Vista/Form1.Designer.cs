namespace Vista
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
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.cmbMicrorganismo = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.rtbEvolucion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Location = new System.Drawing.Point(131, 44);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(100, 23);
            this.txtPoblacion.TabIndex = 0;
            // 
            // cmbMicrorganismo
            // 
            this.cmbMicrorganismo.FormattingEnabled = true;
            this.cmbMicrorganismo.Location = new System.Drawing.Point(130, 98);
            this.cmbMicrorganismo.Name = "cmbMicrorganismo";
            this.cmbMicrorganismo.Size = new System.Drawing.Size(121, 23);
            this.cmbMicrorganismo.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(590, 151);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // rtbEvolucion
            // 
            this.rtbEvolucion.Location = new System.Drawing.Point(62, 220);
            this.rtbEvolucion.Name = "rtbEvolucion";
            this.rtbEvolucion.Size = new System.Drawing.Size(691, 133);
            this.rtbEvolucion.TabIndex = 4;
            this.rtbEvolucion.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbEvolucion);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbMicrorganismo);
            this.Controls.Add(this.txtPoblacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.ComboBox cmbMicrorganismo;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.RichTextBox rtbEvolucion;
    }
}
