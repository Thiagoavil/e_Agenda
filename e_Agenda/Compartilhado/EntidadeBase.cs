using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    internal abstract class EntidadeBase
    {
        public int numero;


        public abstract ResultadoDaValidacao Validar();
        public abstract string ToString();
    }
}
