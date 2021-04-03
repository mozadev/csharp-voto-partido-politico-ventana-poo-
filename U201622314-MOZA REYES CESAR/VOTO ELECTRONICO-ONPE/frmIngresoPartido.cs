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
    public partial class frmIngresoPartido : Form
    {
        gestionVotacion objVotacion = new gestionVotacion();
        public frmIngresoPartido()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            partidosPoliticos partido = new partidosPoliticos();
            partido.Codigo = txtcodigopartido.Text;
            partido.Nombre = txtnombrepartido.Text;
            objVotacion.insertarPartidos(partido);

            MessageBox.Show("ok");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
