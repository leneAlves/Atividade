using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTarefa
{
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            tela_secundaria ts = new tela_secundaria();

            ts.Show();

            this.Hide();
            
            ts.Visible = true;
        }
    }
}
