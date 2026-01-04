using GuardianPass.Data;
using System.Text.RegularExpressions;

namespace GuardianPass.View.Aplicativo
{
    public partial class frmVerificarSeguranca : Form
    {
        private readonly AppDbContext _db;
        #region Eventos
        public frmVerificarSeguranca(AppDbContext Db)
        {
            InitializeComponent();
            _db = Db;
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {
            HabilitarLabel();
            lblNivelSeguranca.Text = VerificarForca();
            AlterarCor();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        #endregion

        #region Metodos
        private void HabilitarLabel()
        {
            if (string.IsNullOrEmpty(txtBoxSenha.Text))
                lblNivelSeguranca.Visible = false;
            else
                lblNivelSeguranca.Visible = true;
        }

        public string VerificarForca()
        {
            string senha = txtBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(senha))
                return "Senha inválida";

            int score = 0;

            if (senha.Length >= 8) score++;
            if (senha.Length >= 12) score++;
            if (Regex.IsMatch(senha, "[A-Z]")) score++;
            if (Regex.IsMatch(senha, "[a-z]")) score++;
            if (Regex.IsMatch(senha, "[0-9]")) score++;
            if (Regex.IsMatch(senha, "[^a-zA-Z0-9]")) score++;

            return score switch
            {
                <= 2 => "Muito Fraca",
                3 => "Fraca",
                4 => "Moderada",
                5 => "Forte",
                >= 6 => "Muito Forte",
            };
        }

        public void AlterarCor()
        {
            string nivel = lblNivelSeguranca.Text;

            switch (nivel)
            {
                case "Muito Fraca":
                case "Fraca":
                    lblNivelSeguranca.ForeColor = Color.Red;
                    break;

                case "Moderada":
                    lblNivelSeguranca.ForeColor = Color.Orange;
                    break;

                case "Forte":
                    lblNivelSeguranca.ForeColor = Color.Green;
                    break;

                case "Muito Forte":
                    lblNivelSeguranca.ForeColor = Color.DarkGreen;
                    break;
            }
        }
        #endregion
    }
}
