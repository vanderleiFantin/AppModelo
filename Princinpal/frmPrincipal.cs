using AppModelo.View.Windows.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Princinpal
{
    public partial class frmPrincipalMdi : Form
    {
        private Color backColor;

        public frmPrincipalMdi()
        {
            InitializeComponent();
        }

        private void btnNacionalidade_Click(object sender, EventArgs e)
        {
            frmNacionalidades _frmNacionalidades = new frmNacionalidades();

            _frmNacionalidades.Show();
            //_frmNacionalidades.ShowDialog();
        }

        private void btnNaturalidade_Click(object sender, EventArgs e)
        {
            frmNaturalidade _frmNaturalidade = new frmNaturalidade();

            _frmNaturalidade.Show();
            //_frmNaturalidade.ShowDialog();
        }

        private void btnCadastraFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario _frmCadastroFuncionario = new frmCadastroFuncionario();

            _frmCadastroFuncionario.Show();
            //_frmCadastroFuncionario.ShowDialog();
        }
    }
}
