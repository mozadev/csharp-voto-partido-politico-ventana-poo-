namespace VOTO_ELECTRONICO_ONPE
{
    partial class frmIngresoPartido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigopartido = new System.Windows.Forms.TextBox();
            this.txtnombrepartido = new System.Windows.Forms.TextBox();
            this.txtfundadores = new System.Windows.Forms.TextBox();
            this.txtcandidato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigoPartido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nombre";
            // 
            // txtcodigopartido
            // 
            this.txtcodigopartido.Location = new System.Drawing.Point(145, 27);
            this.txtcodigopartido.Name = "txtcodigopartido";
            this.txtcodigopartido.Size = new System.Drawing.Size(100, 20);
            this.txtcodigopartido.TabIndex = 2;
            this.txtcodigopartido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnombrepartido
            // 
            this.txtnombrepartido.Location = new System.Drawing.Point(139, 74);
            this.txtnombrepartido.Name = "txtnombrepartido";
            this.txtnombrepartido.Size = new System.Drawing.Size(185, 20);
            this.txtnombrepartido.TabIndex = 3;
            // 
            // txtfundadores
            // 
            this.txtfundadores.Location = new System.Drawing.Point(139, 109);
            this.txtfundadores.Name = "txtfundadores";
            this.txtfundadores.Size = new System.Drawing.Size(180, 20);
            this.txtfundadores.TabIndex = 5;
            // 
            // txtcandidato
            // 
            this.txtcandidato.Location = new System.Drawing.Point(139, 194);
            this.txtcandidato.Name = "txtcandidato";
            this.txtcandidato.Size = new System.Drawing.Size(169, 20);
            this.txtcandidato.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "candidato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "fundadores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "fecha de fundacion";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(121, 246);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(221, 246);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "cerrar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmIngresoPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 358);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcandidato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfundadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombrepartido);
            this.Controls.Add(this.txtcodigopartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIngresoPartido";
            this.Text = "frmIngresoPartido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigopartido;
        private System.Windows.Forms.TextBox txtnombrepartido;
        private System.Windows.Forms.TextBox txtfundadores;
        private System.Windows.Forms.TextBox txtcandidato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
    }
}