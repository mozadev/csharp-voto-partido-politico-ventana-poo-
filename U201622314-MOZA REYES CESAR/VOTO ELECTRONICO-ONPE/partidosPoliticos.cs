using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTO_ELECTRONICO_ONPE
{
    public class partidosPoliticos
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string fechaFundacion { get; set; }
        public string fundadores { get; set; }
        public string candidato { get; set; }
        public List<votosDeCiudadanos> Votos { get; set; }

        public partidosPoliticos()
        {
            Votos = new List<votosDeCiudadanos>();
        }
    }
}
