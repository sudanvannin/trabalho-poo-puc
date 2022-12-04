namespace UrnaVotacao.Menu
{
    partial class Adm
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
            this.btnLeg = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnExe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeg
            // 
            this.btnLeg.Location = new System.Drawing.Point(12, 12);
            this.btnLeg.Name = "btnLeg";
            this.btnLeg.Size = new System.Drawing.Size(75, 41);
            this.btnLeg.TabIndex = 0;
            this.btnLeg.Text = "Cadastro Executivo";
            this.btnLeg.UseVisualStyleBackColor = true;
            this.btnLeg.Click += new System.EventHandler(this.BtnLeg_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 71);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Exibir";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(114, 71);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Exportar";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(114, 12);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(75, 41);
            this.btnExe.TabIndex = 3;
            this.btnExe.Text = "Cadastro Legislativo";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.BtnExe_Click);
            // 
            // Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 106);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnLeg);
            this.Name = "Adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adm";
            this.Load += new System.EventHandler(this.Adm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeg;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnExe;
    }
}