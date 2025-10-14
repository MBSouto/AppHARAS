namespace HARAS_3D87
{
    partial class Frm_Login
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

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            Group_Dados.Left = (this.ClientSize.Width - Group_Dados.Width) / 2;
            Group_Dados.Top = (this.ClientSize.Height - Group_Dados.Height) / 2;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Group_Dados = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnOK = new Button();
            CmbNome = new ComboBox();
            btnCancelar = new Button();
            txtSenha = new TextBox();
            label = new Label();
            txtNome = new Label();
            Group_Dados.SuspendLayout();
            SuspendLayout();
            // 
            // Group_Dados
            // 
            Group_Dados.Controls.Add(label2);
            Group_Dados.Controls.Add(label1);
            Group_Dados.Controls.Add(btnOK);
            Group_Dados.Controls.Add(CmbNome);
            Group_Dados.Controls.Add(btnCancelar);
            Group_Dados.Controls.Add(txtSenha);
            Group_Dados.Controls.Add(label);
            Group_Dados.Controls.Add(txtNome);
            Group_Dados.Location = new Point(12, 12);
            Group_Dados.Name = "Group_Dados";
            Group_Dados.Size = new Size(376, 294);
            Group_Dados.TabIndex = 0;
            Group_Dados.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 69);
            label2.Name = "label2";
            label2.Size = new Size(307, 15);
            label2.TabIndex = 9;
            label2.Text = "____________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(132, 19);
            label1.Name = "label1";
            label1.Size = new Size(118, 50);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // btnOK
            // 
            btnOK.FlatAppearance.BorderColor = Color.White;
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.FlatAppearance.MouseDownBackColor = Color.White;
            btnOK.FlatAppearance.MouseOverBackColor = Color.Black;
            btnOK.Location = new Point(81, 237);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(104, 24);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOk_Click;
            // 
            // CmbNome
            // 
            CmbNome.FormattingEnabled = true;
            CmbNome.Location = new Point(81, 122);
            CmbNome.Name = "CmbNome";
            CmbNome.Size = new Size(228, 23);
            CmbNome.TabIndex = 1;
            CmbNome.SelectedIndexChanged += CmbNome_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.White;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCancelar.Location = new Point(205, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 24);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(81, 175);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(228, 23);
            txtSenha.TabIndex = 2;
            txtSenha.TextAlign = HorizontalAlignment.Right;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(82, 157);
            label.Name = "label";
            label.Size = new Size(42, 15);
            label.TabIndex = 0;
            label.Text = "Senha:";
            label.Click += Label2_Click;
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(81, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(43, 15);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome:";
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 318);
            Controls.Add(Group_Dados);
            KeyPreview = true;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppHARAS v1.0";
            Load += FrmLogin_Load;
            KeyDown += FrmLogin_KeyDown;
            Group_Dados.ResumeLayout(false);
            Group_Dados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Group_Dados;
        private TextBox txtSenha;
        private Label label;
        private Label txtNome;
        private ComboBox CmbNome;
        private Button btnCancelar;
        private Button btnOK;
        private Label label1;
        private Label label2;
    }
}