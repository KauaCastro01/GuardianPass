using GuardianPass.Controller;
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
    public partial class frmExibir : Form
    {
        ConexaoApps apps = new ConexaoApps();
        DadosUsuario user = new DadosUsuario();

        #region Eventos
        public frmExibir()
        {
            InitializeComponent();
            PopularDGV();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VerificarLinhaSelecionada();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void frmExibir_Load(object sender, EventArgs e)
        {
            EstilizarDGV(dgv1);
        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            apps.PesquisarApps(txtBoxUsuario.Text, dgv1);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            VerificarLinhaSelecionadaExclusao();
        }

        #endregion

        #region Metodos
        private void EstilizarDGV(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;

            dgv.GridColor = Color.LightGray;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowHeadersVisible = false;

            dgv.RowTemplate.Height = 35;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        private void ExibirErroMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private DadosApp PopularClasse()
        {
            var row = (dgv1.SelectedRows[0].DataBoundItem as DataRowView).Row;

            DadosApp dadosApp = new DadosApp
            {
                Usuario = row["Usuario"].ToString(),
                Senha = row["Senha"].ToString(),
                SiteApp = row["Site"].ToString()
            };

            return dadosApp;
        }

        private void AbrirFormsExigirSenha(DadosApp dadosApp)
        {
            frmExigirSenha frmExigirSenha = new frmExigirSenha(dadosApp);
            frmExigirSenha.Show();
            this.Close();
        }

        public void AbrirFomrsAdicionar(DadosApp dadosApp)
        {
            frmAdicionar frmAdicionar = new frmAdicionar(dadosApp);
            frmAdicionar.Show();
            this.Close();
        }

        private void VerificarLinhaSelecionada()
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DadosApp dados = PopularClasse();
                user = user.Carregar();
                if (user.Exigir)
                    AbrirFormsExigirSenha(dados);
                else
                    AbrirFomrsAdicionar(dados);
            }
            else
            { ExibirErroMensagem("Selecione uma linha para editar."); return; }
        }

        private void VerificarLinhaSelecionadaExclusao()
        {
            if (dgv1.SelectedRows.Count == 0)
                { ExibirErroMensagem("Selecione uma linha para excluir."); return; }
            ConfirmarExclusao();
        }
        private void ConfirmarExclusao()
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                ExcluirRegistro();
        }

        private void ExcluirRegistro()
        {
            apps.ExcluirApps(
                    dgv1.SelectedRows[0].Cells["Usuario"].Value.ToString(),
                    dgv1.SelectedRows[0].Cells["Senha"].Value.ToString(),
                    dgv1.SelectedRows[0].Cells["Site"].Value.ToString()
                );
            MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopularDGV();
        }

        private void PopularDGV()
        {
            apps.CarregarSitesNoDGV(dgv1);
            EstilizarDGV(dgv1);
        }

        #endregion
    }
}
