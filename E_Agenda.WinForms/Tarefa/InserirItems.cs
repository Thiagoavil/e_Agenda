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
    public partial class InserirItems : Form
    {
        private readonly Tarefa tarefa;
        public InserirItems(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            labelTarefa.Text = tarefa.Titulo;

            foreach(Item item in tarefa.ListaDeItens)
            {
                listBoxItems.Items.Add(item);
            }

        }
        public List<Item> ItensAdicionados
        {
            get
            {
                return listBoxItems.Items.Cast<Item>().ToList();
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();

            if (titulos.Count == 0 || titulos.Contains(textBoxTitulo.Text) == false)
            {
                Item itemTarefa = new Item();

                itemTarefa.Titulo = textBoxTitulo.Text;

                listBoxItems.Items.Add(itemTarefa);
            }
            else
            {
                MessageBox.Show("Não pode Inserir Itens com o mesmo Nome","Itens",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InserirItems_Load(object sender, EventArgs e)
        {

        }
    }
}
