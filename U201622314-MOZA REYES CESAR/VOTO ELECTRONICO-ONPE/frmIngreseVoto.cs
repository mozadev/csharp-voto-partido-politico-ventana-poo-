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
    public partial class frmIngreseVoto : Form


    {

        gestionVotacion objVotacion = new gestionVotacion();
        public frmIngreseVoto()
        {
            InitializeComponent();
        }

        private void frmIngreseVoto_Load(object sender, EventArgs e)
        {
            lbpartidos  .DisplayMember = "Nombre";
            lbpartidos.ValueMember = "codigo";
            lbpartidos.DataSource = gestionVotacion.Partidos;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            votosDeCiudadanos voto = new votosDeCiudadanos();
            voto.DNI = int.Parse(txtDNI.Text);
            voto.Digitoverificador = int.Parse(txtverificacion.Text);
            
            foreach (partidosPoliticos partido in lbpartidos.SelectedItems)
            {
                objVotacion.insertarVotosEnPartido(partido.Codigo,voto);
            }

            MessageBox.Show("ok");


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
