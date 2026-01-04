using GuardianPass.Data;
using GuardianPass.Model;
using GuardianPass.Services;
using GuardianPass.Utils;
using System.Windows.Forms;


namespace GuardianPass
{
    public partial class frmExigirSenha : Form
    {
        AplicativosModel dadosApp = null;
        private readonly AppDbContext _db;
        private readonly UsuarioService _usuarioService;
        HashSenha hashSenha = new HashSenha();

        #region Eventos
        public frmExigirSenha(AplicativosModel dadosApp = null, AppDbContext Db = null)
        {
            this.dadosApp = dadosApp;
            InitializeComponent();
            _db = Db;
            _usuarioService = new UsuarioService(_db);
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarSenha();
        }

        #endregion

        #region Metodos
        private void VerificarSenha()
        {
            UsuariosModel usuario = _usuarioService.VerificarExigirSenha(Properties.Settings.Default.ID);

            if (hashSenha.CriptografarSenha(txtBoxSenha.Text) == usuario.Senha)
            {
                if (dadosApp != null)
                    AbrirFormsEditar();
                else
                    AbrirFormsConfig();
            }
            else
            {
                Notificacao.Visible = true;

                Notificacao.BalloonTipTitle = "GuardianPass";
                Notificacao.BalloonTipText = "Senha incorreta. Tente novamente.";
                Notificacao.BalloonTipIcon = ToolTipIcon.Error;

                Notificacao.ShowBalloonTip(2000);
            }
        }

        private void AbrirFormsConfig()
        {
            _usuarioService.AtualizarExigirSenha(Properties.Settings.Default.ID, false);
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
        }

        private void AbrirFormsEditar()
        {
            frmAdicionar frmAdicionar = new frmAdicionar(dadosApp, _db);
            frmAdicionar.Show();
            this.Close();
        }

        #endregion
    }
}
