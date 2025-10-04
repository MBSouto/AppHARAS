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
            bntNovo.Enabled = status;
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
            btnSalvar = new Button();
            bntNovo = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            Group_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            Group_Dados.SuspendLayout();
            Group_Barra.SuspendLayout();
            SuspendLayout();
            // 
            // Group_Lista
            // 
            Group_Lista.Controls.Add(dataGridView);
            Group_Lista.Location = new Point(12, 12);
            Group_Lista.Name = "Group_Lista";
            Group_Lista.Size = new Size(776, 232);
            Group_Lista.TabIndex = 0;
            Group_Lista.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 13);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(764, 213);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.RowEnter += dataGridView_RowEnter;
            // 
            // Group_Dados
            // 
            Group_Dados.Controls.Add(label4);
            Group_Dados.Controls.Add(txtDescricao);
            Group_Dados.Controls.Add(txtRegistro);
            Group_Dados.Controls.Add(txtCadastro);
            Group_Dados.Controls.Add(txtFiltrar);
            Group_Dados.Controls.Add(Label2);
            Group_Dados.Controls.Add(Label3);
            Group_Dados.Controls.Add(Label1);
            Group_Dados.Location = new Point(12, 238);
            Group_Dados.Name = "Group_Dados";
            Group_Dados.Size = new Size(776, 138);
            Group_Dados.TabIndex = 1;
            Group_Dados.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 100);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Descrição:";
            label4.Click += label4_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.Location = new Point(73, 97);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(687, 23);
            txtDescricao.TabIndex = 6;
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(73, 68);
            txtRegistro.MaxLength = 6;
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(127, 23);
            txtRegistro.TabIndex = 5;
            txtRegistro.TextAlign = HorizontalAlignment.Right;
            txtRegistro.TextChanged += txtRegistro_TextChanged;
            txtRegistro.KeyPress += txtRegistro_KeyPress;
            // 
            // txtCadastro
            // 
            txtCadastro.Format = DateTimePickerFormat.Short;
            txtCadastro.Location = new Point(560, 68);
            txtCadastro.Name = "txtCadastro";
            txtCadastro.Size = new Size(200, 23);
            txtCadastro.TabIndex = 4;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(106, 19);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(654, 23);
            txtFiltrar.TabIndex = 3;
            txtFiltrar.TextChanged += txtFiltrar_TextChanged;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(6, 71);
            Label2.Name = "Label2";
            Label2.Size = new Size(53, 15);
            Label2.TabIndex = 2;
            Label2.Text = "Registro:";
            Label2.Click += Label2_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(401, 71);
            Label3.Name = "Label3";
            Label3.Size = new Size(153, 15);
            Label3.TabIndex = 1;
            Label3.Text = "Data Cadastro/ Atualização:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(6, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(94, 15);
            Label1.TabIndex = 0;
            Label1.Text = "Filtrar Descrição:";
            Label1.Click += label1_Click;
            // 
            // Group_Barra
            // 
            Group_Barra.Controls.Add(btnSalvar);
            Group_Barra.Controls.Add(bntNovo);
            Group_Barra.Controls.Add(btnEditar);
            Group_Barra.Controls.Add(btnCancelar);
            Group_Barra.Controls.Add(btnExcluir);
            Group_Barra.Location = new Point(12, 369);
            Group_Barra.Name = "Group_Barra";
            Group_Barra.Size = new Size(776, 82);
            Group_Barra.TabIndex = 2;
            Group_Barra.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatAppearance.BorderColor = Color.White;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.White;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(592, 13);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(81, 56);
            btnSalvar.TabIndex = 5;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // bntNovo
            // 
            bntNovo.FlatAppearance.BorderColor = Color.White;
            bntNovo.FlatAppearance.BorderSize = 2;
            bntNovo.FlatAppearance.MouseDownBackColor = Color.White;
            bntNovo.FlatAppearance.MouseOverBackColor = Color.Black;
            bntNovo.Image = (Image)resources.GetObject("bntNovo.Image");
            bntNovo.Location = new Point(331, 13);
            bntNovo.Name = "bntNovo";
            bntNovo.Size = new Size(81, 56);
            bntNovo.TabIndex = 7;
            bntNovo.UseVisualStyleBackColor = true;
            bntNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.White;
            btnEditar.FlatAppearance.BorderSize = 2;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(418, 13);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(81, 56);
            btnEditar.TabIndex = 6;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.White;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.Location = new Point(679, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 56);
            btnCancelar.TabIndex = 4;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.FlatAppearance.BorderColor = Color.White;
            btnExcluir.FlatAppearance.BorderSize = 2;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.White;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Black;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(505, 13);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(81, 56);
            btnExcluir.TabIndex = 3;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Frm_Raca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Group_Barra);
            Controls.Add(Group_Dados);
            Controls.Add(Group_Lista);
            Name = "Frm_Raca";
            Text = "Frm_Raca";
            Load += label4_Click;
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
        private Button bntNovo;
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