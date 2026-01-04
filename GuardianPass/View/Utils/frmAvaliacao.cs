using GuardianPass.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmAvaliacao : Form
    {
        private readonly AppDbContext _db;
        #region Eventos
        public frmAvaliacao(AppDbContext Db)
        {
            InitializeComponent();
            _db = Db;
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

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Verificao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AbrirForms();
        }

        private void Verificao()
        {
            if (int.TryParse(txtNota.Text, out int nota))
            {
                if (nota >= 0 && nota <= 5)
                {
                    ExibirMesagemSucesso("Avaliação enviada com sucesso!");
                    AbrirForms();
                }
                else
                    ExibirMesagemErro("Por favor, insira uma nota válida entre 0 e 5.");
            }
            else
                ExibirMesagemErro("Por favor, insira uma nota válida entre 0 e 5.");
        }

        public void AbrirForms()
        {
            frmConfig config = new frmConfig(_db);
            config.Show();
            this.Close();
        }

        #endregion
    }
}
