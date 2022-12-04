using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaVotacao.Votacao.Classes.Partido;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    public class Candidato : AbsCandidato
    {
        public Candidato(string partido, string nome, int idade, int numCandidato)
        {
            this.Partido = partido;
            this.Nome = nome;
            this.Idade = idade;
            this.NumCandidato = numCandidato;
        }

        public string nomeNum {
            get { return Nome +"-"+ NumCandidato; }
        }

        public Candidato(){}
    }
}
