using GuardianPass.Data;
using GuardianPass.Model;
using GuardianPass.Services;
using GuardianPass.Utils;

namespace GuardianPass
{
    public partial class frmConfig : Form
    {
        private AppDbContext _db;
        private readonly UsuarioService _usuarioService;
        private readonly UsuariosModel _usuariosModel;


        #region Eventos
        public frmConfig(AppDbContext Db)
        {
            InitializeComponent();
            _db = Db;
            _usuarioService = new UsuarioService(_db);
            _usuariosModel = _usuarioService.VerificarExigirSenha(Properties.Settings.Default.ID);
            VerificarACorDoBotao();
        }

        private void btnExigirSenha_Click(object sender, EventArgs e)
        {
            AlterarExigenciaDaSenha();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            Sessao.TrocarConta = true;
            Form1 form1 = new Form1(_db);
            form1.Show();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frmAlterarSenha = new frmAlterarSenha(_db);
            frmAlterarSenha.Show();
            this.Close();
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            frmAvaliacao avaliacao = new frmAvaliacao(_db);
            avaliacao.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }
        #endregion

        #region Metodos
        private void VerificarACorDoBotao()
        {
            if (_usuariosModel.ExigirSenha)
                btnExigirSenha.BackColor = Color.FromArgb(0, 180, 216);
            else
                btnExigirSenha.BackColor = Color.LightGray;
        }

        private void AlterarExigenciaDaSenha()
        {
            UsuariosModel usuario = _usuarioService.VerificarExigirSenha(Properties.Settings.Default.ID);
            if (usuario.ExigirSenha)
            {
                frmExigirSenha frmExigirSenha = new frmExigirSenha(null,_db);
                frmExigirSenha.Show();
                this.Close();
            }
            else
            {
                btnExigirSenha.BackColor = Color.FromArgb(0, 180, 216);
                _usuarioService.AtualizarExigirSenha(Properties.Settings.Default.ID, true);
            }
        }
        #endregion
    }
}
