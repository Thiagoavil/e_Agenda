using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.Compartilhado;

namespace e_Agenda.Compromisso
{
    internal class Compromisso : EntidadeBase 
    {
        Contato contatoDoCompromisso = new Contato;
        DateTime dataCompromisso, horarioDeInicio, horarioDeFim;
        string assunto, local;


        public override int Validar()
        {
            return 0;
        }

    }
}
