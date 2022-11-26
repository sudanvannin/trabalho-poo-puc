using System;

namespace trabalho_poo_puc
{
     public class Urna
    {
        public Urna(int secao, int zona,int voto, Eleicao eleicao)
        {
            Secao = secao;
            Zona = zona;
            Voto = voto;
        }

        public int Secao { get; set; }
        public int Zona { get; set; }
    
        public int Voto { get; set; }
        
        public void ComputaVoto( int voto, Candidato candidato){
          int QtdVotos = 0 , nulo=0, branco=0;
          if(candidato.GetType() == eleicao.nulo){
            nulo++;

          }else if(candidato.GetType()==eleicao.branco){
            branco++;
          }else{
            QtdVotos++;
          }
            
    
        }
    
    }

}
