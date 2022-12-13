using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        /// <summary>
        /// Instancia a classe NaturalidadeController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();

            var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNaturalidades;
        }
        /// <summary>
        /// Instancia o método NaturalidadeController, para cadastrar uma nova Naturalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();
            var temNumero =
                Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);

            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao,
                    "Naturalidades geralmente não tem número");
                txtDescricao.Focus();
                return;
            }
            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Naturalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
            var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            _naturalidadeController.DataSource = listaDeNaturalidades;

            var dataSource = controller.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = dataSource;

        }
        /// <summary>
        /// Instancia o método NaturalidadeController, para excluir uma Naturalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var deletou = _naturalidadeController.Delete(txtDescricao.Text);
            if (deletou)
            {
                MessageBox.Show("Naturalidade deletada com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao deletar no banco de dados");

            }
            var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNaturalidades;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            

        }



        private void gvNacionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
           
            txtId.Text = gvNaturalidade.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = gvNaturalidade.CurrentRow.Cells[1].Value.ToString();
            txtId.Text = string.Empty;
        }
        /// <summary>
        /// Instancia o método NaturalidadeController, para atualizar uma Naturalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
            var controller = new NacionalidadeController();
            var resposta = controller.Update(txtDescricao.Text);
            
           
            var atualiza = _naturalidadeController.Update(txtDescricao.Text);

            if (atualiza)
            {
                MessageBox.Show("Naturalidade alterada com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao altera no banco de dados");

            }
            var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = listaDeNaturalidades;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }

        }

        private void frmNaturalidade_Load(object sender, EventArgs e)
        {
            var controller = new NaturalidadeController();
            var dataSource = controller.ObterTodasNaturalidades();
            gvNaturalidade.DataSource = dataSource;

        }

       
    }
}
