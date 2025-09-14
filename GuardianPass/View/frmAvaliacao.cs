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
        public frmAvaliacao()
        {
            InitializeComponent();
        }

        public void Verificao()
        {
            if (int.TryParse(txtNota.Text, out int nota))
            {
                if (nota >= 0 && nota <= 5)
                {
                    MessageBox.Show("Obrigado pela sua avaliação!", "Avaliação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AbrirForms();
                }
                else
                    MessageBox.Show("Por favor, insira uma nota válida entre 0 e 5.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Por favor, insira uma nota válida entre 0 e 5.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void AbrirForms()
        {
            frmConfig config = new frmConfig();
            config.Show();
            this.Close();
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
    }
}
