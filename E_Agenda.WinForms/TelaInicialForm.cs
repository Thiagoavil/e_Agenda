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
using Infra;

namespace E_Agenda.WinForms
{
    public partial class TelaInicialForm : Form
    {
        private readonly JsonSerialization<Tarefa> _jsonTarefaSerialization;
        private readonly JsonSerialization<Contato> _jsonContatoSerialization;
        private readonly JsonSerialization<Compromisso> _jsonCompromissoSerialization;
        private Repositorio<Tarefa> repositorioTarefa;
        private Repositorio<Contato> repositorioContato;
        private Repositorio<Compromisso> repositorioCompromisso;
        

        public TelaInicialForm()
        {
            _jsonTarefaSerialization = new(@"C:\Temp\Tarefas");
            _jsonContatoSerialization = new(@"C:\Temp\Contato");
            _jsonCompromissoSerialization = new(@"C:\Temp\Compromisso");
            repositorioTarefa = new Repositorio<Tarefa>(_jsonTarefaSerialization);
            repositorioContato = new Repositorio<Contato>(_jsonContatoSerialization);
            repositorioCompromisso =new Repositorio<Compromisso>(_jsonCompromissoSerialization);
            InitializeComponent();
        }

        private void btnAcessarContatos_Click(object sender, EventArgs e)
        {
            this.Hide();

            ContatoForm tela = new (repositorioContato, repositorioCompromisso);
            
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

            TarefaForm tela = new(repositorioTarefa, _jsonTarefaSerialization);

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void buttonAcessarCompromisso_Click(object sender, EventArgs e)
        {
            this.Hide();

            CompromissoForm tela = new (repositorioCompromisso,repositorioContato);

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
