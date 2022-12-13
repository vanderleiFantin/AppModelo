using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class Relatorios_de_funcionarios : Form
    {
        /// <summary>
        /// Instancia a classe FuncionarioController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public Relatorios_de_funcionarios()
        {
            InitializeComponent();
            dgvRelatorioFuncionarios.DataSource = _funcionarioController.ObterTodosFuncionarios();

        }
        /// <summary>
        /// Evento criado para retornar ao frmPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmPrincipal();
            form.Show();
            this.Hide();
        }

        /// <summary>
        /// Evento criado para fechar o frmRelatorios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new Relatorios_de_funcionarios();
            Close();
        }
    }
}