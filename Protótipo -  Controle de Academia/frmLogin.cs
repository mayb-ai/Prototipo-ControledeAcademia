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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int mat = 0;

            if(!int.TryParse(txtMatricula.Text, out mat))
            {
                MessageBox.Show("Número inválido");
                txtMatricula.Focus();
            }

            for(int c = 0; c < 1; c++)
            {
                mat= Convert.ToInt32(txtMatricula.Text[c]);
            }

            if(mat == '1')
            {
                frmAdm FrmAdm = new frmAdm();
                FrmAdm.Show();
            }
                
            if(mat == '2')
            {
                frmAdmissao FrmAdmissao = new frmAdmissao();
                FrmAdmissao.Show();
            }

            if(mat == '3')
            {
                frmManutencao FrmManutencao = new frmManutencao();
                FrmManutencao.Show();
            }

            if (mat == '4')
            {
                frmProfessores FrmProfessores = new frmProfessores();
                FrmProfessores.Show();
            }
            
            if(mat == '5')
            {
                frmRecepcao FrmRecepcao = new frmRecepcao();
                FrmRecepcao.Show();
            }
        }
    }
}
