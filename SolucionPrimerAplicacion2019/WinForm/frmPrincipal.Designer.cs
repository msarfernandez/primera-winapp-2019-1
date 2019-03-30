namespace WinForm
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tspBarraHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnEjemploPolimorfismo = new System.Windows.Forms.ToolStripButton();
            this.btnEjemploGrilla = new System.Windows.Forms.ToolStripButton();
            this.ttPista = new System.Windows.Forms.ToolTip(this.components);
            this.ssEstado = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.mnuOtroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNoTieneNada = new System.Windows.Forms.ToolStripMenuItem();
            this.tspBarraHerramientas.SuspendLayout();
            this.ssEstado.SuspendLayout();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspBarraHerramientas
            // 
            this.tspBarraHerramientas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tspBarraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEjemploPolimorfismo,
            this.btnEjemploGrilla});
            this.tspBarraHerramientas.Location = new System.Drawing.Point(0, 24);
            this.tspBarraHerramientas.Name = "tspBarraHerramientas";
            this.tspBarraHerramientas.Size = new System.Drawing.Size(990, 39);
            this.tspBarraHerramientas.TabIndex = 1;
            this.tspBarraHerramientas.Text = "toolStrip1";
            // 
            // btnEjemploPolimorfismo
            // 
            this.btnEjemploPolimorfismo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEjemploPolimorfismo.Image = ((System.Drawing.Image)(resources.GetObject("btnEjemploPolimorfismo.Image")));
            this.btnEjemploPolimorfismo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEjemploPolimorfismo.Name = "btnEjemploPolimorfismo";
            this.btnEjemploPolimorfismo.Size = new System.Drawing.Size(36, 36);
            this.btnEjemploPolimorfismo.Text = "Ejemplos Polimorfismo";
            this.btnEjemploPolimorfismo.Click += new System.EventHandler(this.btnEjemploPolimorfismo_Click);
            // 
            // btnEjemploGrilla
            // 
            this.btnEjemploGrilla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEjemploGrilla.Image = ((System.Drawing.Image)(resources.GetObject("btnEjemploGrilla.Image")));
            this.btnEjemploGrilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEjemploGrilla.Name = "btnEjemploGrilla";
            this.btnEjemploGrilla.Size = new System.Drawing.Size(36, 36);
            this.btnEjemploGrilla.Text = "Ejemplos Grilla";
            this.btnEjemploGrilla.Click += new System.EventHandler(this.btnEjemploGrilla_Click);
            // 
            // ssEstado
            // 
            this.ssEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.ssEstado.Location = new System.Drawing.Point(0, 578);
            this.ssEstado.Name = "ssEstado";
            this.ssEstado.Size = new System.Drawing.Size(990, 22);
            this.ssEstado.TabIndex = 2;
            this.ssEstado.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(147, 17);
            this.lblEstado.Text = "Bienvenido a mi super app";
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOtroMenu});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(990, 24);
            this.mnsMenu.TabIndex = 3;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // mnuOtroMenu
            // 
            this.mnuOtroMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNoTieneNada});
            this.mnuOtroMenu.Name = "mnuOtroMenu";
            this.mnuOtroMenu.Size = new System.Drawing.Size(77, 20);
            this.mnuOtroMenu.Text = "Otro Menú";
            this.mnuOtroMenu.ToolTipText = "Pista del Menu";
            // 
            // mnuNoTieneNada
            // 
            this.mnuNoTieneNada.Name = "mnuNoTieneNada";
            this.mnuNoTieneNada.Size = new System.Drawing.Size(153, 22);
            this.mnuNoTieneNada.Text = "No Tiene Nada";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.ssEstado);
            this.Controls.Add(this.tspBarraHerramientas);
            this.Controls.Add(this.mnsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplos Programación III 2019 - 1C";
            this.tspBarraHerramientas.ResumeLayout(false);
            this.tspBarraHerramientas.PerformLayout();
            this.ssEstado.ResumeLayout(false);
            this.ssEstado.PerformLayout();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBarraHerramientas;
        private System.Windows.Forms.ToolStripButton btnEjemploPolimorfismo;
        private System.Windows.Forms.ToolStripButton btnEjemploGrilla;
        private System.Windows.Forms.ToolTip ttPista;
        private System.Windows.Forms.StatusStrip ssEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOtroMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuNoTieneNada;
    }
}