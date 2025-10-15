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
                /* Exceção aguardando correção "parâmetro @RACAID não encontrado na procedure STPLocalizarRacaChaveID",
                Erro tratado, o parâmetro da procedure estava com o nome diferente, o correto é @RACA_ID */

                // Preenche os campos do formulário com os dados do registro

                txtNrchip.Text = MeuAdapterAnimais.inrchip.ToString();
                txtNome.Text = MeuAdapterAnimais.snome;
                checkBox.Text = MeuAdapterAnimais.bvendido.ToString();
                txtValor.Text = MeuAdapterAnimais.dvalor.ToString();

    }
            // Habilita os botões de edição e exclusão
            else LimparFormulario();
        }
        #endregion
    }
}
