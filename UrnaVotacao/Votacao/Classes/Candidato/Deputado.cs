using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    public class Deputado : Candidato, ICandidato

    {
        public Deputado(string partido, string nome, int idade, int numCandidato) :base(partido,nome,idade, numCandidato)
        {

        }
        public virtual void funcaoCandidato()
        {
            MessageBox.Show("Vota leis.");
        }
    }
}
