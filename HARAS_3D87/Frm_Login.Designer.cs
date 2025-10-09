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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Group_Dados = new GroupBox();
            txtSenha = new TextBox();
            label = new Label();
            txtNome = new Label();
            Group_Barra = new GroupBox();
            btnOK = new Button();
            btnCancelar = new Button();
            CmbNome = new ComboBox();
            Group_Dados.SuspendLayout();
            Group_Barra.SuspendLayout();
            SuspendLayout();
            // 
            // Group_Dados
            // 
            Group_Dados.Controls.Add(CmbNome);
            Group_Dados.Controls.Add(txtSenha);
            Group_Dados.Controls.Add(label);
            Group_Dados.Controls.Add(txtNome);
            Group_Dados.Location = new Point(12, 156);
            Group_Dados.Name = "Group_Dados";
            Group_Dados.Size = new Size(776, 138);
            Group_Dados.TabIndex = 2;
            Group_Dados.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(331, 77);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(210, 23);
            txtSenha.TabIndex = 5;
            txtSenha.TextAlign = HorizontalAlignment.Right;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(264, 80);
            label.Name = "label";
            label.Size = new Size(42, 15);
            label.TabIndex = 2;
            label.Text = "Senha:";
            label.Click += Label2_Click;
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(264, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(43, 15);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome:";
            // 
            // Group_Barra
            // 
            Group_Barra.Controls.Add(btnOK);
            Group_Barra.Controls.Add(btnCancelar);
            Group_Barra.Location = new Point(12, 300);
            Group_Barra.Name = "Group_Barra";
            Group_Barra.Size = new Size(776, 82);
            Group_Barra.TabIndex = 3;
            Group_Barra.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.FlatAppearance.BorderColor = Color.White;
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.FlatAppearance.MouseDownBackColor = Color.White;
            btnOK.FlatAppearance.MouseOverBackColor = Color.Black;
            btnOK.Location = new Point(331, 13);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(81, 56);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK!";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.White;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCancelar.Location = new Point(461, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 56);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CmbNome
            // 
            CmbNome.FormattingEnabled = true;
            CmbNome.Location = new Point(331, 38);
            CmbNome.Name = "CmbNome";
            CmbNome.Size = new Size(210, 23);
            CmbNome.TabIndex = 6;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Group_Barra);
            Controls.Add(Group_Dados);
            Name = "Frm_Login";
            Text = "Frm_Login";
            Group_Dados.ResumeLayout(false);
            Group_Dados.PerformLayout();
            Group_Barra.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Group_Dados;
        private TextBox txtSenha;
        private Label label;
        private Label txtNome;
        private GroupBox Group_Barra;
        private Button btnSalvar;
        private Button btnOK;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnExcluir;
        private ComboBox CmbNome;
    }
}