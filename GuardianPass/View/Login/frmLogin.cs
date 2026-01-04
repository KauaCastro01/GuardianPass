using GuardianPass.Data;
using GuardianPass.Services;
using GuardianPass.Utils;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmLogin : Form
    {
        private LembrarDeMim lembrarDeMim = new LembrarDeMim();
        private HashSenha hashSenha = new HashSenha();
        private readonly UsuarioService _usuarioService;
        private readonly AppDbContext _db;
        private bool TrocarConta = Sessao.TrocarConta;

        #region Eventos
        public frmLogin(AppDbContext Db)
        {
            InitializeComponent();
            CarregarLembrarDeMim();
            _db = Db;
            _usuarioService = new UsuarioService(_db);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            is_Logado();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
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
        }

        private void cBoxLembrarDeMim_CheckedChanged(object sender, EventArgs e)
        {
            LembrarDeMim();
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#00D2F5");
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#00B4D8");
        }

        private void btnVoltar_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#FF0000");
        }

        private void btnVoltar_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#B5171E");
        }

        #endregion

        #region Metodos
        public void CarregarLembrarDeMim()
        {
            if (Properties.Settings.Default.Lembrar)
            {
                txtBoxUsuario.Text = Properties.Settings.Default.Usuario;
                txtBoxSenha.Text = Properties.Settings.Default.Senha;
                cBoxLembrarDeMim.Checked = true;
            }
            else
            {
                txtBoxUsuario.Text = "";
                txtBoxSenha.Text = "";
                cBoxLembrarDeMim.Checked = false;
            }
        }

        private void EfetuarLogin()
        {
            if (_usuarioService.Login(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)))
            {
                SalvarUsuarioLocal();
                AbrirFomrsMenuPrincipal();
            }
            else
                ExibirMensagemErro("Usuário ou senha inválidos.");
        }

        private void LoginAutomatico()
        {
            if (_usuarioService.Login(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)))
            {
                SalvarUsuarioLocal();
                AbrirFomrsMenuPrincipal();
            }
        }

        private void AbrirFomrsMenuPrincipal()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void ExibirMensagemErro(string erro)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = erro;
            Notificacao.BalloonTipIcon = ToolTipIcon.Error;

            Notificacao.ShowBalloonTip(2000);
        }

        private void LembrarDeMim()
        {
            if (cBoxLembrarDeMim.Checked)
                lembrarDeMim.Salvar(txtBoxUsuario.Text, txtBoxSenha.Text, cBoxLembrarDeMim.Checked);
            else
                lembrarDeMim.Apagar();
        }

        private void SalvarUsuarioLocal()
        {
            Properties.Settings.Default.ID = _usuarioService.ObterIdUsuario(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text));
        }

        private void is_Logado()
        {
            if (!TrocarConta)
                LoginAutomatico();
        }
        #endregion
    }
}
