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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
