using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaVotacao.Votacao.Classes.Abstracoes
{
    public interface IServices<T>{
        
        void Adicionar(T item);
        
        void Remover(T item);
        
        List<T> Mostrar();
        
        void Salvar();

        void Carregar();
    }
}
