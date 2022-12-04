using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaVotacao.Votacao.Classes.Candidato;
using UrnaVotacao.Votacao.Classes.Partido;

namespace UrnaVotacao.Votacao
{
    public partial class VotacaoExe : Form
    {
        PartidoServices PartidoServices = new PartidoServices();
        CandidatoServices candiServices = new CandidatoServices();
        VotoServices VotoServices = new VotoServices();

        public VotacaoExe()
        {
            InitializeComponent();
        }

        private void BtnClearVoto_Click(object sender, EventArgs e)
        {
            txtQtdVotos.Text = null;
            cmbCandidato.Text = null;
        }

        private void BtnClearCand_Click(object sender, EventArgs e)
        {
            txtIdade.Text = null;
            txtNomeCand.Text = null;
            cmbPartido.Text = null;
            cmbCargo.Text = null;
        }

        private void BtnClearPart_Click(object sender, EventArgs e)
        {
            txtNomeCand.Text = null;
            txtQtdCadeiraExe.Text = null;
        }

        private void BtnSaveCandidato_Click(object sender, EventArgs e)
        {
            Candidato criaCandidato = new Candidato(cmbPartido.Text, txtNomeCand.Text, Convert.ToInt32(txtIdade.Text), Convert.ToInt32(txtNumCandidato.Text));
            candiServices.Adicionar(criaCandidato);
            candiServices.Salvar();
            txtIdade.Text = null;
            txtNomeCand.Text = null;
            txtNumCandidato.Text = null;
            cmbPartido.Text = null;
            cmbCargo.Text = null;
        }

        private void VotacaoExe_Load(object sender, EventArgs e)
        {
            // Carrega Partido
            PartidoServices.Carregar();
            DataSet partidos = new DataSet();
            partidos.ReadXml("Partidos.xml");
            cmbPartido.DataSource = partidos.Tables["Partido"];
            cmbPartido.DisplayMember = "NomePartido";
            cmbPartido.SelectedIndex = -1;

            //Carrega Candidato
            candiServices.Carregar();
            DataSet candidatos = new DataSet();
            candidatos.ReadXml("Candidatos.xml");
            cmbCandidato.DataSource = candidatos.Tables["Candidato"];
            cmbCandidato.DisplayMember = "Nome";
            cmbCandidato.SelectedIndex = -1;
        }

        private void BtnSavePart_Click(object sender, EventArgs e)
        {
            Partido criaPartido = new Partido(Convert.ToInt32(txtQtdCadeiraExe.Text), txtPartidoExe.Text);
            PartidoServices.Adicionar(criaPartido);
            PartidoServices.Salvar();
            txtNomeCand.Text = null;
            txtQtdCadeiraExe.Text = null;
        }

        private void btnSaveVoto_Click(object sender, EventArgs e){

            CandidatoServices candServices = new CandidatoServices();
            candServices.Carregar();
            List<Candidato> cands = candServices.Mostrar();

            VotoServices VotoServices = new VotoServices();
            VotoServices.Carregar();
            List<Votos> votos = VotoServices.Mostrar();

            Votos votoCerto = votos.Find(i => i.NomeCand == cmbCandidato.Text);
            votoCerto.QtdVotos+= Convert.ToInt32(txtQtdVotos.Text);

            VotoServices.Salvar();
            cmbCandidato.Text = null;
            txtQtdVotos.Text = null;
        }
    }
}
