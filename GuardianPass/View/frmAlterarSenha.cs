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
    public partial class frmAlterarSenha : Form
    {
        DadosUsuario user;
        HashSenha hashSenha = new HashSenha(SHA256.Create());
        Conexao conexao = new Conexao();

        #region Evventos
        public frmAlterarSenha(DadosUsuario user)
        {
            InitializeComponent();
            this.user = user;
            txtBoxSenhaAtual.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            AtivarDesativarCheckBox();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AbrirFormsMenuPrincipal();
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
            if (txtBoxSenhaAtual.Text != user.Senha)
            { ExibirMesagemErro("Preencha todos os campos!"); return; }
            if (txtBoxSenhaNova.Text.Length < 6)
            { ExibirMesagemErro("A nova senha deve ter pelo menos 6 caracteres."); return; }
            if (txtBoxSenhaNova.Text != txtBoxSenhaNovamente.Text)
            { ExibirMesagemErro("As senhas não coincidem."); return; }
             
            AtualizarSenha();
        }

        private void AtualizarSenha()
        {
            try
            {
                if (conexao.AtualizarSenha(hashSenha.CriptografarSenha(txtBoxSenhaNova.Text), user))
                {
                    ExibirMesagemSucesso("Senha alterada com sucesso!");
                    AbrirFormsMenuPrincipal();
                }
                else
                    ExibirMesagemErro("Erro ao alterar a senha. Tente novamente.");
            }
            catch (Exception ex)
            {
                ExibirMesagemErro("Ocorreu um erro: " + ex.Message);
                return;
            }
        }

        private void AbrirFormsMenuPrincipal()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void AtivarDesativarCheckBox()
        {
            txtBoxSenhaAtual.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNova.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
            txtBoxSenhaNovamente.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        #endregion
    }
}
