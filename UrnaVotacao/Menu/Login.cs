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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            User frmUser = new User();
            frmUser.Show();
        }

        private void BtnAdm_Click(object sender, EventArgs e)
        {
            Adm frmAdm = new Adm();
            frmAdm.Show();
        }
    }
}
