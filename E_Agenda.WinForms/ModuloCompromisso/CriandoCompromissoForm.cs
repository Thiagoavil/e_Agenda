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
    public partial class CriandoCompromissoForm : Form
    {
        Repositorio<Compromisso> _repositorioCompromisso;
        Repositorio<Contato> _repositorioContato;
        public Compromisso _compromisso;
        

        public CriandoCompromissoForm(Repositorio<Compromisso> repositorio,Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            this._repositorioCompromisso = repositorio;
            this._repositorioContato = repositorioContato;
            List<Contato> listaDeContatos = _repositorioContato.SelecionarTodos();

            listBoxContatos.Items.Clear();
            foreach (Contato c in listaDeContatos)
            {
                listBoxContatos.Items.Add(c);
            }
        }

        public Compromisso Compromisso
        {
            get
            {
                return _compromisso;
            }
            set
            {
               

                _compromisso = value;
                maskedTextBoxDataCompromisso.Text=Convert.ToString(_compromisso.dataCompromisso);
                maskedTextBoxHoraFinal.Text = Convert.ToString(_compromisso.horarioDeFim);
                maskedTextBoxHoraInicial.Text = Convert.ToString(_compromisso.horarioDeInicio);
                textBoxLocal.Text = _compromisso.local;
                textBoxAssunto.Text = _compromisso.assunto;


            }
        }

        private void buttonConcluir_Click(object sender, EventArgs e)
        {


            Contato contato = (Contato)listBoxContatos.SelectedItem;

            if(contato == null)
            {
                MessageBox.Show("Selecione um contato", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if(listBoxContatos ==null)
            {
                listBoxContatos.SelectedItem = _compromisso.contato;
            }

            _compromisso.contato = (Contato)listBoxContatos.SelectedItem;

            _compromisso.dataCompromisso = DateTime.Parse(maskedTextBoxDataCompromisso.Text);
            
            if(maskedTextBoxHoraInicial.Text != "  :")
            {
                _compromisso.horarioDeInicio = TimeSpan.Parse(maskedTextBoxHoraInicial.Text);
            }

            if(maskedTextBoxHoraFinal.Text != "  :")
            {
                _compromisso.horarioDeFim = TimeSpan.Parse(maskedTextBoxHoraFinal.Text);
            }

            List<Compromisso> Dia = _repositorioCompromisso.Filtrar(x => x.dataCompromisso ==DateTime.Parse(maskedTextBoxDataCompromisso.Text)).ToList();
            
            foreach(Compromisso d in Dia)
            {
                if(d.horarioDeInicio < _compromisso.horarioDeInicio && d.horarioDeInicio<_compromisso.horarioDeFim)
                {
                    MessageBox.Show("Hora inválida", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _compromisso.local = textBoxLocal.Text;
            _compromisso.assunto = textBoxAssunto.Text;


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CriandoCompromissoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
