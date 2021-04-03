using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOTO_ELECTRONICO_ONPE
{
    public partial class frmEliminarPartidoPolitico : Form


    {
        gestionVotacion objVotacion = new gestionVotacion();
        public frmEliminarPartidoPolitico()
        {
            InitializeComponent();
        }

        private void frmEliminarPartidoPolitico_Load(object sender, EventArgs e)
        {
            lbpartidos.DisplayMember = "Nombre";
            lbpartidos.ValueMember = "Codigo";
            lbpartidos.DataSource = gestionVotacion.Partidos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
            //foreach (partidosPoliticos partido in lbpartidos.SelectedItems)
            //{
            //    objVotacion.EliminarPartidoPolitico(partido.Codigo);
            //}
            //MessageBox.Show("ok");


            //objVotacion.EliminarPartidoPolitico(txtCodPartEliminar .Text );
           
            lbpartidos.DisplayMember = "Nombre";
            lbpartidos.ValueMember = "Codigo";
            MessageBox.Show("ok");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       
    }
}
