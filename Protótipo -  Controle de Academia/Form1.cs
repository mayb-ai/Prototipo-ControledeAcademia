using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protótipo____Controle_de_Academia
{
    public partial class frmInicial : Form
    {
        private frmLogin loginForm;
        public frmInicial()
        {
            InitializeComponent();

            frmLogin FrmLogin = new frmLogin();
            FrmLogin.TopLevel = false;
            FrmLogin.Show();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            frmLogin FrmLogin = new frmLogin();
            FrmLogin.Show();

            frmInicial FrmInicial = new frmInicial();
            FrmLogin.Visible = !FrmInicial.Visible;
            
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            frmLogin FrmLogin = new frmLogin();
            FrmLogin.Show();

        }

        private void btnAdmissao_Click(object sender, EventArgs e)
        {
            frmLogin FrmLogin = new frmLogin();
            FrmLogin.Show();
        }

        private void btnRecep_Click(object sender, EventArgs e)
        {
            frmLogin FrmLogin = new frmLogin();
            FrmLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin FrmLogin = new frmLogin();
            FrmLogin.Show();
        }
    }
}
