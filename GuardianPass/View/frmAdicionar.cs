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
    public partial class frmAdicionar : Form
    {
        public DadosApp dadosapp = null;
        ConexaoApps apps = new ConexaoApps();
        HashSenha hashSenha = new HashSenha(SHA256.Create());

        #region Eventos
        public frmAdicionar(DadosApp app = null)
        {
            this.dadosapp = app;
            InitializeComponent();
            if (app != null)
                CarregarDadosApp(app);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dadosapp != null)
                AtualizarApp();
            else
                SalvarDados();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        #endregion

        #region Metodos
        public void CarregarDadosApp(DadosApp app)
        {
            if (app != null)
            {
                txtBoxUsuario.Text = app.Usuario;
                txtBoxSenha.Text = app.Senha;
                txtBoxSiteApp.Text = app.SiteApp;
            }
        }

        private void ExibirMesagemSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExibirMesagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AtualizarApp()
        {
            try
            {
                VerificarCampos();
                if (apps.AtualizarApp(txtBoxUsuario.Text, txtBoxSenha.Text, txtBoxSiteApp.Text, dadosapp.Usuario, dadosapp.SiteApp))
                {
                    ExibirMesagemSucesso("Dados atualizados com sucesso!");
                    AbrirFormsExibir();
                }
                else
                    ExibirMesagemErro("Erro ao atualizar os dados. Tente novamente.");
            }
            catch (Exception ex)
            {
                ExibirMesagemErro("Ocorreu um erro: " + ex.Message);
                return;
            }
        }

        private void AbrirFormsExibir()
        {
            frmExibir frmExibir = new frmExibir();
            frmExibir.Show();
            this.Close();
        }

        public void Limpar()
        {
            txtBoxUsuario.Clear();
            txtBoxSenha.Clear();
            txtBoxSiteApp.Clear();
        }

        public void VerificarCampos()
        {
            if (txtBoxUsuario.Text.Length < 4)
            { ExibirMesagemErro("O usuário deve ter pelo menos 4 caracteres."); return; }
            if (txtBoxSenha.Text.Length < 4)
            { ExibirMesagemErro("A senha deve ter pelo menos 4 caracteres."); return; }
            if (txtBoxSiteApp.Text.Length < 3)
            { ExibirMesagemErro("O site ou aplicativo deve ter pelo menos 3 caracteres."); return; }
        }

        public void SalvarDados()
        {
            try
            {
                VerificarCampos();
                if (apps.CadastrarApps(txtBoxUsuario.Text, txtBoxSenha.Text, txtBoxSiteApp.Text))
                {
                    ExibirMesagemSucesso("Cadastro realizado com sucesso!");
                    Limpar();
                }
                else
                    ExibirMesagemErro("Erro ao cadastrar. Tente novamente.");
            }
            catch (Exception ex)
            {
                ExibirMesagemErro("Ocorreu um erro: " + ex.Message);
                return;
            }
        }
        #endregion
    }
}
