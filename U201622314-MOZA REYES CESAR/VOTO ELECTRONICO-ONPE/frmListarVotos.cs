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
    public partial class frmListarVotos : Form
    {
        public frmListarVotos()
        {
            InitializeComponent();
        }

        private void frmListarVotos_Load(object sender, EventArgs e)
        {
            lbpartidos.DisplayMember = "Nombre";
            lbpartidos.ValueMember = "codigo";
            lbpartidos.DataSource = gestionVotacion.Partidos;
        }

        private void lbpartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            partidosPoliticos partido = (partidosPoliticos)lbpartidos.SelectedItem;
            lbVotos.DisplayMember = "DNI";
            lbVotos.ValueMember = "Digitoverificador";
            lbVotos.DataSource = partido.Votos;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
