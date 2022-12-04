using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UrnaVotacao.Menu
{
    public partial class Adm : Form
    {
        public Adm()
        {
            InitializeComponent();
        }

        private void BtnExe_Click(object sender, EventArgs e)
        {
            Votacao.VotacaoExe frmExe = new Votacao.VotacaoExe();
            frmExe.Show();
        }

        private void BtnLeg_Click(object sender, EventArgs e)
        {
            Votacao.VotocaoLeg frmLeg = new Votacao.VotocaoLeg();
            frmLeg.Show();
        }

        private void Adm_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ExibirDados frmExibir = new ExibirDados();
            frmExibir.Show();
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {


            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\Users\kayro.alves\Desktop\UrnaVotacao\UrnaVotacao\bin\Debug\Candidatos.xml");

            DataSet dataSetPart = new DataSet();
            dataSetPart.ReadXml(@"C:\Users\kayro.alves\Desktop\UrnaVotacao\UrnaVotacao\bin\Debug\Partidos.xml");

            DataSet dataSetVoto = new DataSet();
            dataSetVoto.ReadXml(@"C:\Users\kayro.alves\Desktop\UrnaVotacao\UrnaVotacao\bin\Debug\Votos.xml");

            string CaminhoNome = "C:\\Users\\kayro.alves\\Desktop\\resultadoEleicao.txt";

            StreamWriter x = File.CreateText(CaminhoNome);
            x.WriteLine();
            x.WriteLine("Quantidade de Votos:");
            x.WriteLine();
            foreach (DataRow row in dataSetVoto.Tables[0].Rows){

                foreach (object item in row.ItemArray){

                    x.Write((string)item + "\t");
                }
                x.WriteLine();
            }
            x.WriteLine();
            x.WriteLine("Cadeiras por Partido:");
            x.WriteLine();
            foreach (DataRow row in dataSetPart.Tables[0].Rows)
            {

                foreach (object item in row.ItemArray)
                {

                    x.Write((string)item + "\t");
                }
                x.WriteLine();
            }
            x.WriteLine();
            x.WriteLine("Candidatos da Eleição:");
            x.WriteLine();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {

                foreach (object item in row.ItemArray)
                {

                    x.Write((string)item + "\t");
                }
                x.WriteLine();
            }
            x.Close();
        }
    }
}
