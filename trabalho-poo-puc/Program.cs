using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace trabalho_poo_puc{
    public class Program{

        public static void Main()
        {
            Eleicao teste = new Eleicao(1,2022);
            Urna urna = new Urna(1,2346,teste);
            Eleicao eleicao = urna.getEleicao();
            eleicao.cadastro();

            urna.votacao(); //
        }

        

    }
}