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
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();

            // Deixar o Label com fundo transparente
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100) // Quando o ProgressBar chegar a 100%
            {
                timer1.Enabled = false; // Parar o timer
                Frm_Login FL = new Frm_Login();
                this.Hide(); // Esconder o formulário de splash
                FL.ShowDialog(); // Mostrar o formulário de login como uma janela modal
                FL.Show(); // Mostrar o formulário de login
            }
            else
            {
                progressBar1.Value += 10; // Aumentar o valor do ProgressBar
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
