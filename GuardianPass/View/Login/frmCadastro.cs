using GuardianPass.Data;
using GuardianPass.Model;
using GuardianPass.Services;
using GuardianPass.Utils;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmCadastro : Form
    {
        private HashSenha hashSenha = new HashSenha();
        private readonly AppDbContext _db;
        private readonly UsuarioService _usuarioService;

        #region Eventos
        public frmCadastro(AppDbContext Db)
        {
            InitializeComponent();
            _db = Db;
            _usuarioService = new UsuarioService(_db);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(_db);
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
        private void ExibirMensagemErro(string erro)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = erro;
            Notificacao.BalloonTipIcon = ToolTipIcon.Error;

            Notificacao.ShowBalloonTip(2000);
        }

        private void VerificarCampos()
        {
            if (txtBoxUsuario.Text.Length < 4)
                { ExibirMensagemErro("O nome de usuário deve ter pelo menos 4 caracteres."); return; }
            if (txtBoxSenha.Text.Length < 6)
                { ExibirMensagemErro("A senha deve ter pelo menos 6 caracteres."); return; }
            if (txtBoxSenha.Text != txtBoxSenhaNovamente.Text)
                { ExibirMensagemErro("As senhas não coincidem."); return; }

            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            var usuario = new UsuariosModel()
            {
                Usuario = txtBoxUsuario.Text,
                Senha = hashSenha.CriptografarSenha(txtBoxSenha.Text)
            };
             
            if (_usuarioService.CriarUsuario(usuario))
            {
                SalvarUsuarioLocal();
                AbrirFormsMenuPrincipal();
            }
            else
                ExibirMensagemErro("Erro ao realizar o cadastro. Tente novamente.");
        }

        private void SalvarUsuarioLocal()
        {
            Properties.Settings.Default.ID = _usuarioService.ObterIdUsuario(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text));
        }

        private void AbrirFormsMenuPrincipal()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        #endregion
    }
}