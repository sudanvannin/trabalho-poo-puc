using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaVotacao.Menu
{
    public partial class ExibirDados : Form
    {
        public ExibirDados()
        {
            InitializeComponent();
        }

        private void ExibirDados_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\Users\Pichau\Desktop\UrnaVotacao\UrnaVotacao\UrnaVotacao\bin\Debug\Candidatos.xml");
            dtgExibirCand.DataSource = dataSet.Tables[0];

            DataSet dataSetPart = new DataSet();
            dataSetPart.ReadXml(@"C:\Users\Pichau\Desktop\UrnaVotacao\UrnaVotacao\UrnaVotacao\bin\Debug\Partidos.xml");
            dtgExibirPart.DataSource = dataSetPart.Tables[0];

            DataSet dataSetVoto = new DataSet();
            dataSetVoto.ReadXml(@"C:\Users\Pichau\Desktop\UrnaVotacao\UrnaVotacao\UrnaVotacao\bin\Debug\Votos.xml");
            dtgExibirVoto.DataSource = dataSetVoto.Tables[0];
        }
    }
}
