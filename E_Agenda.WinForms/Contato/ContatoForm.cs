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
        Repositorio<Contato> _repositorioContato;

        public ContatoForm(Repositorio<Contato> repositorio)
        {
            InitializeComponent();
            this._repositorioContato = repositorio;
        }
        private void buttonAdicionarContato_Click(object sender, EventArgs e)
        {
            InserirContatoForm tela = new(_repositorioContato);
            tela.Contato=new Contato();
            

            if (tela.ShowDialog() == DialogResult.OK)
            {
                string status = _repositorioContato.Inserir(tela.Contato);

                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Contato inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CarregarContatos();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Contato ContatoSelecionado = (Contato)listBoxContatos.SelectedItem;

            bool temAlgo = VerificarContato(ContatoSelecionado, "Editar");
            if (!temAlgo)
                return;

            Contato novoContato = new();
            
            novoContato.nome = ContatoSelecionado.nome;
            novoContato.email = ContatoSelecionado.email;
            novoContato.telefone = ContatoSelecionado.telefone;
            novoContato.empresa = ContatoSelecionado.empresa;
            novoContato.cargo = ContatoSelecionado.cargo;

            InserirContatoForm tela = new(_repositorioContato);
            tela.Contato = novoContato;
            


            DialogResult res = tela.ShowDialog();

            if (res == DialogResult.OK)
            {
                string status = _repositorioContato.Editar(novoContato, ContatoSelecionado);

                if (status == "REGISTRO_VALIDO")
                {
                    MessageBox.Show("Contato editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarContatos();
                }
                else
                {
                    MessageBox.Show($"{status}\nTente novamente", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CarregarContatos();
                }
            }
        }

        private void buttonExcluirContato_Click(object sender, EventArgs e)
        {
            Contato ContatoSelecionado = (Contato)listBoxContatos.SelectedItem;
            
            bool temAlgo = VerificarContato(ContatoSelecionado, "Excluir");
            if (!temAlgo)
                return;
            
            DialogResult resultado = MessageBox.Show("Excluir contato?",
              "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioContato.Excluir(ContatoSelecionado);
                CarregarContatos();
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void buttonAgruparPorCargo_Click(object sender, EventArgs e)
        {
            List<Contato> contatosPorCargo = _repositorioContato.SelecionarTodos().OrderBy(x=>x.cargo).ToList();

            listBoxContatos.Items.Clear();

            foreach (Contato contato in contatosPorCargo)
            {
                listBoxContatos.Items.Add(contato);
            }
        }

        private void buttonAgruparPorNome_Click(object sender, EventArgs e)
        {
            List<Contato> contatosPorNome = _repositorioContato.SelecionarTodos().OrderBy(x => x.nome).ToList();

            listBoxContatos.Items.Clear();

            foreach (Contato contato in contatosPorNome)
            {
                listBoxContatos.Items.Add(contato);
            }
        }


        private void CarregarContatos()
        {
            List<Contato> contatos = _repositorioContato.SelecionarTodos();
            listBoxContatos.Items.Clear();
            foreach (Contato c in contatos)
            {
                listBoxContatos.Items.Add(c);
            }
        }
        public bool VerificarContato(Contato Contatoselecionado, string tipo)
        {
            bool temAlgo = _repositorioContato.ExisteRegistro();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum Contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Contatoselecionado == null)
            {
                MessageBox.Show($"Selecione um Contato para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void ContatoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
