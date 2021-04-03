namespace VOTO_ELECTRONICO_ONPE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDePartidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeVotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVotacionPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidoConMasVotacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPartidoPoliticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDePartidosToolStripMenuItem,
            this.ingresoDeVotosToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "ingresos";
            // 
            // ingresoDePartidosToolStripMenuItem
            // 
            this.ingresoDePartidosToolStripMenuItem.Name = "ingresoDePartidosToolStripMenuItem";
            this.ingresoDePartidosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ingresoDePartidosToolStripMenuItem.Text = "ingreso de partidos";
            this.ingresoDePartidosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDePartidosToolStripMenuItem_Click);
            // 
            // ingresoDeVotosToolStripMenuItem
            // 
            this.ingresoDeVotosToolStripMenuItem.Name = "ingresoDeVotosToolStripMenuItem";
            this.ingresoDeVotosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.ingresoDeVotosToolStripMenuItem.Text = "ingreso de votos";
            this.ingresoDeVotosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeVotosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVotacionPorCursoToolStripMenuItem,
            this.partidoConMasVotacionToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.consultasToolStripMenuItem.Text = "consultas";
            // 
            // listarVotacionPorCursoToolStripMenuItem
            // 
            this.listarVotacionPorCursoToolStripMenuItem.Name = "listarVotacionPorCursoToolStripMenuItem";
            this.listarVotacionPorCursoToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.listarVotacionPorCursoToolStripMenuItem.Text = "listar votacion por partidos ";
            this.listarVotacionPorCursoToolStripMenuItem.Click += new System.EventHandler(this.listarVotacionPorCursoToolStripMenuItem_Click);
            // 
            // partidoConMasVotacionToolStripMenuItem
            // 
            this.partidoConMasVotacionToolStripMenuItem.Name = "partidoConMasVotacionToolStripMenuItem";
            this.partidoConMasVotacionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.partidoConMasVotacionToolStripMenuItem.Text = "partido con mas votacion";
            this.partidoConMasVotacionToolStripMenuItem.Click += new System.EventHandler(this.partidoConMasVotacionToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarPartidoPoliticoToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarPartidoPoliticoToolStripMenuItem
            // 
            this.eliminarPartidoPoliticoToolStripMenuItem.Name = "eliminarPartidoPoliticoToolStripMenuItem";
            this.eliminarPartidoPoliticoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.eliminarPartidoPoliticoToolStripMenuItem.Text = "Eliminar partido Politico";
            this.eliminarPartidoPoliticoToolStripMenuItem.Click += new System.EventHandler(this.eliminarPartidoPoliticoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 453);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDePartidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeVotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVotacionPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidoConMasVotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPartidoPoliticoToolStripMenuItem;
    }
}