using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using UrnaVotacao.Votacao.Classes.Candidato;
using UrnaVotacao.Votacao.Classes.Partido;


namespace UrnaVotacao.Menu
{
    public partial class User : Form
    {
        public string numero;

        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            numero = numero + "1";
            txbNumero.Text = numero;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            numero = numero + "2";
            txbNumero.Text = numero;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            numero = numero + "3";
            txbNumero.Text = numero;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            numero = numero + "4";
            txbNumero.Text = numero;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            numero = numero + "5";
            txbNumero.Text = numero;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            numero = numero + "6";
            txbNumero.Text = numero;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            numero = numero + "7";
            txbNumero.Text = numero;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            numero = numero + "8";
            txbNumero.Text = numero;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            numero = numero + "9";
            txbNumero.Text = numero;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            numero = numero + "0";
            txbNumero.Text = numero;
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            txbNumero.Text = "--";
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txbNumero.Text = null;
            numero = null;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Console.WriteLine("voto digitado: " + this.txbNumero);


            CandidatoServices candServices = new CandidatoServices();
            candServices.Carregar();
            List<Candidato> cands = candServices.Mostrar();


            VotoServices VotoServices = new VotoServices();
            VotoServices.Carregar();
            List<Votos> votos = VotoServices.Mostrar();

            int voto;
            try{

                voto = int.Parse(this.txbNumero.Text);
                Candidato candidatoCerto = cands.Find(i => i.NumCandidato == voto);
                Console.WriteLine("Candidato:" + candidatoCerto);               

                Votos votoCerto = votos.Find(i => i.NomeCand == candidatoCerto.Nome);
                votoCerto.QtdVotos++;
                
                VotoServices.Salvar();
            }
            catch (NullReferenceException ) {

                Console.Beep();
                Candidato candidatoNulo = cands.Find(i => i.NumCandidato == 0);

                Votos votoCerto = votos.Find(i => i.NomeCand == candidatoNulo.Nome);
                votoCerto.QtdVotos++;
                
                VotoServices.Salvar();
            }
            catch (FormatException){

                Console.Beep();
                Candidato candidatoNulo = cands.Find(i => i.NumCandidato == 0);

                Votos votoCerto = votos.Find(i => i.NomeCand == candidatoNulo.Nome);
                votoCerto.QtdVotos++;
                VotoServices.Salvar();
            }

            txbNumero.Text = null;
            numero = null;


        }
       
    }
}
