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
    }
}
