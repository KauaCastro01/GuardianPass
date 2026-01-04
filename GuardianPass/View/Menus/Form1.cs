using GuardianPass.Data;

namespace GuardianPass
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _db;

        #region Eventos
        public Form1(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(_db);
            frmLogin.Show();
            this.Hide();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro(_db);
            frmCadastro.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#00D2F5");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#00B4D8");
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#FF0000"); 
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = ColorTranslator.FromHtml("#B5171E");
        }
        #endregion
    }
}
