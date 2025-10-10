using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HARAS_3D87
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmLogin_Load);
        }
        #region Monta a lista de usuários no comboBox
        Camada_Usuarios87 MeuAdapterUsuario = new Camada_Usuarios87();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string Mensagem;

            Mensagem = MeuAdapterUsuario.MontarListaUsuarios("%");

            //Se ocorrer erro exibi-lo
            if (Mensagem != "") MessageBox.Show(Mensagem, "Erro encontrado:");

            CmbNome.Items.Clear(); //Limpar o comboBox
            CmbNome.DataSource = MeuAdapterUsuario.DtUsuarios; //Definir a fonte de dados do comboBox
            CmbNome.DisplayMember = "NOME"; //Definir o campo a ser exibido
            CmbNome.ValueMember = "NOME"; //Definir o campo valor
            CmbNome.Refresh();
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            int iacesso = 0;
            if (string.IsNullOrEmpty(CmbNome.Text.Trim()))
            {
                MessageBox.Show("Nome do usuário não pode ficar em branco.", "Atenção");
                CmbNome.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                MessageBox.Show("Senha do usuário não pode ficar em branco.", "Atenção");
                txtSenha.Focus();
                return;
            }

            string Mensagem;
            try
            {
                //Chamar o método para localizar o usuário, passando o nome e a senha
                iacesso = 0;
                Mensagem = MeuAdapterUsuario.LocalizarUsuario(CmbNome.Text, txtSenha.Text);

                //Se ocorrer erro exibi-lo
                if (Mensagem != "")
                    MessageBox.Show(Mensagem, "Erro encontrado:");
                    iacesso = MeuAdapterUsuario.iAcesso_usuario; //Receber o nível de acesso do usuário

                // Se o nível de acesso for diferente de zero, liberar o acesso
                if (iacesso != 0)
                {
                    MessageBox.Show("Seja Bem Vindo " + CmbNome.Text + " Acesso Liberado"); 
                    Frm_Menu FM = new Frm_Menu(); 

                    //Definir o nível de acesso do usuário no formulário principal
                    Hide(); 
                    FM.ShowDialog();
                    Application.Exit();
                }
                // Se o nível de acesso for igual a zero, negar o acesso
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }   

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
