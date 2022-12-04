using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    public class Presidente : Governador, ICandidato
    {
        public Presidente(string partido, string nome, int idade, int numCandidato) : base(partido, nome, idade, numCandidato)
        {

        }
        public override void funcaoCandidato()
        {
            MessageBox.Show("Governa o Pais.");
        }
    }
}
