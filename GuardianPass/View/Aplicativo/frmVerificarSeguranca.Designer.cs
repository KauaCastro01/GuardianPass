namespace GuardianPass.View.Aplicativo
{
    partial class frmVerificarSeguranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerificarSeguranca));
            label1 = new Label();
            txtBoxSenha = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            label2 = new Label();
            lblNivelSeguranca = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 10);
            label1.Name = "label1";
            label1.Size = new Size(292, 38);
            label1.TabIndex = 37;
            label1.Text = "Análise de segurança";
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.ForeColor = Color.White;
            txtBoxSenha.Location = new Point(100, 180);
            txtBoxSenha.MaxLength = 50;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Senha";
            txtBoxSenha.Size = new Size(200, 34);
            txtBoxSenha.TabIndex = 36;
            txtBoxSenha.TextChanged += txtBoxSenha_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(100, 150);
            label4.Name = "label4";
            label4.Size = new Size(161, 31);
            label4.TabIndex = 35;
            label4.Text = "Digite a senha";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(115, 230);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(170, 55);
            btnVoltar.TabIndex = 34;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(89, 70);
            label2.Name = "label2";
            label2.Size = new Size(221, 31);
            label2.TabIndex = 38;
            label2.Text = "Nível de Segurança:";
            // 
            // lblNivelSeguranca
            // 
            lblNivelSeguranca.AutoSize = true;
            lblNivelSeguranca.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNivelSeguranca.ForeColor = Color.White;
            lblNivelSeguranca.Location = new Point(113, 100);
            lblNivelSeguranca.Name = "lblNivelSeguranca";
            lblNivelSeguranca.Size = new Size(174, 38);
            lblNivelSeguranca.TabIndex = 39;
            lblNivelSeguranca.Text = "Muito Fraca";
            lblNivelSeguranca.Visible = false;
            // 
            // frmVerificarSeguranca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(400, 323);
            Controls.Add(lblNivelSeguranca);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmVerificarSeguranca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtBoxSenha;
        private Label label4;
        private Button btnVoltar;
        private Label label2;
        private Label lblNivelSeguranca;
    }
}