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
    public partial class InserirContatoForm : Form
    {
        public Contato contato;
        public Repositorio<Contato> repositorio;
         
        public InserirContatoForm(Repositorio<Contato> repositorio)
        {
            InitializeComponent();
            this.repositorio = repositorio;
        }
        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                
            }
        }

        private void InserirContatoForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            List<string> Nomes = repositorio.SelecionarTodos().Select(x => x.nome).ToList();
            List<string> Email = repositorio.SelecionarTodos().Select(x=>x.email).ToList();
            List<string> telefone = repositorio.SelecionarTodos().Select(x => x.telefone).ToList();

            if (Nomes.Count == 0 || Nomes.Contains(textBoxNome.Text) == false || Email.Contains(textBoxEmail.Text) ==false || telefone.Contains(maskedTextBoxTelefone.Text)==false)
            {
                contato.nome = textBoxNome.Text;
                contato.email=textBoxEmail.Text;
                contato.telefone = maskedTextBoxTelefone.Text;
                contato.empresa = textBoxEmpresa.Text;
                contato.cargo = textBoxCargo.Text;
                
            }
        }
    }
}
