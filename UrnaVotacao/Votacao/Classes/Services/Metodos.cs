using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using UrnaVotacao.Votacao.Classes.Candidato;
using UrnaVotacao.Votacao.Classes.Partido;


namespace UrnaVotacao.Votacao.Classes.Candidato
{
    class Metodos
    {
        private List<Candidato> _candidato;

        public Metodos()
        {
            this._candidato = new List<Candidato>();
        }

        /* - - -  Métodos de Manipulação - - - - -  */
        public void Adicionar(Candidato candidato)
        {
            if (this._candidato.Count(c => c.Nome.Equals(candidato.Nome)) > 0)
            {
                throw new Exception("Já existe um candidato com esse nome");
            }
            else
            {
                this._candidato.Add(candidato);
            }
        }

        public void Remover(Candidato candidato)
        {
            this._candidato.Remove(candidato);
        }

        public List<Candidato> MostrarCandidatos()
        {
            return this._candidato;
        }

        /* - - -  Métodos de persistencia - - - - -  */

        public void Salvar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Candidato>));
            FileStream fs = new FileStream("Candidatos.xml", FileMode.OpenOrCreate);
            ser.Serialize(fs, this._candidato);
            fs.Close();

            MetodosVotos newVoto = new MetodosVotos();
            foreach (Candidato candi in this._candidato) {

                Votos voto = new Votos(candi.Nome, 0, candi.NumCandidato);
                newVoto.Adicionar(voto);
            }
            newVoto.Salvar();
            

        }


        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Candidato>));
            FileStream fs = new FileStream("Candidatos.xml", FileMode.OpenOrCreate);

            try
            {
                this._candidato = ser.Deserialize(fs) as List<Candidato>;
            }
            catch (InvalidOperationException)
            {
                ser.Serialize(fs, this._candidato);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
