using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo_puc
{
    public class Candidato
    {
        public Candidato(int id, string nome,string partido){

            Id = id;
            Nome = nome;
            this.partido = partido;
        }

        public string cargo { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdVotos { get; set; }
        public string partido { get; set; }
        public int tipo { get; set; }
        public void addVoto(){

            this.QtdVotos++;
        }

    }
}
