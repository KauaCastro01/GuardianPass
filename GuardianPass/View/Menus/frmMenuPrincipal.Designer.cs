namespace GuardianPass
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdicionar = new Button();
            btnExibir = new Button();
            btnGerarSenha = new Button();
            btnVerificarSeguranca = new Button();
            btnConfig = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnAdicionar);
            flowLayoutPanel1.Controls.Add(btnExibir);
            flowLayoutPanel1.Controls.Add(btnGerarSenha);
            flowLayoutPanel1.Controls.Add(btnVerificarSeguranca);
            flowLayoutPanel1.Controls.Add(btnConfig);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(282, 403);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(0, 180, 216);
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(3, 3);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(270, 60);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "Nova credencial";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExibir
            // 
            btnExibir.BackColor = Color.FromArgb(0, 180, 216);
            btnExibir.FlatAppearance.BorderSize = 0;
            btnExibir.FlatStyle = FlatStyle.Flat;
            btnExibir.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnExibir.Image = (Image)resources.GetObject("btnExibir.Image");
            btnExibir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExibir.Location = new Point(3, 69);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(270, 60);
            btnExibir.TabIndex = 19;
            btnExibir.Text = "Gerenciar";
            btnExibir.UseVisualStyleBackColor = false;
            btnExibir.Click += btnExibir_Click;
            // 
            // btnGerarSenha
            // 
            btnGerarSenha.BackColor = Color.FromArgb(0, 180, 216);
            btnGerarSenha.FlatAppearance.BorderSize = 0;
            btnGerarSenha.FlatStyle = FlatStyle.Flat;
            btnGerarSenha.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnGerarSenha.Image = (Image)resources.GetObject("btnGerarSenha.Image");
            btnGerarSenha.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerarSenha.Location = new Point(3, 135);
            btnGerarSenha.Name = "btnGerarSenha";
            btnGerarSenha.Size = new Size(270, 60);
            btnGerarSenha.TabIndex = 18;
            btnGerarSenha.Text = "Gerador";
            btnGerarSenha.UseVisualStyleBackColor = false;
            btnGerarSenha.Click += btnGerarSenha_Click;
            // 
            // btnVerificarSeguranca
            // 
            btnVerificarSeguranca.BackColor = Color.FromArgb(0, 180, 216);
            btnVerificarSeguranca.FlatAppearance.BorderSize = 0;
            btnVerificarSeguranca.FlatStyle = FlatStyle.Flat;
            btnVerificarSeguranca.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnVerificarSeguranca.Image = (Image)resources.GetObject("btnVerificarSeguranca.Image");
            btnVerificarSeguranca.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerificarSeguranca.Location = new Point(3, 201);
            btnVerificarSeguranca.Name = "btnVerificarSeguranca";
            btnVerificarSeguranca.Size = new Size(270, 60);
            btnVerificarSeguranca.TabIndex = 22;
            btnVerificarSeguranca.Text = "Segurança";
            btnVerificarSeguranca.UseVisualStyleBackColor = false;
            btnVerificarSeguranca.Click += btnVerificarSeguranca_Click;
            // 
            // btnConfig
            // 
            btnConfig.BackColor = Color.FromArgb(102, 102, 102);
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(3, 267);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(270, 60);
            btnConfig.TabIndex = 20;
            btnConfig.Text = "Configurações";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(181, 23, 30);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(3, 333);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(270, 60);
            btnSair.TabIndex = 21;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 403);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(282, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 403);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo_Sem_Fundo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(750, 403);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            Load += frmMenuPrincipal_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdicionar;
        private Button btnGerarSenha;
        private Button btnExibir;
        private Button btnConfig;
        private Button btnSair;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button btnVerificarSeguranca;
    }
}