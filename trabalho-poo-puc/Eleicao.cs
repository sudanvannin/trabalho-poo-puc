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
        public Candidato[] candidatos;
        public Partido[] partidos;
        public Branco branco = new Branco();
        public Nulo nulo = new Nulo();
        public void cadastro(){
            Console.WriteLine("Cadastre os Partidos da Eleicao (FIM para sair)");
            string input = "";
            while (input != "FIM"){
                
                int id =  int.Parse(Console.ReadLine());

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

                        Presidente candidato = new Presidente(id,nome,partido);
                        break;
                    case 2:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        Governador candidato = new Governador(id,nome);
                        break;
                    case 3:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        DeputadoFederal candidato = new DeputadoFederal(id,nome);
                        break;
                    case 4:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        DeputadoEstadual candidato = new DeputadoEstadual(id,nome);
                        break;
                    case 5:
                        id =  int.Parse(Console.ReadLine());
                        nome = Console.ReadLine();

                        Prefeito candidato = new Prefeito(id,nome);
                        break;
                    case 6:
                        Console.WriteLine("insira o número do candidato");
                        id =  int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o nome do candidato");
                        nome = Console.ReadLine();
                        Console.WriteLine("insira o partido do candidato");
                        partido = Console.ReadLine();

                        Vereador candidato = new Vereador(id,nome);
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