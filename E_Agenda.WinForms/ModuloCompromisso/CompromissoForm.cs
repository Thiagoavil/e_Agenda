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

namespace E_Agenda.WinForms.ModuloCompromisso
{
    public partial class CompromissoForm : Form
    {
        Repositorio<Compromisso> _repositorioCompromisso;
        Repositorio<Contato> repositorioContato;
        public CompromissoForm(Repositorio<Compromisso> repositorio,Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            this._repositorioCompromisso = repositorio;
            this.repositorioContato = repositorioContato;

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromissoselecionado = (Compromisso)listBoxCompromissoFuturos.SelectedItem;

            Compromisso novoCompromisso = new();

            
            novoCompromisso.id = compromissoselecionado.id;
            novoCompromisso.contato = compromissoselecionado.contato;
            novoCompromisso.dataCompromisso = compromissoselecionado.dataCompromisso;
            novoCompromisso.horarioDeInicio = compromissoselecionado.horarioDeInicio;
            novoCompromisso.horarioDeFim = compromissoselecionado.horarioDeFim;
            novoCompromisso.local = compromissoselecionado.local;

            CriandoCompromissoForm tela = new(_repositorioCompromisso,repositorioContato);
            tela.Compromisso = novoCompromisso;


            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = _repositorioCompromisso.Editar(tela._compromisso, compromissoselecionado);

                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Compromisso editado com sucesso!", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarCompromisso();
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarCompromisso();
                }
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdicionarCompromisso_Click(object sender, EventArgs e)
        {
            bool existeContato = repositorioContato.ExisteRegistro();
            if(existeContato==false)
            {
                MessageBox.Show($"Nenhum Contato criado", "compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CriandoCompromissoForm tela = new (_repositorioCompromisso,repositorioContato);
            tela._compromisso = new Compromisso();

            DialogResult res = tela.ShowDialog();
            
            if (res == DialogResult.OK)
            {
                string status = _repositorioCompromisso.Inserir(tela._compromisso);

                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Compromisso inserido com sucesso!", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CarregarCompromisso();
            }
        }

        private void buttonExcluirCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso CompromissosPassados = (Compromisso)listBoxCompromissospassados.SelectedItem;

            Compromisso CompromissosFuturos = (Compromisso)listBoxCompromissoFuturos.SelectedItem;

            if (CompromissosPassados == null && CompromissosFuturos == null)
            {
                MessageBox.Show("Selecione um Compromisso primeiro",
                "Exclusão de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Compromisso paraExcluir = new Compromisso();

            if (CompromissosPassados == null)
                paraExcluir = CompromissosFuturos;
            else
                paraExcluir = CompromissosPassados;


            DialogResult resultado = MessageBox.Show("Excluir o Compromisso?",
                 "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioCompromisso.Excluir(paraExcluir);
                _repositorioCompromisso.AtualizarId();
                CarregarCompromisso();
            }

        }

        private void buttonVisualizarTodas_Click(object sender, EventArgs e)
        {
            CarregarCompromisso();
        }

        private void CarregarCompromisso()
        {

            List<Compromisso> CompromissosFuturos =
                _repositorioCompromisso.Filtrar(
                    x => x.dataCompromisso > DateTime.Now).ToList();

            listBoxCompromissoFuturos.Items.Clear();

            foreach (Compromisso c in CompromissosFuturos)
            {
                listBoxCompromissoFuturos.Items.Add(c);
            }


            List<Compromisso> CompromissosPassados = _repositorioCompromisso.Filtrar(x => x.dataCompromisso < DateTime.Now).ToList();

            listBoxCompromissospassados.Items.Clear();

            foreach (Compromisso c in CompromissosPassados)
            {
                listBoxCompromissospassados.Items.Add(c);
            }
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            DateTime Inicio = DateTime.Parse(maskedTextBoxDataInicial.Text);
            DateTime Final =DateTime.Parse(maskedTextBoxDataFinal.Text);
            
            List<Compromisso> CompromissosFuturos =
               _repositorioCompromisso.Filtrar(
                   x => x.dataCompromisso > DateTime.Now).ToList();


            listBoxCompromissoFuturos.Items.Clear();

            foreach(Compromisso c in CompromissosFuturos)
            {
                if(Inicio<=c.dataCompromisso)
                {
                    if (Final >= c.dataCompromisso)
                        listBoxCompromissoFuturos.Items.Add(c);
                }
            }


            List<Compromisso> CompromissosPassados = _repositorioCompromisso.Filtrar(x => x.dataCompromisso < DateTime.Now).ToList();

            listBoxCompromissospassados.Items.Clear();

            foreach (Compromisso c in CompromissosPassados)
            {
                if (Inicio <= c.dataCompromisso)
                {
                    if (Final >= c.dataCompromisso)
                        listBoxCompromissoFuturos.Items.Add(c);
                }
            }
        }
    }
}
