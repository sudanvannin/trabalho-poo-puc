using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    public class Votos
    {
        protected string nomeCand;
        protected int qtdVotos;
        protected int idCand;

        public string NomeCand { get => nomeCand; set => nomeCand = value; }
        public int QtdVotos { get => qtdVotos; set => qtdVotos = value; }
        public int IdCand { get => idCand; set => idCand = value; }

        public Votos(string _nomeCand, int _qtdVotos, int idCand)
        {
            this.nomeCand = _nomeCand;
            this.qtdVotos = _qtdVotos;
            this.idCand = idCand;
        }

        public Votos(){

        }
    }
}
