using GuardianPass.Data;
using GuardianPass.Utils;
using GuardianPass.View.Aplicativo;

namespace GuardianPass
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly AppDbContext _db;

        #region Eventos
        public frmMenuPrincipal(AppDbContext Db)
        {
            InitializeComponent();
            _db = Db;
            Sessao.TrocarConta = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionar frmAdicionar = new frmAdicionar(null, _db);
            frmAdicionar.Show();
            this.Close();
        }

        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            frmGerarSenha frmGerarSenha = new frmGerarSenha(_db);
            frmGerarSenha.Show();
            this.Close();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            frmExibir frmExibir = new frmExibir(_db);
            frmExibir.Show();
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig(_db);
            frmConfig.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnVerificarSeguranca_Click(object sender, EventArgs e)
        {
            frmVerificarSeguranca frmVerificarSeguranca = new frmVerificarSeguranca(_db);
            frmVerificarSeguranca.Show();
            this.Close();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.TrocarConta = false;
        }
        #endregion
    }
}
