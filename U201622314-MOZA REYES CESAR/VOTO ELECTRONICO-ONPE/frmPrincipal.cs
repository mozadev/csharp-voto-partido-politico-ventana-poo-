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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ingresoDePartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoPartido frm = new frmIngresoPartido();
            frm.ShowDialog();
        }

        private void ingresoDeVotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngreseVoto frm = new frmIngreseVoto();
            frm.ShowDialog();
        }

        private void listarVotacionPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarVotos frm = new frmListarVotos();
            frm.ShowDialog();
        }

        private void partidoConMasVotacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionVotacion objVotacion = new gestionVotacion();
            partidosPoliticos partido = objVotacion.damePartidoConMasVotos();
            MessageBox.Show(partido.Nombre);
        }

        private void eliminarPartidoPoliticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarPartidoPolitico frm = new frmEliminarPartidoPolitico();
            frm.ShowDialog();
        }
    }
}
