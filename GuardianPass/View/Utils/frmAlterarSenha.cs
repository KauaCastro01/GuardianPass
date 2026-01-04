using GuardianPass.Data;
using GuardianPass.Model;
using GuardianPass.Services;
using GuardianPass.Utils;


namespace GuardianPass
{
    public partial class frmAlterarSenha : Form
    {
        HashSenha hashSenha = new HashSenha();
        private readonly AppDbContext _db;
        private readonly UsuariosModel _usuariosModel;
        private readonly UsuarioService _usuarioService;


        #region Eventos
        public frmAlterarSenha(AppDbContext Db)
        {
            InitializeComponent();
            _db = Db;
            _usuarioService = new UsuarioService(_db);
            txtBoxSenhaAtual.Focus();
            _usuariosModel = _usuarioService.VerificarExigirSenha(Properties.Settings.Default.ID);
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
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Error;

            Notificacao.ShowBalloonTip(2000);
        }

        private void ExibirMesagemSucesso(string mensagem)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Info;

            Notificacao.ShowBalloonTip(2000);
        }

        private void VerificarCampos()
        {
            if (hashSenha.CriptografarSenha(txtBoxSenhaAtual.Text) != _usuariosModel.Senha)
            { ExibirMesagemErro("Senha atual inválida!"); return; }
            if (txtBoxSenhaNova.Text.Length < 6)
            { ExibirMesagemErro("A nova senha deve ter pelo menos 6 caracteres."); return; }
            if (txtBoxSenhaNova.Text != txtBoxSenhaNovamente.Text)
            { ExibirMesagemErro("As senhas não coincidem."); return; }
            if (txtBoxSenhaNova.Text == txtBoxSenhaAtual.Text)
            { ExibirMesagemErro("As senha nova não pode ser igual a atual."); return; }

            AtualizarSenha();
        }

        private void AtualizarSenha()
        {
            if (_usuarioService.AtualizarSenha(Properties.Settings.Default.ID, hashSenha.CriptografarSenha(txtBoxSenhaNova.Text)))
            {
                ExibirMesagemSucesso("Senha alterada com sucesso!");
                AbrirFormsMenuPrincipal();
            }
            else
                ExibirMesagemErro("Erro ao alterar a senha. Tente novamente.");
        }

        private void AbrirFormsMenuPrincipal()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
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
