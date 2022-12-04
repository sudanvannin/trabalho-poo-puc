using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaVotacao.Votacao.Classes.Partido;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    public abstract class AbsCandidato
    {
       
        protected string nome, nomePartido, partido;
        protected int idade, numCadeira, numCandidato;
        public string Partido { get => partido; set => partido = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public int NumCandidato { get => numCandidato; set => numCandidato = value; }

        public override string ToString() {
            return Nome + " - " + NumCandidato+" - "+Partido + " - " +Idade;
        }
    }
}
