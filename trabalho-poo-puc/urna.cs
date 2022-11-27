using System;

namespace trabalho_poo_puc{
    public class Urna{
        public Urna(int secao, int zona,Eleicao eleicao){
            Secao = secao;
            Zona = zona;
            this.eleicao = eleicao;
        }
        public int Secao { get; set; }
        public int Zona { get; set; }
        public int Voto { get; set; }
        public Eleicao eleicao { get; set; }
        public enum cargos {Presidente,Governador,Deputado_Federal,Deputado_Estadual,Prefeito}
        public Eleicao getEleicao(){
          //Console.WriteLine(eleicao.ano);
          return this.eleicao;
        }
        
        public void ComputaVoto( int voto, Candidato candidato){

          if(candidato.GetType() == typeof(Nulo)){

            eleicao.nulo.addVoto();
          }else if(candidato.GetType()==typeof(Branco)){

            eleicao.branco.addVoto();
          }else{
            candidato.addVoto();
          }    
        }
        public void votacao(){

          foreach (cargos candidato in Enum.GetValues(typeof(cargos))){

            Console.WriteLine("Digite o numero do voto para " + candidato);
            int voto = int.Parse(Console.ReadLine());
          }
        }
    }

}
