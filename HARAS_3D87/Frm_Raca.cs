using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
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
                if (Mensagem != "") MessageBox.Show(Mensagem, "Erro encontrado: "); // Exceção aguardando correção "parâmetro @RACAID não encontrado na procedute STPLocalizarRacaChaveID"

                // Preenche os campos do formulário com os dados do registro
                txtRegistro.Text = MeuAdapterRaca.iRegistro_Raca.ToString();
                txtDescricao.Text = MeuAdapterRaca.sDescricao_Raca;
                txtCadastro.Text = MeuAdapterRaca.sdata;
            }
            // Habilita os botões de edição e exclusão
            else LimparFormulario();
        }
       

    }
}
