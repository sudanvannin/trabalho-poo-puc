using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace trabalho_poo_puc
{
    public class Eleicao{
        public Eleicao(int tipo, int ano){

            this.tipo = tipo;
            this.ano = ano;
        }
        public int tipo {get; set; } //1 EXECUTIVO, 2 Legislativo
        public int ano {get; set; }
        public List<Candidato> candidatos = new List<Candidato>();
        public List<Partido> partidos = new List<Partido>();
        public Branco branco = new Branco(1,"Branco","Branco");
        public Nulo nulo = new Nulo(0,"Nulo","Nulo");
        public void cadastro(){
            Console.WriteLine("Cadastre os Partidos da Eleicao (FIM para sair)");
            string input = "";
            while (input != "FIM"){
                Console.WriteLine("Numero do Partido");
                int id =  int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do Partido");
                string nome = Console.ReadLine();

                Partido partido = new Partido(id,nome);

                Console.WriteLine("Deseja Continuar?");
                input = Console.ReadLine();
            }


            Console.WriteLine("Cadastre os Candidatos da Eleicao (FIM para sair)");
            input = "";
            while (input != "FIM"){
                
                Console.WriteLine("Selecione o tipo de Candidato a cadastrar");
                Console.WriteLine("1-Presidente \r\n 2-Governador \r\n 3-Deputado Federal \r\n 4-Deputado Estadual \r\n 5-Prefeito \r\n 6-Vereador");
                int selection = int.Parse(Console.ReadLine());

                int id;
                string nome, partido;
                switch (selection)
                {
                    case 1:

                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        Presidente cand0 = new Presidente(id,nome,partido);
                        candidatos.Add(cand0);
                        break;
                    case 2:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        Governador cand1 = new Governador(id,nome,partido);
                        candidatos.Add(cand1);
                        break;
                    case 3:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        DeputadoFederal cand2 = new DeputadoFederal(id,nome,partido);
                        candidatos.Add(cand2);
                        break;
                    case 4:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        DeputadoEstadual cand3 = new DeputadoEstadual(id,nome,partido);
                        candidatos.Add(cand3);
                        break;
                    case 5:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        Prefeito cand4 = new Prefeito(id,nome,partido);
                        candidatos.Add(cand4);
                        break;
                    case 6:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        Vereador cand5 = new Vereador(id,nome,partido);
                        candidatos.Add(cand5);
                        break;
                    default:
                        break;
                }
                
                Console.WriteLine("Deseja Continuar?");
                input = Console.ReadLine();
            }
        }
    }
}