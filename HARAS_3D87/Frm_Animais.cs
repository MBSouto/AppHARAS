using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HARAS_3D87
{
    public partial class Frm_Animais : Form
    {
        public Frm_Animais()
        {
            InitializeComponent();
        }

        #region Configurar elementos do Formulário

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarControlesIniciais(false);
            operacao = 2;
            MostrarLista_noForm();
            Group_Dados.Enabled = true;
            txtNrchip.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControlesIniciais(true);
            LimparFormulario();
            MontarLista("");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            HabilitarControlesIniciais(false);
            Group_Dados.Enabled = true;
            operacao = 1;
            txtNrchip.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNrchip.Text.Trim()))
            {
                MessageBox.Show("O campo Chip é obrigatório!", "Atenção:");
                txtNrchip.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("O campo Nome é obrigatório!", "Atenção:");
                txtNome.Focus();
                return;
            }
            GravarRegistro(operacao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNrchip.Text))
            {
                MessageBox.Show("Selecione um registro para exclusão!");
                txtPesquisar.Focus();
                return;
            }

            if (MessageBox.Show("Confirma a exclusão do registro?", "Exclusão",
                                    MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) ==
                                            DialogResult.Yes)
            {
                string Mensagem;

                try
                {
                    // Chama o método para excluir o registro
                    Mensagem = MeuAdapterAnimais.ExcluirAnimais(ChaveID);

                    // Exibe mensagem de erro, se houver
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção:");

                    HabilitarControlesIniciais(true);
                    LimparFormulario();
                    MontarLista("");
                }
                catch (Exception ex)
                {
                    // Armazenar erro encontrado
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor_Keypress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números, vírgula e backspace
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
            {
                e.Handled = true;
            }
        }
        private void txtChip_Keypress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números, vírgula e backspace
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
            {
                e.Handled = true;
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void dgvTabelaAnimais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvTabelaAnimaiS_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MostrarLista_noForm();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            MontarLista(txtPesquisar.Text);
        }

        #endregion

        #region Executa metodo para montar lista no DataGridView
        private void MostrarLista_noForm()
        {
            // Seleciona o registro atual do DataGridView e exibe os detalhes no formulário
            if (dgvTabelaAnimais.CurrentRow != null)
            {
                // Guarda o valor da celula 0 (Raca_ID) na variável ChaveID
                ChaveID = Convert.ToInt32(dgvTabelaAnimais.SelectedRows[0].Cells[0].Value);

                string Mensagem;

                // Localiza o registro no banco de dados
                Mensagem = MeuAdapterAnimais.LocalizarAnimais_porCodigo(ChaveID);

                //  Exibe mensagem de erro, se houver
                if (Mensagem != "") MessageBox.Show(Mensagem, "Erro encontrado: ");


                // Preenche os campos do formulário com os dados do registro

                txtNrchip.Text = MeuAdapterAnimais.inrchip.ToString();
                txtNome.Text = MeuAdapterAnimais.snome;
                checkBox.Checked = Convert.ToBoolean(MeuAdapterAnimais.bvendido.ToString());
                txtValor.Text = MeuAdapterAnimais.dvalor.ToString();
                cmbRaca.SelectedValue = MeuAdapterAnimais.iraca_id.ToString();
                txtNascimento.Text = MeuAdapterAnimais.sdtnascimento;

            }
            // Habilita os botões de edição e exclusão
            else LimparFormulario();
        }
        #endregion

        #region Metodo para gravar registros
        private void GravarRegistro(int op)
        {
            string Mensagem = "";

            if (op == 1) // Operação 1 - Inclusão
            {
                try
                {
                    Mensagem = MeuAdapterAnimais.InserirAnimais
                                    (int.Parse(txtNrchip.Text),
                                        txtNome.Text,
                                           Convert.ToDateTime(txtNascimento.Text),
                                              decimal.Parse(txtValor.Text),
                                                 checkBox.Checked,
                                                     Convert.ToInt32(cmbRaca.SelectedValue));



                    // Exibe mensagem de erro, se houver
                    if (Mensagem != "") MessageBox.Show(Mensagem, "Atenção:");

                    HabilitarControlesIniciais(true);
                    LimparFormulario();
                    MontarLista("");
                }
                catch (Exception ex)
                {
                    // Armazenar erro encontrado
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else // Operação 2 - Alteração
            {
                try
                {
                    Mensagem = MeuAdapterAnimais.AlterarAnimais
                                    (int.Parse(txtNrchip.Text),
                                         txtNome.Text,
                                            txtNascimento.Value,
                                               decimal.Parse(txtValor.Text),
                                                  checkBox.Checked,
                                                     Convert.ToInt32(cmbRaca.ValueMember),
                                                         ChaveID); // ID do animal a ser alterado


                    HabilitarControlesIniciais(true);
                    LimparFormulario();
                    MontarLista("");
                }
                catch (Exception ex)
                {
                    // Armazenar erro encontrado
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        #endregion

    }
}
