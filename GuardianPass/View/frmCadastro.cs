using GuardianPass.Controller;
using GuardianPass.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmCadastro : Form
    {
        HashSenha hashSenha = new HashSenha(SHA256.Create());
        Conexao conexao = new Conexao();

        #region Eventos
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        #endregion

        #region Metodos
        private void ExibirMesagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ExibirMesagemSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VerificarCampos()
        {
            if (txtBoxUsuario.Text.Length < 4)
                { ExibirMesagemErro("O nome de usuário deve ter pelo menos 4 caracteres."); return; }
            if (txtBoxSenha.Text.Length < 6)
                { ExibirMesagemErro("A senha deve ter pelo menos 6 caracteres."); return; }
            if (txtBoxSenha.Text != txtBoxSenhaNovamente.Text)
                { ExibirMesagemErro("As senhas não coincidem."); return; }

            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            if (conexao.Cadastro(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)))
            {
                PopularClasse();
                AbrirFormsMenuPrincipal();
            }
            else
                ExibirMesagemErro("Erro ao realizar o cadastro. Tente novamente.");
        }

        private void AbrirFormsMenuPrincipal()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void PopularClasse()
        {
            DadosUsuario user = new DadosUsuario
            {
                Id = conexao.PegarId(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)),
                Usuario = txtBoxUsuario.Text,
                Senha = txtBoxSenha.Text,
                Exigir = conexao.PegarExigirSenha(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text))
            };
            user.Salvar(user);
        }

        #endregion
    }
}
