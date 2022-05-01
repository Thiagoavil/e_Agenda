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
    public partial class TarefaForm : Form
    {
        Repositorio<Tarefa> _repositorioTarefa;

        public TarefaForm(Repositorio<Tarefa> repositorio)
        {
            InitializeComponent();
            _repositorioTarefa = repositorio;
            CarregarTarefas();
        }

        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {

            InserindoTarefaForm tela = new(new Tarefa());

            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = _repositorioTarefa.Inserir(tela.tarefa);

                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Tarefa inserida com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CarregarTarefas();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas =
                _repositorioTarefa.Filtrar(
                    x => x.CalcularPercentualConcluido() == 100).ToList();

            listBoxTarefaConcluida.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listBoxTarefaConcluida.Items.Add(t);
            }

            List<Tarefa> tarefasPendentes = _repositorioTarefa.Filtrar(x => x.CalcularPercentualConcluido() < 100).ToList();

            listBoxTarefaIncompletas.Items.Clear();

            foreach (Tarefa t in tarefasPendentes)
            {
                listBoxTarefaIncompletas.Items.Add(t);
            }
        }

        private void listBoxTarefaIncompletas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTarefaConcluida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

