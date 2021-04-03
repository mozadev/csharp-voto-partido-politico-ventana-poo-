namespace VOTO_ELECTRONICO_ONPE
{
    partial class frmListarVotos
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
            this.lbVotos = new System.Windows.Forms.ListBox();
            this.lbpartidos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVotos
            // 
            this.lbVotos.FormattingEnabled = true;
            this.lbVotos.Location = new System.Drawing.Point(277, 84);
            this.lbVotos.Name = "lbVotos";
            this.lbVotos.Size = new System.Drawing.Size(188, 303);
            this.lbVotos.TabIndex = 11;
            // 
            // lbpartidos
            // 
            this.lbpartidos.FormattingEnabled = true;
            this.lbpartidos.Location = new System.Drawing.Point(42, 84);
            this.lbpartidos.Name = "lbpartidos";
            this.lbpartidos.Size = new System.Drawing.Size(188, 303);
            this.lbpartidos.TabIndex = 10;
            this.lbpartidos.SelectedIndexChanged += new System.EventHandler(this.lbpartidos_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(309, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "partidosPoliticos";
            // 
            // frmListarVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 504);
            this.Controls.Add(this.lbVotos);
            this.Controls.Add(this.lbpartidos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmListarVotos";
            this.Text = "frmListarVotos";
            this.Load += new System.EventHandler(this.frmListarVotos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVotos;
        private System.Windows.Forms.ListBox lbpartidos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}