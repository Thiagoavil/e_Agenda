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

            InserindoTarefaForm tela = new(_repositorioTarefa);
            tela.Tarefa=new Tarefa();

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
            Tarefa tarefaSelecionada = (Tarefa)listBoxTarefaIncompletas.SelectedItem;
            
            bool temAlgo = VerificarTarefa(tarefaSelecionada, "Editar");
            if (!temAlgo)
                return;

            Tarefa novaTarefa = new();

            foreach (var item in tarefaSelecionada.ListaDeItens)
            {
                novaTarefa.ListaDeItens.Add(item);
            }
            novaTarefa.id = tarefaSelecionada.id;
            novaTarefa.Titulo = tarefaSelecionada.Titulo;
            novaTarefa.Prioridade = tarefaSelecionada.Prioridade;
            novaTarefa.DataDeCriacao = tarefaSelecionada.DataDeCriacao;
            novaTarefa.DataDeConclusao = tarefaSelecionada.DataDeConclusao;
            novaTarefa.Percentual = tarefaSelecionada.Percentual;
            
            InserindoTarefaForm tela = new(_repositorioTarefa);
            tela.Tarefa = novaTarefa;
           

            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = _repositorioTarefa.Editar(tela.Tarefa,tarefaSelecionada);
                
                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Tarefa editada com sucesso!", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    CarregarTarefas();
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarTarefas();
                }
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionadaIncompleta = (Tarefa)listBoxTarefaIncompletas.SelectedItem;

            Tarefa tarefaSelecionadaConcluida = (Tarefa)listBoxTarefaConcluida.SelectedItem;

            if (tarefaSelecionadaIncompleta == null && tarefaSelecionadaConcluida==null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Tarefa paraExcluir=new Tarefa();

            if (tarefaSelecionadaIncompleta == null)
                paraExcluir = tarefaSelecionadaConcluida;
            else
                paraExcluir = tarefaSelecionadaIncompleta;


           DialogResult resultado = MessageBox.Show("Excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioTarefa.Excluir(paraExcluir);
                _repositorioTarefa.AtualizarId();
                CarregarTarefas();
            }

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefasConcluidas =
                _repositorioTarefa.Filtrar(
                    x => x.CalcularPercentualConcluido() == 100).
                    OrderByDescending(x => x.prioridade).ThenBy(x => x.Titulo).ToList();

            listBoxTarefaConcluida.Items.Clear();

            foreach (Tarefa t in tarefasConcluidas)
            {
                listBoxTarefaConcluida.Items.Add(t);
            }


            List<Tarefa> tarefasPendentes = _repositorioTarefa.Filtrar(x => x.CalcularPercentualConcluido() < 100).
                OrderByDescending(x=>x.prioridade).ThenBy(x => x.Titulo).ToList();

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

        public bool VerificarTarefa(Tarefa TarefaSelecionada, string tipo)
        {
            bool temAlgo = _repositorioTarefa.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhuma Tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (TarefaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma Tarefa para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void buttonAdicionarItems_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionadaIncompleta = (Tarefa)listBoxTarefaIncompletas.SelectedItem;

            Tarefa tarefaSelecionadaConcluida = (Tarefa)listBoxTarefaConcluida.SelectedItem;

            if (tarefaSelecionadaIncompleta == null && tarefaSelecionadaConcluida == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Adicionando Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Tarefa TarefaSelecionada=new Tarefa();

            if (tarefaSelecionadaIncompleta == null)
                TarefaSelecionada = tarefaSelecionadaConcluida;
            else
                TarefaSelecionada = tarefaSelecionadaIncompleta;

            InserirItems tela = new(TarefaSelecionada);
        }

        private void buttonMarcarItems_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionadaIncompleta = (Tarefa)listBoxTarefaIncompletas.SelectedItem;

            Tarefa tarefaSelecionadaConcluida = (Tarefa)listBoxTarefaConcluida.SelectedItem;

            if (tarefaSelecionadaIncompleta == null && tarefaSelecionadaConcluida == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Adicionando Items", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Tarefa TarefaSelecionada = new Tarefa();

            if (tarefaSelecionadaIncompleta == null)
                TarefaSelecionada = tarefaSelecionadaConcluida;
            else
                TarefaSelecionada = tarefaSelecionadaIncompleta;

            AtualizarItens tela = new(TarefaSelecionada);

            if(tela.ShowDialog()==DialogResult.OK)
            {
                List<Item> itensConcluidos = tela.ItensConcluidos;

                List<Item> itensPendentes = tela.ItensPendentes;

                TarefaSelecionada.AtualizarItens( itensConcluidos, itensPendentes);
                CarregarTarefas();
            }
        }
    }

}

