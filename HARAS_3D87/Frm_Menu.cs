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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        // Evento de clique do menu "RAÇA"
        private void RACAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Raca frm = new Frm_Raca();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ANIMAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Animais frm = new Frm_Animais();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
