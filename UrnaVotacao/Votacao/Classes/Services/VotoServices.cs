using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System;
using UrnaVotacao.Votacao.Classes.Abstracoes;

namespace UrnaVotacao.Votacao.Classes.Candidato
{
    class VotoServices:IServices<Votos>
    {
        private List<Votos> _votos;

        public VotoServices()
        {
            this._votos = new List<Votos>();
        }

        /* - - -  Métodos de Manipulação - - - - -  */
        public void Adicionar(Votos votos){

            this._votos.Add(votos);
        }

        public List<Votos> Mostrar()
        {
            return this._votos;
        }

        /* - - -  Métodos de persistencia - - - - -  */
        public void Salvar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Votos>));
            FileStream fs = new FileStream("Votos.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this._votos);
            fs.Close();
        }
        public void Remover(Votos votos)
        {
            this._votos.Remove(votos);
        }
        public void Carregar(){

            XmlSerializer ser = new XmlSerializer(typeof(List<Votos>));
            FileStream fs = new FileStream("Votos.xml", FileMode.OpenOrCreate);

            try{
                this._votos = ser.Deserialize(fs) as List<Votos>;
            }
            catch (InvalidOperationException){
                ser.Serialize(fs, this._votos);
            }
            finally{
                fs.Close();
            }

        }
        
    }
}
