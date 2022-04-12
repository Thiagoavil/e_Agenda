using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace e_Agenda.Contatos
{
    internal class Contato : EntidadeBase
    {
        string nome, email, telefone, empresa, cargo;


        public override int Validar()
        {
            return 0;
        }
        
    }
}
