using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTO_ELECTRONICO_ONPE
{
    public class gestionVotacion
    {

        public static List<partidosPoliticos> Partidos { get; set; }
        public gestionVotacion()
        {
            if (Partidos == null)
            {
                Partidos = new List<partidosPoliticos>();
            }
        }
        public void insertarPartidos(partidosPoliticos partido)
        {
            Partidos.Add(partido);
        }


        public void insertarVotosEnPartido(string codigoPartido, votosDeCiudadanos voto)
        {
            partidosPoliticos partidoEncontrado = Partidos.Find(x => x.Codigo == codigoPartido);

            if (partidoEncontrado != null)
            {
                partidoEncontrado.Votos.Add(voto);
            }
        }

        public void EliminarPartidoPolitico(string codigoAEliminar)
        {
            partidosPoliticos partidoEncontrado = Partidos.Find(x => x.Codigo == codigoAEliminar);
            if (partidoEncontrado !=null)
            {
                Partidos.Remove(partidoEncontrado);
            }
        }



        public List<votosDeCiudadanos> ListarVotosDePartido(string codigoPartido)
        {
            partidosPoliticos partidoEncontrado = Partidos.Find(x => x.Codigo == codigoPartido);
            //v o f.
            if (partidoEncontrado != null)
            {
                return partidoEncontrado.Votos;
            }
            else
            {
                return null;
            }
        }

        public partidosPoliticos damePartidoConMasVotos()
        {
            partidosPoliticos temp = new partidosPoliticos();
            foreach (partidosPoliticos partido in Partidos)
            {
                if (partido.Votos.Count > temp.Votos.Count)
                {
                    temp = partido;
                }
            }
            return temp;
        }

       


        public bool CursoExiste(string codigoPartido)
        {
           // return Partidos.Exists(delegate (partidosPoliticos value) { return value.Codigo == codigoPartido; });
            return Partidos.Exists(x => x.Codigo == codigoPartido);

        }



      


    }


}

/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYFORO4
{
    public partial class frmPYFORO4 : Form
    {
        public frmPYFORO4()
        {
            InitializeComponent();
            llenarListView();
        }


        void llenarListView()
        {
            lstCursos.View = View.Details;
            lstCursos.GridLines = true;
            lstCursos.Columns.Add("Codigo", 80);
            lstCursos.Columns.Add("Nombre", 80);
            lstCursos.Columns.Add("Creditos", 80);
            lstDocentes.View = View.Details;
            lstDocentes.GridLines = true;
            lstDocentes.Columns.Add("Codigo", 80);
            lstDocentes.Columns.Add("Nombre", 80);
            lstDocentes.Columns.Add("Edad", 80);

        }
        ArrCursos objeC = new ArrCursos();
        ArrDocente objeD = new ArrDocente();

        void actualizarListas()
        {
            lstCursos.Clear();
            lstDocentes.Clear();
            llenarListView();
            List<Curso> aux = objeC.arrCursos;
            for (int i = 0; i < aux.Count(); i++)
            {
                ListViewItem fila = new ListViewItem(aux[i].codigocurso.ToString());
                fila.SubItems.Add(aux[i].nombrecurso);
                fila.SubItems.Add(aux[i].creditos.ToString());
                lstCursos.Items.Add(fila);
            }


            List<Docente> aux2 = objeD.arrDocente;
            for (int i = 0; i < aux2.Count(); i++)
            {
                ListViewItem fila2 = new ListViewItem(aux2[i].codigodocente.ToString());
                fila2.SubItems.Add(aux2[i].nombredocente);
                fila2.SubItems.Add(aux2[i].edad.ToString());
                lstDocentes.Items.Add(fila2);
            }


        }

        private void btnagregarCurso_Click_1(object sender, EventArgs e)
        {
            if (txtcodigoCurso.Text != "" && txtnombreCurso.Text != "" && txtcreditosCurso.Text != "")
            {
                int codigoC = Convert.ToInt32(txtcodigoCurso.Text);
                int nCreditos = Convert.ToInt32(txtcreditosCurso.Text);
                objeC.insertarCurso(codigoC, txtnombreCurso.Text, nCreditos);
                actualizarListas();

            }
            else
                MessageBox.Show("Faltan Datos!!!");
        }

        private void btnagregarDocente_Click_1(object sender, EventArgs e)
        {
            if (txtcodigoDocente.Text != "" && txtnombreDocente.Text != "" && txtedadDocente.Text != "")
            {
                int codigoD = Convert.ToInt32(txtcodigoDocente.Text);
                int edadD = Convert.ToInt32(txtedadDocente.Text);
                objeD.insertarDocente(codigoD, txtnombreDocente.Text, edadD);
                actualizarListas();

            }
            else
                MessageBox.Show("Faltan Datos!!!");
        }

        private void btnbuscarCurso_Click_1(object sender, EventArgs e)
        {
            if (txtbuscarcodigoCurso.Text != "")
            {
                List<Curso> aux3 = objeC.arrCursos;
                int codigoCur = Convert.ToInt32(txtbuscarcodigoCurso.Text);
                int indice = objeC.buscarcursocodigo(codigoCur);
                if (indice > -1)
                {
                    MessageBox.Show("Codigo: " + aux3[indice].codigocurso.ToString() + " Nombre: " + aux3[indice].nombrecurso + " Creditos: " + aux3[indice].creditos.ToString());
                }
                else
                    MessageBox.Show("El codigo no ha sido registrado");

            }
            else
                MessageBox.Show("Codigo no Ingresado");
        }

        private void btnbuscarDocente_Click_1(object sender, EventArgs e)
        {
            if (txtcodigoDocente.Text != "")
            {
                List<Docente> aux4 = objeD.arrDocente;
                int codigoDo = Convert.ToInt32(txtbuscarCodigoDocente.Text);
                int indice = objeD.buscardocentecodigo(codigoDo);
                if (indice > -1)
                {
                    MessageBox.Show("Codigo: " + aux4[indice].codigodocente.ToString() + " Nombre: " + aux4[indice].nombredocente + " EDAD: " + aux4[indice].edad.ToString());
                }
                else
                    MessageBox.Show("El codigo no ha sido registrado");

            }
            else
                MessageBox.Show("Codigo no Ingresado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
//