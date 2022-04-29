using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.WinForms
{
    public partial class TelaInicialForm : Form
    {
        public TelaInicialForm()
        {
            InitializeComponent();
        }

        private void btnAcessarContatos_Click(object sender, EventArgs e)
        {
            this.Hide();

            ContatoForm tela = new ContatoForm();
            
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void TelaInicialForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
