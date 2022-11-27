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
        public Eleicao eleicao { get; set; }
        public enum cargos {Presidente,Governador,Deputado_Federal,Deputado_Estadual,Prefeito}
        public Eleicao getEleicao(){
          //Console.WriteLine(eleicao.ano);
          return this.eleicao;
        }
        
        public void ComputaVoto(Candidato candidato){

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

            Console.WriteLine("Digite o numero do voto para " + candidato );
            Console.WriteLine("(1 para Voto em Branco, 0 ou inválido para nulo)");
            
            int voto = int.Parse(Console.ReadLine());
            
            Candidato candi = this.eleicao.candidatos.Find(x => x.Id == voto);

            if( candi == null || voto == 0 ){

              ComputaVoto(this.eleicao.nulo);
            }
            else if(voto == 1){

              ComputaVoto(this.eleicao.branco);
            } else{

              candi.addVoto();
            }
          }
        }
    }

}
