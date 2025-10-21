using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace HARAS_3D87
{
    partial class Frm_Animais : Form
    {
        int operacao;
        int ChaveID;

        // Instancia os objetos da camada de dados 
        Camada_Animais87 MeuAdapterAnimais = new Camada_Animais87();
        Camada_Raca87 MeuAdapterRaca = new Camada_Raca87();


        // Metodo para limpar o formulario
        private void LimparFormulario()
        {
            txtNrchip.Clear();
            txtNome.Clear();
            txtValor.Clear();
            operacao = 0;
            ChaveID = 0;
        }

        private void HabilitarControlesIniciais(bool status)
        {
            Group_Lista.Enabled = status;
            Group_Dados.Enabled = status;
            habilitarBotoes(status);
        }

        private void habilitarBotoes(bool status)
        {
            btnNovo.Enabled = status;
            btnEditar.Enabled = status;
            btnExcluir.Enabled = status;
            btnSalvar.Enabled = !status;
            btnCancelar.Enabled = !status;
        }

        private void MontarLista(string varNome)
        {
            string Mensagem;

            Mensagem = MeuAdapterAnimais.MontarListaAnimais(varNome);

            // Verifica se ocorreu algum erro e exibe a mensagem
            if (Mensagem != "") MessageBox.Show(Mensagem, "Erro encontrado: ");

            // Exibe os dados no grid
            dgvTabelaAnimais.DataSource = MeuAdapterAnimais.DtAnimais;

            btnEditar.Enabled = dgvTabelaAnimais.Rows.Count > 0;
            btnExcluir.Enabled = btnEditar.Enabled;

            MostrarLista_noForm();
        }
        private void Frm_animais_Load(object sender, EventArgs e)
        {   
            string Mensagem;
            Mensagem = MeuAdapterRaca.MontarListaRaca("");

            if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção: ");

            // Preenche o ComboBox de Raça
            cmbRaca.Items.Clear();
            cmbRaca.DataSource = MeuAdapterRaca.DtRaca;
            cmbRaca.DisplayMember = "DESCRICAO";
            cmbRaca.ValueMember = "RACA_ID";
            cmbRaca.Refresh();

            // Habilita os controles iniciais
            HabilitarControlesIniciais(true);
            LimparFormulario();
            MontarLista("");
            txtPesquisar.Focus();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Animais));
            Group_Lista = new GroupBox();
            dgvTabelaAnimais = new DataGridView();
            Group_Dados = new GroupBox();
            cmbRaca = new ComboBox();
            checkBox = new CheckBox();
            label7 = new Label();
            txtPesquisar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtValor = new TextBox();
            txtNascimento = new DateTimePicker();
            txtNrchip = new TextBox();
            Label2 = new Label();
            Label3 = new Label();
            Label1 = new Label();
            Group_Barra = new GroupBox();
            btnCancelar = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            Group_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTabelaAnimais).BeginInit();
            Group_Dados.SuspendLayout();
            Group_Barra.SuspendLayout();
            SuspendLayout();
            // 
            // Group_Lista
            // 
            Group_Lista.BackColor = Color.White;
            Group_Lista.Controls.Add(dgvTabelaAnimais);
            Group_Lista.Location = new Point(12, 264);
            Group_Lista.Name = "Group_Lista";
            Group_Lista.Size = new Size(558, 294);
            Group_Lista.TabIndex = 1;
            Group_Lista.TabStop = false;
            // 
            // dgvTabelaAnimais
            // 
            dgvTabelaAnimais.AllowUserToAddRows = false;
            dgvTabelaAnimais.AllowUserToDeleteRows = false;
            dgvTabelaAnimais.AllowUserToResizeColumns = false;
            dgvTabelaAnimais.AllowUserToResizeRows = false;
            dgvTabelaAnimais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTabelaAnimais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabelaAnimais.Location = new Point(6, 11);
            dgvTabelaAnimais.Name = "dgvTabelaAnimais";
            dgvTabelaAnimais.ReadOnly = true;
            dgvTabelaAnimais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabelaAnimais.Size = new Size(546, 277);
            dgvTabelaAnimais.TabIndex = 0;
            dgvTabelaAnimais.CellContentClick += dgvTabelaAnimais_CellContentClick;
            dgvTabelaAnimais.RowEnter += dgvTabelaAnimaiS_RowEnter;
            // 
            // Group_Dados
            // 
            Group_Dados.BackColor = Color.White;
            Group_Dados.Controls.Add(cmbRaca);
            Group_Dados.Controls.Add(checkBox);
            Group_Dados.Controls.Add(label7);
            Group_Dados.Controls.Add(txtPesquisar);
            Group_Dados.Controls.Add(label5);
            Group_Dados.Controls.Add(label4);
            Group_Dados.Controls.Add(txtNome);
            Group_Dados.Controls.Add(txtValor);
            Group_Dados.Controls.Add(txtNascimento);
            Group_Dados.Controls.Add(txtNrchip);
            Group_Dados.Controls.Add(Label2);
            Group_Dados.Controls.Add(Label3);
            Group_Dados.Controls.Add(Label1);
            Group_Dados.Location = new Point(12, 12);
            Group_Dados.Name = "Group_Dados";
            Group_Dados.Size = new Size(558, 246);
            Group_Dados.TabIndex = 2;
            Group_Dados.TabStop = false;
            // 
            // cmbRaca
            // 
            cmbRaca.FormattingEnabled = true;
            cmbRaca.Location = new Point(24, 136);
            cmbRaca.Name = "cmbRaca";
            cmbRaca.Size = new Size(289, 23);
            cmbRaca.TabIndex = 11;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(244, 39);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(69, 19);
            checkBox.TabIndex = 10;
            checkBox.Text = "Vendido";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 190);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 9;
            label7.Text = "Pesquisar:";
            label7.Click += label7_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(24, 208);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(509, 23);
            txtPesquisar.TabIndex = 8;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 19);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 118);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Raça:";
            label4.Click += label4_Click;
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(24, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(509, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtDescricao_TextChanged;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(411, 37);
            txtValor.MaxLength = 6;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(122, 23);
            txtValor.TabIndex = 1;
            txtValor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNascimento
            // 
            txtNascimento.Format = DateTimePickerFormat.Short;
            txtNascimento.Location = new Point(371, 136);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(162, 23);
            txtNascimento.TabIndex = 2;
            // 
            // txtNrchip
            // 
            txtNrchip.Location = new Point(24, 37);
            txtNrchip.Name = "txtNrchip";
            txtNrchip.Size = new Size(127, 23);
            txtNrchip.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(24, 74);
            Label2.Name = "Label2";
            Label2.Size = new Size(43, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Nome:";
            Label2.Click += Label2_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(371, 118);
            Label3.Name = "Label3";
            Label3.Size = new Size(74, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Nascimento:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(24, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(52, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Nº Chip:";
            Label1.Click += Label1_Click;
            // 
            // Group_Barra
            // 
            Group_Barra.BackColor = Color.White;
            Group_Barra.Controls.Add(btnCancelar);
            Group_Barra.Controls.Add(btnNovo);
            Group_Barra.Controls.Add(btnSalvar);
            Group_Barra.Controls.Add(btnEditar);
            Group_Barra.Controls.Add(btnExcluir);
            Group_Barra.Location = new Point(576, 12);
            Group_Barra.Name = "Group_Barra";
            Group_Barra.Size = new Size(92, 546);
            Group_Barra.TabIndex = 3;
            Group_Barra.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.White;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(22, 478);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(48, 48);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.FlatAppearance.BorderColor = Color.White;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatAppearance.MouseDownBackColor = Color.White;
            btnNovo.FlatAppearance.MouseOverBackColor = Color.Black;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new Point(22, 22);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(50, 50);
            btnNovo.TabIndex = 0;
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.FlatAppearance.BorderColor = Color.White;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.White;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(22, 367);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(48, 48);
            btnSalvar.TabIndex = 4;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderColor = Color.White;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(22, 149);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(48, 48);
            btnEditar.TabIndex = 2;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.FlatAppearance.BorderColor = Color.White;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.White;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Black;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(22, 252);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(48, 48);
            btnExcluir.TabIndex = 3;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Frm_Animais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(677, 566);
            Controls.Add(Group_Barra);
            Controls.Add(Group_Dados);
            Controls.Add(Group_Lista);
            Name = "Frm_Animais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animais";
            Load += Frm_animais_Load;
            Group_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTabelaAnimais).EndInit();
            Group_Dados.ResumeLayout(false);
            Group_Dados.PerformLayout();
            Group_Barra.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Group_Lista;
        private DataGridView dgvTabelaAnimais;
        private GroupBox Group_Dados;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtValor;
        private DateTimePicker txtNascimento;
        private TextBox txtNrchip;
        private Label Label2;
        private Label Label3;
        private Label Label1;
        private GroupBox Group_Barra;
        private Button btnCancelar;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label5;
        private Label label7;
        private TextBox txtPesquisar;
        private CheckBox checkBox;
        private ComboBox cmbRaca;
    }
}