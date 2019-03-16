namespace PrimerAplicacion2019
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
            this.btnNovedades = new System.Windows.Forms.Button();
            this.btnIrVentanaDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovedades
            // 
            this.btnNovedades.Location = new System.Drawing.Point(175, 50);
            this.btnNovedades.Name = "btnNovedades";
            this.btnNovedades.Size = new System.Drawing.Size(75, 23);
            this.btnNovedades.TabIndex = 0;
            this.btnNovedades.Text = "Hola Mundo";
            this.btnNovedades.UseVisualStyleBackColor = true;
            this.btnNovedades.Click += new System.EventHandler(this.btnNovedades_Click);
            // 
            // btnIrVentanaDos
            // 
            this.btnIrVentanaDos.Location = new System.Drawing.Point(278, 121);
            this.btnIrVentanaDos.Name = "btnIrVentanaDos";
            this.btnIrVentanaDos.Size = new System.Drawing.Size(75, 23);
            this.btnIrVentanaDos.TabIndex = 1;
            this.btnIrVentanaDos.Text = "Ir Ventana 2";
            this.btnIrVentanaDos.UseVisualStyleBackColor = true;
            this.btnIrVentanaDos.Click += new System.EventHandler(this.btnIrVentanaDos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 230);
            this.Controls.Add(this.btnIrVentanaDos);
            this.Controls.Add(this.btnNovedades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovedades;
        private System.Windows.Forms.Button btnIrVentanaDos;
    }
}

