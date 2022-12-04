using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UrnaVotacao.Votacao.Classes.Partido
{
    class MetodosPartido
    {

        private List<Partido> _partido;

        public MetodosPartido()
        {
            this._partido = new List<Partido>();
        }
        /* - - -  Métodos de Manipulação - - - - -  */
        public void Adicionar(Partido partido)
        {
            if (this._partido.Count(c => c.NomePartido.Equals(partido.NomePartido)) > 0)
            {
                throw new Exception("Já existe um partido com esse nome");
            }
            else
            {
                this._partido.Add(partido);
            }
        }

        public void Remover(Partido cliente)
        {
            this._partido.Remove(cliente);
        }

        public List<Partido> MostrarClientes()
        {
            return this._partido;
        }

        /* - - -  Métodos de persistencia - - - - -  */

        public void Salvar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Partido>));
            FileStream fs = new FileStream("Partidos.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this._partido);
            fs.Close();
        }


        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Partido>));
            FileStream fs = new FileStream("Partidos.xml", FileMode.OpenOrCreate);

            try
            {
                this._partido = ser.Deserialize(fs) as List<Partido>;
            }
            catch (InvalidOperationException)
            {
                ser.Serialize(fs, this._partido);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}

