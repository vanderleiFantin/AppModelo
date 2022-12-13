using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        //Crio uma variável global para colocar no txtEmail
        public static string SetNomeUsuario = "";
        public static string HoraLogin = "";
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método criado para login do usuário através da verificação de email e senha já cadastrados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogar_Click(object sender, EventArgs e)
        {
            //1 passo validar o e-mail
            //Crio uma variável global para colocar no txtEmail
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if(emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está errado");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuarioEncontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado");
            }
        }
        /// <summary>
        /// Chama o frmRecuperarSenha para o usuário executar a recuperação de senha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@admin.com";
            txtSenha.Text = "admin";
        }
        /// <summary>
        /// Evento criado para fechar o frmLogin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            var form = new frmLogin();
            Close();
        }
    }
}
