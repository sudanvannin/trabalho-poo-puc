using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    public class Prefeito : Candidato, ICandidato
    {
        public Prefeito(string partido, string nome, int idade, int numCandidato)
        {
            
        }
        public virtual void funcaoCandidato()
        {
            MessageBox.Show("Cuida da cidade.");
        }
    }
}
