namespace prySvetlizaEtapa1
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pctFirma = new System.Windows.Forms.PictureBox();
            this.btnOtraFirma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(131, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(190, 58);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pctFirma
            // 
            this.pctFirma.Location = new System.Drawing.Point(60, 28);
            this.pctFirma.Name = "pctFirma";
            this.pctFirma.Size = new System.Drawing.Size(336, 312);
            this.pctFirma.TabIndex = 1;
            this.pctFirma.TabStop = false;
            this.pctFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseDown);
            this.pctFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseMove);
            this.pctFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseUp);
            // 
            // btnOtraFirma
            // 
            this.btnOtraFirma.Location = new System.Drawing.Point(131, 443);
            this.btnOtraFirma.Name = "btnOtraFirma";
            this.btnOtraFirma.Size = new System.Drawing.Size(190, 54);
            this.btnOtraFirma.TabIndex = 2;
            this.btnOtraFirma.Text = "Hacer otra firma";
            this.btnOtraFirma.UseVisualStyleBackColor = true;
            this.btnOtraFirma.Click += new System.EventHandler(this.btnOtraFirma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 509);
            this.Controls.Add(this.btnOtraFirma);
            this.Controls.Add(this.pctFirma);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pctFirma;
        private System.Windows.Forms.Button btnOtraFirma;
    }
}

