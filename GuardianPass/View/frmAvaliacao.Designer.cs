namespace GuardianPass
{
    partial class frmAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvaliacao));
            txtNota = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtDescricao = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.FromArgb(27, 38, 59);
            txtNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.ForeColor = Color.White;
            txtNota.Location = new Point(91, 120);
            txtNota.MaxLength = 1;
            txtNota.Name = "txtNota";
            txtNota.PlaceholderText = "Nota";
            txtNota.Size = new Size(218, 34);
            txtNota.TabIndex = 4;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(91, 86);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 3;
            label2.Text = "Nota: (0 - 5)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 5;
            label1.Text = "Avalie sua experiência";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(13, 47);
            label3.Name = "label3";
            label3.Size = new Size(374, 23);
            label3.TabIndex = 6;
            label3.Text = "Sua opinião ajuda a melhorar nossos softwares!";
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.FromArgb(27, 38, 59);
            txtDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.ForeColor = Color.White;
            txtDescricao.Location = new Point(91, 198);
            txtDescricao.MaxLength = 500;
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Escreva aqui...";
            txtDescricao.Size = new Size(218, 144);
            txtDescricao.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(91, 164);
            label4.Name = "label4";
            label4.Size = new Size(122, 31);
            label4.TabIndex = 7;
            label4.Text = "Descrição:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(128, 397);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(144, 43);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(0, 180, 216);
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(128, 348);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(144, 43);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // frmAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(400, 463);
            Controls.Add(btnVoltar);
            Controls.Add(btnEnviar);
            Controls.Add(txtDescricao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNota);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAvaliacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtDescricao;
        private Label label4;
        private Button btnVoltar;
        private Button btnEnviar;
    }
}