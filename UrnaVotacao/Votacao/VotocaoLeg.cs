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
    public partial class VotocaoLeg : Form
    {
        MetodosPartido metodosPartido = new MetodosPartido();
        Metodos metodosCandidato = new Metodos();
        MetodosVotos metodosVotos = new MetodosVotos();

        public VotocaoLeg()
        {
            InitializeComponent();
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
            txtQtdCadeiraLeg.Text = null;
        }

        private void BtnClearVoto_Click(object sender, EventArgs e)
        {
            txtQtdVotos.Text = null;
            cmbCandidato.Text = null;
        }

        private void BtnSaveCandidato_Click(object sender, EventArgs e)
        {
            Candidato criaCandidato = new Candidato(cmbPartido.Text, txtNomeCand.Text, Convert.ToInt32(txtIdade.Text), Convert.ToInt32(txtNumCandidato.Text));
            metodosCandidato.Adicionar(criaCandidato);
            metodosCandidato.Salvar();
            txtIdade.Text = null;
            txtNomeCand.Text = null;
            txtNumCandidato.Text = null;
            cmbPartido.Text = null;
            cmbCargo.Text = null;
        }

        private void VotocaoLeg_Load(object sender, EventArgs e)
        {
            // Carrega Partido
            metodosPartido.Carregar();
            DataSet partidos = new DataSet();
            partidos.ReadXml("Partidos.xml");
            cmbPartido.DataSource = partidos.Tables["Partido"];
            cmbPartido.DisplayMember = "NomePartido";
            cmbPartido.SelectedIndex = -1;

            //Carrega Candidato
            metodosCandidato.Carregar();
            DataSet candidatos = new DataSet();
            candidatos.ReadXml("Candidatos.xml");
            cmbCandidato.DataSource = candidatos.Tables["Candidato"];
            cmbCandidato.DisplayMember = "nomeNum";
            cmbCandidato.SelectedIndex = -1;
        }

        private void BtnSavePart_Click(object sender, EventArgs e)
        {
            Partido criaPartido = new Partido(Convert.ToInt32(txtQtdCadeiraLeg.Text), txtPartidoLeg.Text);
            metodosPartido.Adicionar(criaPartido);
            metodosPartido.Salvar();
            txtNomeCand.Text = null;
            txtQtdCadeiraLeg.Text = null;
        }

        private void btnSaveVoto_Click(object sender, EventArgs e)
        {
            string[] cand = cmbCandidato.Text.Split('-');
            Votos criaVoto = new Votos(cand[0], Convert.ToInt32(txtQtdVotos.Text), Convert.ToInt32(cand[1]));
            metodosVotos.Adicionar(criaVoto);
            metodosVotos.Salvar();
            cmbCandidato.Text = null;
            txtQtdVotos.Text = null;
        }
    }
}
