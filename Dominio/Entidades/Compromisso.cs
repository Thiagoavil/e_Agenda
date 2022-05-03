using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compromisso : EntidadeBase
    {
        public Contato contato { get; set; }
        public DateTime dataCompromisso { get; set; }
        public TimeSpan horarioDeInicio { get; set; }
        public TimeSpan horarioDeFim { get; set; }
        public string assunto { get; set; }
        public string local { get; set; }

        public Compromisso()
        {
            
        }

        public override string ToString()
        {
            return
                "Contato: " + contato.nome +
                "Data do compromisso: " + dataCompromisso +
                "Hora de Inicio: " + horarioDeInicio +
                "Hora de Fim: " + horarioDeFim +
                "Assunto: " + assunto +
                "Local: " + local;
        }
        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(assunto))
                sb.AppendLine("Está sem assunto");
            if (string.IsNullOrEmpty(local))
                sb.AppendLine("Está sem local");
            if (dataCompromisso == DateTime.MinValue)
                sb.AppendLine("Coloque uma data");
            if (horarioDeFim > horarioDeInicio)
                sb.AppendLine("hora de fim inválida");

            

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

    }
}
