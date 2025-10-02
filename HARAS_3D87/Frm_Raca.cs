using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HARAS_3D87
{
    public partial class Frm_Raca : Form
    {
        public Frm_Raca()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmRACA_Load);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarControlesIniciais(false);
            operacao = 2;
            txtRegistro.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControlesIniciais(true);
            LimparFormulario();
            MontarLista("");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarControlesIniciais(false);
            operacao = 1;
            LimparFormulario();
            txtRegistro.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegistro.Text.Trim()))
            {
                MessageBox.Show("O campo Registro é obrigatório!", "Atenção:");
                txtRegistro.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDescricao.Text.Trim()))
            {
                MessageBox.Show("O campo Descrição é obrigatório!", "Atenção:");
                txtDescricao.Focus();
                return;
            }
            GravarRegistro(operacao);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MostrarRegistro_noForm();
        }

        private void txtRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private void txtRegistro_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            MontarLista(txtFiltrar.Text);
        }

        private void MostrarRegistro_noForm()
        {
            // Seleciona o registro atual do DataGridView e exibe os detalhes no formulário
            if (dataGridView.CurrentRow != null)
            {
                // Guarda o valor da celula 0 (Raca_ID) na variável ChaveID
                ChaveID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                string Mensagem;

                // Localiza o registro no banco de dados
                Mensagem = MeuAdapterRaca.LocalizarRaca_porCodigo(ChaveID);

                //  Exibe mensagem de erro, se houver
                if (Mensagem != "") MessageBox.Show(Mensagem, "Erro encontrado: ");
                /* Exceção aguardando correção "parâmetro @RACAID não encontrado na procedure STPLocalizarRacaChaveID",
                Erro tratado, o parâmetro da procedure estava com o nome diferente, o correto é @RACA_ID */

                // Preenche os campos do formulário com os dados do registro
                txtRegistro.Text = MeuAdapterRaca.iRegistro_Raca.ToString();
                txtDescricao.Text = MeuAdapterRaca.sDescricao_Raca;
                txtCadastro.Text = MeuAdapterRaca.sdata;
            }
            // Habilita os botões de edição e exclusão
            else LimparFormulario();
        }


        private void GravarRegistro(int op)
        {
            string Mensagem = "";

            if (op == 1) // Operação 1 - Inclusão
            {
                try
                { 
                    Mensagem = MeuAdapterRaca.InserirRaca(
                                Convert.ToInt32(txtRegistro.Text),
                                    txtDescricao.Text,
                                        txtCadastro.Value,  
                                            DateTime.Now.ToString("t"));

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
                    /* Mensagem = MeuAdapterRaca.AlterarRaca(Convert.ToInt32(txtRegistro.Text),
                                    txtDescricao.Text,
                                        txtCadastro.Value,
                                            DateTime.Now.ToString("t"),
                                                ChaveID); */

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
    }
}
