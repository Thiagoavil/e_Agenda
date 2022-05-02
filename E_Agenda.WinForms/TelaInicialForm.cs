using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using E_Agenda.WinForms.ModuloCompromisso;

namespace E_Agenda.WinForms
{
    public partial class TelaInicialForm : Form
    {
        private Repositorio<Tarefa> repositorioTarefa;
        private Repositorio<Contato> repositorioContato;
        private Repositorio<Compromisso> repositorioCompromisso;

        public TelaInicialForm()
        {
            InitializeComponent();
            repositorioTarefa = new Repositorio<Tarefa>();
            repositorioContato = new Repositorio<Contato>();
            repositorioCompromisso =new Repositorio<Compromisso>();
        }

        private void btnAcessarContatos_Click(object sender, EventArgs e)
        {
            this.Hide();

            ContatoForm tela = new (repositorioContato);
            
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void TelaInicialForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAcessarTarefas_Click(object sender, EventArgs e)
        {
            this.Hide();

            TarefaForm tela = new(repositorioTarefa);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void buttonAcessarCompromisso_Click(object sender, EventArgs e)
        {
            this.Hide();

            CompromissoForm tela = new (repositorioCompromisso);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                this.Show();
            }
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
