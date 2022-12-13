using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppModelo.View.Windows.Cadastros
{
    /// <summary>
    /// Instancia a classe NacionalidadeController em uma propriedade para utilizá-la onde necessário.
    /// </summary>
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
        /// <summary>
        /// Instancia o método NacionalidadeController, para cadastrar uma nova Nacionalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Instancia o método NacionalidadeController, para cadastrar uma nova Nacionalidade.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            //var vazio = Helpers.CaixaVazia.NaoExisteTexto(txtDescricao.Text);
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
            
            if (temNumero )
            {
                errorProvider1.SetError(txtDescricao,
                    "Naturalidades geralmente não tem número");
                txtDescricao.Focus();
                return;
            }
            var controller = new NacionalidadeController();
            var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
        /// <summary>
        /// Instancia o método NacionalidadeController, para excluir uma Nacionalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var control = new NacionalidadeController();
            var deletou = _nacionalidadeController.Delete(txtDescricao.Text);
            if (deletou)
            {
                MessageBox.Show("Nacionalidade deletada com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao deletar no banco de dados");

            }
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {


        }



        private void gvNacionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Instancia o método NacionalidadeController, para atualizar uma Nacionalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            
            //var descricaoAtual = _nacionalidadeController.(idAtual, txtDescricao.Text);


            txtId.Text = gvNacionalidades.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = gvNacionalidades.CurrentRow.Cells[1].Value.ToString();
            txtId.Text = string.Empty;
        }
        
        /// <summary>
        /// Instancia o método NacionalidadeController, para atualizar uma Nacionalidade cadastrada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var idAtual = int.Parse(txtId.Text);
            var controller = new NacionalidadeController();
            var atualiza = _nacionalidadeController.Update(idAtual, txtDescricao.Text);

            if ((bool)atualiza)
            {
                MessageBox.Show("Nacionalidade alterada com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao altera no banco de dados");

            }
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
        /// <summary>
        /// Evento criado para limitar o ID em números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {
                
                e.Handled = true;

            }
            
        }
    }
}
