using GuardianPass.Data;
using GuardianPass.Model;
using GuardianPass.Services;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GuardianPass
{
    public partial class frmAdicionar : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly AplicativoService _aplicativoService;
        private readonly AppDbContext _db;
        private readonly AplicativosModel _appAtual;

        #region Eventos
        public frmAdicionar(AplicativosModel appAtual = null, AppDbContext Db = null)
        {
            InitializeComponent();
            _db = Db;
            _usuarioService = new UsuarioService(_db);
            _aplicativoService = new AplicativoService(_db);
            _appAtual = appAtual;
            CarregarDadosApp();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        #endregion

        #region Metodos
        public void CarregarDadosApp()
        {
            if (_appAtual != null)
            {
                txtBoxUsuario.Text = _appAtual.Usuario;
                txtBoxSenha.Text = _appAtual.Senha;
                txtBoxSiteApp.Text = _appAtual.Aplicativo;
            }
        }

        private void ExibirMensagemSucesso(string erro)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = erro;
            Notificacao.BalloonTipIcon = ToolTipIcon.Info;

            Notificacao.ShowBalloonTip(2000);
        }

        private void ExibirMensagemErro(string erro)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = erro;
            Notificacao.BalloonTipIcon = ToolTipIcon.Error;

            Notificacao.ShowBalloonTip(2000);
        }

        private void AtualizarApp()
        {
            var aplicativoAtualizado = new AplicativosModel
            {
                Id = _appAtual.Id,
                Usuario = txtBoxUsuario.Text,
                Senha = txtBoxSenha.Text,
                Aplicativo = txtBoxSiteApp.Text
            };

            if (_aplicativoService.AtualizarAplicativo(aplicativoAtualizado))
            {
                ExibirMensagemSucesso("Dados atualizados com sucesso!");
                AbrirFormsExibir();
            }
            else
                ExibirMensagemErro("Erro ao atualizar os dados. Tente novamente.");
        }

        private void AbrirFormsExibir()
        {
            frmExibir frmExibir = new frmExibir(_db);
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
            { ExibirMensagemErro("O usuário deve ter pelo menos 4 caracteres."); return; }
            if (txtBoxSenha.Text.Length < 4)
            { ExibirMensagemErro("A senha deve ter pelo menos 4 caracteres."); return; }
            if (txtBoxSiteApp.Text.Length < 3)
            { ExibirMensagemErro("O site ou aplicativo deve ter pelo menos 3 caracteres."); return; }

            if (_appAtual != null)
                AtualizarApp();
            else
                SalvarDados();
        }

        public void SalvarDados()
        {
            var novoAplicativo = new AplicativosModel
            {
                UsuarioId = Properties.Settings.Default.ID,
                Usuario = txtBoxUsuario.Text,
                Senha = txtBoxSenha.Text,
                Aplicativo = txtBoxSiteApp.Text
            };

            if(_aplicativoService.InserirAplicativo(novoAplicativo))
            {
                ExibirMensagemSucesso("Cadastro realizado com sucesso!");
                Limpar();
            }
            else
                ExibirMensagemErro("Erro ao cadastrar. Tente novamente.");
        }
        #endregion
    }
}