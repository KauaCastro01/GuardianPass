using GuardianPass.Data;
using GuardianPass.Model;
using GuardianPass.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GuardianPass
{
    public partial class frmExibir : Form
    {
        private readonly AppDbContext _db;
        private readonly AplicativoService _aplicativoService;
        private readonly UsuarioService _usuarioService;

        #region Eventos
        public frmExibir(AppDbContext Db)
        {
            InitializeComponent();
            _db = Db;
            _aplicativoService = new AplicativoService(_db);
            _usuarioService = new UsuarioService(_db);
            dgv1.CellDoubleClick += dgv1_CellDoubleClick;
            PopularDGV();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VerificarLinhaSelecionada();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void frmExibir_Load(object sender, EventArgs e)
        {
            EstilizarDGV(dgv1);
        }

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            dgv1.DataSource = _aplicativoService.Pesquisar(txtBoxUsuario.Text, Properties.Settings.Default.ID);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            VerificarLinhaSelecionadaExclusao();
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dgv1.Rows[e.RowIndex].Selected = true;
            VerificarLinhaSelecionada();
        }

        #endregion

        #region Metodos
        private void EstilizarDGV(DataGridView dgv)
        {
            // ===== CONFIG GERAL =====
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = ColorTranslator.FromHtml("#0D1B2A"); // fundo geral
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ===== FONTE =====
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // ===== HEADER =====
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B4D8"); // ciano GuardianPass
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersHeight = 42;

            // ===== LINHAS =====
            dgv.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1B263B");
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#162236");

            dgv.RowsDefaultCellStyle.ForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            // ===== SELEÇÃO =====
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#2E4057");
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // ===== GRID / BORDAS =====
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = ColorTranslator.FromHtml("#2E4057");

            // ===== TAMANHO =====
            dgv.RowTemplate.Height = 36;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ===== REMOVE VISUAL FEIO =====
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;

            // ===== CURSOR =====
            dgv.Cursor = Cursors.Hand;
        }


        private void ExibirErroMensagem(string mensagem)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Error;

            Notificacao.ShowBalloonTip(2000);
        }

        private void ExibirErroSucesso(string mensagem)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Info;

            Notificacao.ShowBalloonTip(2000);
        }

        private AplicativosModel PopularClasse()
        {
            return dgv1.SelectedRows[0].DataBoundItem as AplicativosModel;
        }

        private void AbrirFormsExigirSenha(AplicativosModel dadosApp)
        {
            frmExigirSenha frmExigirSenha = new frmExigirSenha(dadosApp, _db);
            frmExigirSenha.Show();
            this.Close();
        }

        public void AbrirFomrsAdicionar(AplicativosModel dadosApp)
        {
            frmAdicionar frmAdicionar = new frmAdicionar(dadosApp, _db);
            frmAdicionar.Show();
            this.Close();
        }

        private void VerificarLinhaSelecionada()
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                AplicativosModel aplicativosEscolhido = PopularClasse();
                UsuariosModel usuarioAutal = _usuarioService.VerificarExigirSenha(Properties.Settings.Default.ID);

                if (usuarioAutal.ExigirSenha)
                    AbrirFormsExigirSenha(aplicativosEscolhido);
                else
                    AbrirFomrsAdicionar(aplicativosEscolhido);
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
            var dados = PopularClasse();
            _aplicativoService.ExcluirAplicativo(dados);

            ExibirErroSucesso("Registro excluído com sucesso!");
            PopularDGV();
        }

        private void PopularDGV()
        {
            var lista = _aplicativoService.ObterTodosAplicativos();
            dgv1.DataSource = lista;

            dgv1.Columns["Id"].Visible = false;
            dgv1.Columns["UsuarioID"].Visible = false;
            dgv1.Columns["Senha"].Visible = false;
            dgv1.Columns["Aplicativo"].HeaderText = "Aplicativo";
            dgv1.Columns["Usuario"].Visible = false;
        }

        #endregion
    }
}