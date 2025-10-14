namespace HARAS_3D87
{
    partial class Frm_Raca : Form
    {
        int operacao;
        int ChaveID;

        // Instancia da camada de dados
        Camada_Raca87 MeuAdapterRaca = new Camada_Raca87();

        // Metodo para limpar o formulario
        private void LimparFormulario()
        {
            txtRegistro.Clear();
            txtDescricao.Clear();
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

        private void MontarLista(string varDescricao)
        {
            string Mensagem;

            Mensagem = MeuAdapterRaca.MontarListaRaca(varDescricao);

            // Verifica se ocorreu algum erro e exibe a mensagem
            if (Mensagem != "") MessageBox.Show(Mensagem, "Erro encontrado: ");

            // Exibe os dados no grid
            dataGridView.DataSource = MeuAdapterRaca.DtRaca;

            btnEditar.Enabled = dataGridView.Rows.Count > 0;
            btnExcluir.Enabled = btnEditar.Enabled;

            MostrarRegistro_noForm();
        }

        private void FrmRACA_Load(object sender, EventArgs e)
        {
            HabilitarControlesIniciais(true);
            LimparFormulario();
            MontarLista("");
            txtFiltrar.Focus();
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Raca));
            Group_Lista = new GroupBox();
            dataGridView = new DataGridView();
            Group_Dados = new GroupBox();
            label4 = new Label();
            txtDescricao = new TextBox();
            txtRegistro = new TextBox();
            txtCadastro = new DateTimePicker();
            txtFiltrar = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            Group_Dados.SuspendLayout();
            Group_Barra.SuspendLayout();
            SuspendLayout();
            // 
            // Group_Lista
            // 
            Group_Lista.BackColor = Color.White;
            Group_Lista.Controls.Add(dataGridView);
            Group_Lista.Location = new Point(7, 12);
            Group_Lista.Name = "Group_Lista";
            Group_Lista.Size = new Size(558, 348);
            Group_Lista.TabIndex = 0;
            Group_Lista.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 13);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(546, 329);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.RowEnter += dataGridView_RowEnter;
            // 
            // Group_Dados
            // 
            Group_Dados.BackColor = Color.White;
            Group_Dados.Controls.Add(label4);
            Group_Dados.Controls.Add(txtDescricao);
            Group_Dados.Controls.Add(txtRegistro);
            Group_Dados.Controls.Add(txtCadastro);
            Group_Dados.Controls.Add(txtFiltrar);
            Group_Dados.Controls.Add(Label2);
            Group_Dados.Controls.Add(Label3);
            Group_Dados.Controls.Add(Label1);
            Group_Dados.Location = new Point(7, 366);
            Group_Dados.Name = "Group_Dados";
            Group_Dados.Size = new Size(558, 182);
            Group_Dados.TabIndex = 1;
            Group_Dados.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 131);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Descrição:";
            label4.Click += label4_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.Location = new Point(24, 149);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(423, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(24, 105);
            txtRegistro.MaxLength = 6;
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(127, 23);
            txtRegistro.TabIndex = 1;
            txtRegistro.TextAlign = HorizontalAlignment.Right;
            txtRegistro.TextChanged += txtRegistro_TextChanged;
            txtRegistro.KeyPress += txtRegistro_KeyPress;
            // 
            // txtCadastro
            // 
            txtCadastro.Format = DateTimePickerFormat.Short;
            txtCadastro.Location = new Point(285, 105);
            txtCadastro.Name = "txtCadastro";
            txtCadastro.Size = new Size(162, 23);
            txtCadastro.TabIndex = 2;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(24, 37);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(423, 23);
            txtFiltrar.TabIndex = 0;
            txtFiltrar.TextChanged += txtFiltrar_TextChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(24, 87);
            Label2.Name = "Label2";
            Label2.Size = new Size(53, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Registro:";
            Label2.Click += Label2_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(285, 87);
            Label3.Name = "Label3";
            Label3.Size = new Size(153, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Data Cadastro/ Atualização:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(24, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(94, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Filtrar Descrição:";
            Label1.Click += label1_Click;
            // 
            // Group_Barra
            // 
            Group_Barra.BackColor = Color.White;
            Group_Barra.Controls.Add(btnCancelar);
            Group_Barra.Controls.Add(btnNovo);
            Group_Barra.Controls.Add(btnSalvar);
            Group_Barra.Controls.Add(btnEditar);
            Group_Barra.Controls.Add(btnExcluir);
            Group_Barra.Location = new Point(571, 12);
            Group_Barra.Name = "Group_Barra";
            Group_Barra.Size = new Size(92, 536);
            Group_Barra.TabIndex = 2;
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
            btnNovo.Size = new Size(48, 48);
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
            btnSalvar.Location = new Point(22, 280);
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
            btnEditar.Location = new Point(22, 111);
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
            btnExcluir.Location = new Point(22, 195);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(48, 48);
            btnExcluir.TabIndex = 3;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Frm_Raca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(672, 568);
            Controls.Add(Group_Barra);
            Controls.Add(Group_Dados);
            Controls.Add(Group_Lista);
            Name = "Frm_Raca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raças";
            Load += FrmRACA_Load;
            Group_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            Group_Dados.ResumeLayout(false);
            Group_Dados.PerformLayout();
            Group_Barra.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Group_Lista;
        private GroupBox Group_Dados;
        private GroupBox Group_Barra;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Label Label1;
        private DateTimePicker txtCadastro;
        private TextBox txtFiltrar;
        private Label Label2;
        private Label Label3;
        private TextBox txtRegistro;
        private Label label4;
        private TextBox txtDescricao;
        private DataGridView dataGridView;
    }
}