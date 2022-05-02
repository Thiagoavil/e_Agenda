using Dominio;
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
    public partial class ContatoForm : Form
    {
        Repositorio<Contato> repositoContato;
        public ContatoForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void buttonAgruparPorCargo_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgruparPorID_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdicionarContato_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcluirContato_Click(object sender, EventArgs e)
        {

        }
    }
}
