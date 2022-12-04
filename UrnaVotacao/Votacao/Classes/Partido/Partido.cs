using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaVotacao.Votacao.Classes.Partido
{
    public class Partido
    {
        private int numCadeira;
        private string nomePartido;

        public Partido(int numCadeira, string nomePartido)
        {
            this.NumCadeira = numCadeira;
            this.NomePartido = nomePartido;

        }

        public Partido()
        {

        }

        public int NumCadeira { get => numCadeira; set => numCadeira = value; }
        public string NomePartido { get => nomePartido; set => nomePartido = value; }
    }
}
