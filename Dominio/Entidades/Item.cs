using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Item : EntidadeBase
    {
        public string Titulo { get; set; }
        public bool itemConcluido { get; set; }

        public override string ToString()
        {
            return Titulo;

        }

        public void Concluir()
        {
            itemConcluido = true;
        }

        internal void MarcarPendente()
        {
            itemConcluido = false;
        }
        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();


            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("É necessário ter um titulo!");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }
    }
}
