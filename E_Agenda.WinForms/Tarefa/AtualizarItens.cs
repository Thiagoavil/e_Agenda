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
    public partial class AtualizarItens : Form
    {
        private readonly Tarefa tarefa;

        public AtualizarItens(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;

            CarregarItensTarefa(tarefa);
        }
        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.ListaDeItens)
            {
                listBoxItensTarefa.Items.Add(item);

                if (item.itemConcluido)
                    listBoxItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }
        public List<Item> ItensConcluidos
        {
            get
            {
                return listBoxItensTarefa.CheckedItems
                    .Cast<Item>()
                    .ToList();
            }
        }

        public List<Item> ItensPendentes
        {
            get
            {
                return listBoxItensTarefa.Items
                    .Cast<Item>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listItensTarefa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }
    }
}
