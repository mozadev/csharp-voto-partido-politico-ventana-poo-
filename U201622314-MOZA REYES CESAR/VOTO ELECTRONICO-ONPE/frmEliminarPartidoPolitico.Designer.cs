namespace VOTO_ELECTRONICO_ONPE
{
    partial class frmEliminarPartidoPolitico
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
            this.lbpartidos = new System.Windows.Forms.ListBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtCodPartEliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbpartidos
            // 
            this.lbpartidos.FormattingEnabled = true;
            this.lbpartidos.Location = new System.Drawing.Point(286, 88);
            this.lbpartidos.Name = "lbpartidos";
            this.lbpartidos.Size = new System.Drawing.Size(183, 147);
            this.lbpartidos.TabIndex = 21;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(167, 190);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "cerrar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtCodPartEliminar
            // 
            this.txtCodPartEliminar.Location = new System.Drawing.Point(102, 88);
            this.txtCodPartEliminar.Name = "txtCodPartEliminar";
            this.txtCodPartEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtCodPartEliminar.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo Partido ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(61, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "partido";
            // 
            // frmEliminarPartidoPolitico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 425);
            this.Controls.Add(this.lbpartidos);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtCodPartEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Name = "frmEliminarPartidoPolitico";
            this.Text = "frmEliminarPartidoPolitico";
            this.Load += new System.EventHandler(this.frmEliminarPartidoPolitico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbpartidos;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtCodPartEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
    }
}