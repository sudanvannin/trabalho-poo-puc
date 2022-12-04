namespace UrnaVotacao.Menu
{
    partial class ExibirDados
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
            this.dtgExibirPart = new System.Windows.Forms.DataGridView();
            this.dtgExibirVoto = new System.Windows.Forms.DataGridView();
            this.dtgExibirCand = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExibirPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExibirVoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExibirCand)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgExibirPart
            // 
            this.dtgExibirPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExibirPart.Location = new System.Drawing.Point(12, 260);
            this.dtgExibirPart.Name = "dtgExibirPart";
            this.dtgExibirPart.Size = new System.Drawing.Size(321, 203);
            this.dtgExibirPart.TabIndex = 5;
            // 
            // dtgExibirVoto
            // 
            this.dtgExibirVoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExibirVoto.Location = new System.Drawing.Point(370, 28);
            this.dtgExibirVoto.Name = "dtgExibirVoto";
            this.dtgExibirVoto.Size = new System.Drawing.Size(321, 203);
            this.dtgExibirVoto.TabIndex = 4;
            // 
            // dtgExibirCand
            // 
            this.dtgExibirCand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExibirCand.Location = new System.Drawing.Point(12, 28);
            this.dtgExibirCand.Name = "dtgExibirCand";
            this.dtgExibirCand.Size = new System.Drawing.Size(321, 203);
            this.dtgExibirCand.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Candidatos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Votos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Partidos";
            // 
            // ExibirDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgExibirPart);
            this.Controls.Add(this.dtgExibirVoto);
            this.Controls.Add(this.dtgExibirCand);
            this.Name = "ExibirDados";
            this.Text = "ExibirDados";
            this.Load += new System.EventHandler(this.ExibirDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExibirPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExibirVoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExibirCand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgExibirPart;
        private System.Windows.Forms.DataGridView dtgExibirVoto;
        private System.Windows.Forms.DataGridView dtgExibirCand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}