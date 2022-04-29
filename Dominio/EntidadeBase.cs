using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal abstract class EntidadeBase
    {
        public int numero;


        public abstract ResultadoDaValidacao Validar();
        public abstract string ToString();

    }
}
