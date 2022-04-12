using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.Compartilhado;

namespace e_Agenda.Contatos
{
    internal class TelaContato : TelaBase
    {

        public TelaContato() : base("Cadastro de Contato")
        {

        }

        public void Inserir()
        {
            MostrarTitulo("Inserindo Contato");

        }

        public void Editar()
        {
            MostrarTitulo("Editando Contato");

        }

        public void Excluir()
        {
            MostrarTitulo("Excluido Contato");

        }

        public void Visualizar()
        {
            MostrarTitulo("Visualizando Contato");

        }
    }
}
