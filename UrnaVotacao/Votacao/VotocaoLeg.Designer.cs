namespace UrnaVotacao.Votacao
{
    partial class VotocaoLeg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcExe = new System.Windows.Forms.TabControl();
            this.tbpPartidoExe = new System.Windows.Forms.TabPage();
            this.btnClearPart = new System.Windows.Forms.Button();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdCadeiraLeg = new System.Windows.Forms.TextBox();
            this.txtPartidoLeg = new System.Windows.Forms.TextBox();
            this.tbpCandidatoExe = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumCandidato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPartido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Idade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNomeCand = new System.Windows.Forms.TextBox();
            this.btnClearCand = new System.Windows.Forms.Button();
            this.btnSaveCandidato = new System.Windows.Forms.Button();
            this.tbpVotoExe = new System.Windows.Forms.TabPage();
            this.btnClearVoto = new System.Windows.Forms.Button();
            this.btnSaveVoto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdVotos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCandidato = new System.Windows.Forms.ComboBox();
            this.tbcExe.SuspendLayout();
            this.tbpPartidoExe.SuspendLayout();
            this.tbpCandidatoExe.SuspendLayout();
            this.tbpVotoExe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcExe
            // 
            this.tbcExe.Controls.Add(this.tbpPartidoExe);
            this.tbcExe.Controls.Add(this.tbpCandidatoExe);
            this.tbcExe.Controls.Add(this.tbpVotoExe);
            this.tbcExe.Location = new System.Drawing.Point(12, 12);
            this.tbcExe.Name = "tbcExe";
            this.tbcExe.SelectedIndex = 0;
            this.tbcExe.Size = new System.Drawing.Size(378, 168);
            this.tbcExe.TabIndex = 2;
            // 
            // tbpPartidoExe
            // 
            this.tbpPartidoExe.Controls.Add(this.btnClearPart);
            this.tbpPartidoExe.Controls.Add(this.btnSavePart);
            this.tbpPartidoExe.Controls.Add(this.label2);
            this.tbpPartidoExe.Controls.Add(this.label1);
            this.tbpPartidoExe.Controls.Add(this.txtQtdCadeiraLeg);
            this.tbpPartidoExe.Controls.Add(this.txtPartidoLeg);
            this.tbpPartidoExe.Location = new System.Drawing.Point(4, 22);
            this.tbpPartidoExe.Name = "tbpPartidoExe";
            this.tbpPartidoExe.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPartidoExe.Size = new System.Drawing.Size(370, 142);
            this.tbpPartidoExe.TabIndex = 0;
            this.tbpPartidoExe.Text = "Partido";
            this.tbpPartidoExe.UseVisualStyleBackColor = true;
            // 
            // btnClearPart
            // 
            this.btnClearPart.Location = new System.Drawing.Point(163, 103);
            this.btnClearPart.Name = "btnClearPart";
            this.btnClearPart.Size = new System.Drawing.Size(75, 23);
            this.btnClearPart.TabIndex = 4;
            this.btnClearPart.Text = "Limpa";
            this.btnClearPart.UseVisualStyleBackColor = true;
            this.btnClearPart.Click += new System.EventHandler(this.BtnClearPart_Click);
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(62, 103);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(75, 23);
            this.btnSavePart.TabIndex = 2;
            this.btnSavePart.Text = "Salvar";
            this.btnSavePart.UseVisualStyleBackColor = true;
            this.btnSavePart.Click += new System.EventHandler(this.BtnSavePart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade de Cadeiras";
            // 
            // txtQtdCadeiraLeg
            // 
            this.txtQtdCadeiraLeg.Location = new System.Drawing.Point(138, 55);
            this.txtQtdCadeiraLeg.Name = "txtQtdCadeiraLeg";
            this.txtQtdCadeiraLeg.Size = new System.Drawing.Size(100, 20);
            this.txtQtdCadeiraLeg.TabIndex = 1;
            // 
            // txtPartidoLeg
            // 
            this.txtPartidoLeg.Location = new System.Drawing.Point(138, 17);
            this.txtPartidoLeg.Name = "txtPartidoLeg";
            this.txtPartidoLeg.Size = new System.Drawing.Size(100, 20);
            this.txtPartidoLeg.TabIndex = 0;
            // 
            // tbpCandidatoExe
            // 
            this.tbpCandidatoExe.Controls.Add(this.label8);
            this.tbpCandidatoExe.Controls.Add(this.txtNumCandidato);
            this.tbpCandidatoExe.Controls.Add(this.label7);
            this.tbpCandidatoExe.Controls.Add(this.cmbCargo);
            this.tbpCandidatoExe.Controls.Add(this.label4);
            this.tbpCandidatoExe.Controls.Add(this.cmbPartido);
            this.tbpCandidatoExe.Controls.Add(this.label3);
            this.tbpCandidatoExe.Controls.Add(this.Idade);
            this.tbpCandidatoExe.Controls.Add(this.txtIdade);
            this.tbpCandidatoExe.Controls.Add(this.txtNomeCand);
            this.tbpCandidatoExe.Controls.Add(this.btnClearCand);
            this.tbpCandidatoExe.Controls.Add(this.btnSaveCandidato);
            this.tbpCandidatoExe.Location = new System.Drawing.Point(4, 22);
            this.tbpCandidatoExe.Name = "tbpCandidatoExe";
            this.tbpCandidatoExe.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCandidatoExe.Size = new System.Drawing.Size(370, 142);
            this.tbpCandidatoExe.TabIndex = 1;
            this.tbpCandidatoExe.Text = "Candidato";
            this.tbpCandidatoExe.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Numero";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumCandidato
            // 
            this.txtNumCandidato.Location = new System.Drawing.Point(56, 87);
            this.txtNumCandidato.Name = "txtNumCandidato";
            this.txtNumCandidato.Size = new System.Drawing.Size(100, 20);
            this.txtNumCandidato.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Presidente",
            "Governador",
            "Prefeito"});
            this.cmbCargo.Location = new System.Drawing.Point(228, 53);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(121, 21);
            this.cmbCargo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Partido";
            // 
            // cmbPartido
            // 
            this.cmbPartido.FormattingEnabled = true;
            this.cmbPartido.Location = new System.Drawing.Point(228, 18);
            this.cmbPartido.Name = "cmbPartido";
            this.cmbPartido.Size = new System.Drawing.Size(121, 21);
            this.cmbPartido.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome";
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(6, 56);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(34, 13);
            this.Idade.TabIndex = 9;
            this.Idade.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(56, 53);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 8;
            // 
            // txtNomeCand
            // 
            this.txtNomeCand.Location = new System.Drawing.Point(56, 19);
            this.txtNomeCand.Name = "txtNomeCand";
            this.txtNomeCand.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCand.TabIndex = 7;
            // 
            // btnClearCand
            // 
            this.btnClearCand.Location = new System.Drawing.Point(274, 90);
            this.btnClearCand.Name = "btnClearCand";
            this.btnClearCand.Size = new System.Drawing.Size(75, 23);
            this.btnClearCand.TabIndex = 6;
            this.btnClearCand.Text = "Limpa";
            this.btnClearCand.UseVisualStyleBackColor = true;
            this.btnClearCand.Click += new System.EventHandler(this.BtnClearCand_Click);
            // 
            // btnSaveCandidato
            // 
            this.btnSaveCandidato.Location = new System.Drawing.Point(193, 90);
            this.btnSaveCandidato.Name = "btnSaveCandidato";
            this.btnSaveCandidato.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCandidato.TabIndex = 5;
            this.btnSaveCandidato.Text = "Salvar";
            this.btnSaveCandidato.UseVisualStyleBackColor = true;
            this.btnSaveCandidato.Click += new System.EventHandler(this.BtnSaveCandidato_Click);
            // 
            // tbpVotoExe
            // 
            this.tbpVotoExe.Controls.Add(this.btnClearVoto);
            this.tbpVotoExe.Controls.Add(this.btnSaveVoto);
            this.tbpVotoExe.Controls.Add(this.label6);
            this.tbpVotoExe.Controls.Add(this.txtQtdVotos);
            this.tbpVotoExe.Controls.Add(this.label5);
            this.tbpVotoExe.Controls.Add(this.cmbCandidato);
            this.tbpVotoExe.Location = new System.Drawing.Point(4, 22);
            this.tbpVotoExe.Name = "tbpVotoExe";
            this.tbpVotoExe.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVotoExe.Size = new System.Drawing.Size(370, 142);
            this.tbpVotoExe.TabIndex = 2;
            this.tbpVotoExe.Text = "Votos";
            this.tbpVotoExe.UseVisualStyleBackColor = true;
            // 
            // btnClearVoto
            // 
            this.btnClearVoto.Location = new System.Drawing.Point(146, 102);
            this.btnClearVoto.Name = "btnClearVoto";
            this.btnClearVoto.Size = new System.Drawing.Size(75, 23);
            this.btnClearVoto.TabIndex = 18;
            this.btnClearVoto.Text = "Limpa";
            this.btnClearVoto.UseVisualStyleBackColor = true;
            this.btnClearVoto.Click += new System.EventHandler(this.BtnClearVoto_Click);
            // 
            // btnSaveVoto
            // 
            this.btnSaveVoto.Location = new System.Drawing.Point(65, 102);
            this.btnSaveVoto.Name = "btnSaveVoto";
            this.btnSaveVoto.Size = new System.Drawing.Size(75, 23);
            this.btnSaveVoto.TabIndex = 17;
            this.btnSaveVoto.Text = "Salvar";
            this.btnSaveVoto.UseVisualStyleBackColor = true;
            this.btnSaveVoto.Click += new System.EventHandler(this.btnSaveVoto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantidade de Votos";
            // 
            // txtQtdVotos
            // 
            this.txtQtdVotos.Location = new System.Drawing.Point(137, 57);
            this.txtQtdVotos.Name = "txtQtdVotos";
            this.txtQtdVotos.Size = new System.Drawing.Size(121, 20);
            this.txtQtdVotos.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Candidato";
            // 
            // cmbCandidato
            // 
            this.cmbCandidato.FormattingEnabled = true;
            this.cmbCandidato.Location = new System.Drawing.Point(137, 21);
            this.cmbCandidato.Name = "cmbCandidato";
            this.cmbCandidato.Size = new System.Drawing.Size(121, 21);
            this.cmbCandidato.TabIndex = 13;
            // 
            // VotocaoLeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 192);
            this.Controls.Add(this.tbcExe);
            this.Name = "VotocaoLeg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VotocaoLeg";
            this.Load += new System.EventHandler(this.VotocaoLeg_Load);
            this.tbcExe.ResumeLayout(false);
            this.tbpPartidoExe.ResumeLayout(false);
            this.tbpPartidoExe.PerformLayout();
            this.tbpCandidatoExe.ResumeLayout(false);
            this.tbpCandidatoExe.PerformLayout();
            this.tbpVotoExe.ResumeLayout(false);
            this.tbpVotoExe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcExe;
        private System.Windows.Forms.TabPage tbpPartidoExe;
        private System.Windows.Forms.Button btnClearPart;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdCadeiraLeg;
        private System.Windows.Forms.TextBox txtPartidoLeg;
        private System.Windows.Forms.TabPage tbpCandidatoExe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPartido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNomeCand;
        private System.Windows.Forms.Button btnClearCand;
        private System.Windows.Forms.Button btnSaveCandidato;
        private System.Windows.Forms.TabPage tbpVotoExe;
        private System.Windows.Forms.Button btnClearVoto;
        private System.Windows.Forms.Button btnSaveVoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdVotos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCandidato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumCandidato;
    }
}