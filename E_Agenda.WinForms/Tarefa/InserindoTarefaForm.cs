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
    public partial class InserindoTarefaForm : Form
    {
        public Tarefa tarefa;

        public InserindoTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            
                
            if (tarefa != null)
            {
                textBoxTitulo.Text = tarefa.Titulo;

                if (tarefa.Prioridade == "Alta")
                {
                    radioButtonAlta.Checked = true;
                }
                else if (tarefa.Prioridade == "Media")
                {
                    radioButtonMedia.Checked = true;
                }
                else
                {
                    radioButtonBaixa.Checked = true;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            tarefa.Titulo = textBoxTitulo.Text;
            tarefa.DataDeCriacao = DateTime.Now;
            

            if (radioButtonAlta.Checked == true)
            {
                tarefa.Prioridade = "Alta";
            }
            else if (radioButtonAlta.Checked == true)
            {
                tarefa.Prioridade = "Media";
                
            }
            else
            {
                tarefa.Prioridade = "Baixa";
            }
        }
    }
}
