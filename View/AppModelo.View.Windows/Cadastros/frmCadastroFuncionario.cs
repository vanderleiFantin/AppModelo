using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        /// <summary>
        /// Instancia a classe FuncionarioController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private FuncionarioController _funcionarioController = new FuncionarioController();

        /// <summary>
        /// Instancia a classe NacionalidadeController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();

        /// <summary>
        /// Instancia a classe NaturalidadeController em uma propriedade para utilizá-la onde necessário.
        /// </summary>
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        /// <summary>
        /// <summary>
        /// Class <c>frmCadastroFuncionario</c> construtor chama o metódo FormatarCamposObrigatorios para indicar
        /// o usuário quais os campos são obrigatórios o preenchimento.
        /// Também chama o metódo ObterTodasNacionalidades/ObterTodasNaturalidades dentro de uma combobox.
        /// </summary>
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);


            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "Id";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "Id";
        }


        /// <summary>
        /// Faz a pesquisa de números de cep válidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instancia do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }
        /// <summary>
        /// Faz a verificação se há somente letras no nome cadastrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //primeira regra nome < que 6 letras
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }



            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider
                        .SetError(txtNome, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();


        }
        /// <summary>
        /// Faz a verificação se o número de CPF é válido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }
        //pega a data de hoje e acrescenta 1 dia
        private void txtDataNascimento_Validating(object sender, CancelEventArgs e)
        {
            var dataNascimento = DateTime.Parse(txtDataNascimento.Text);

        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Utiliza a propriedade _funcionarioController, para cadastrar um novo funcionário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            {

                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                int numero = int.Parse(txtEnderecoNumero.Text);
                var obterIndexNacionalidade = cmbNacionalidade.SelectedIndex;
                var obterIndexNaturalidade = cmbNaturalidade.SelectedIndex;

                var salvou = _funcionarioController.Cadastrar(txtNome.Text, dataNascimento, rbMasculino.Checked,
                    txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text,
                    numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text,
                    obterIndexNacionalidade, obterIndexNaturalidade);

                if (salvou)
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário");
                }


            }
        }
        /// <summary>
        /// Obtém a lista de nacionalidades do frmNacionalidades para o cadastro do funcionário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterIndexNacionalidade = cmbNacionalidade.SelectedIndex;
            string Index = cmbNacionalidade.Text;

        }
        /// <summary>
        /// Obtém a lista de naturalidades do frmNaturalidade para o cadastro do funcionário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNaturalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterIndexNaturalidade = cmbNaturalidade.SelectedIndex;
            string Index = cmbNaturalidade.Text;

        }
        /// <summary>
        /// Método criado para limpar as textbox após cadastro de funcionário
        /// </summary>
        /// <param name="crtl"></param>
        public static void LimparDados(Control crtl)
        {
            foreach (Control c in crtl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).MinDate = new DateTime(1900, 1, 1);
                    ((DateTimePicker)c).MaxDate = new DateTime(2100, 1, 1);
                    ((DateTimePicker)c).Value = DateTime.Now.Date < ((DateTimePicker)c).MinDate ? ((DateTimePicker)c).MinDate : DateTime.Now.Date > ((DateTimePicker)c).MaxDate ? ((DateTimePicker)c).MaxDate : DateTime.Now.Date;
                    if (((DateTimePicker)c).ShowCheckBox)
                        ((DateTimePicker)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0 < ((NumericUpDown)c).Minimum ? ((NumericUpDown)c).Minimum : 0 > ((NumericUpDown)c).Maximum ? ((NumericUpDown)c).Maximum : 0;// ((NumericUpDown)c).Minimum;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
                else if (c is Label)
                {
                    //((Label)c).Text = "";
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }
                else if (c is TrackBar)
                    ((TrackBar)c).Value = ((TrackBar)c).Minimum;
                else if (c.HasChildren)
                {
                    if (c is TabControl)
                        ((TabControl)c).SelectedIndex = 0;

                    LimparDados(c);
                }
            }


        }
    }
}
