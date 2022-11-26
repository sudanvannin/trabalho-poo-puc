using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo_puc
{
    public class Candidato
    {
        public Candidato(int id, string nome, int qtdVotos, Partido partido)
        {
            Id = id;
            Nome = nome;
            QtdVotos = qtdVotos;
            Partido = partido;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdVotos { get; set; }
        public Partido Partido { get; set; }
    }
}
