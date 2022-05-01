using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compromisso : EntidadeBase
    {
        public Contato contato;
        public DateTime dataCompromisso;
        DateTime horarioDeInicio;
        DateTime horarioDeFim;
        string assunto;
        string local;

        public Compromisso(Contato contatoselecionado, DateTime dataCompromisso, DateTime horarioDeInicio, DateTime horarioDeFim,
            string assunto, string local)
        {
            this.dataCompromisso = dataCompromisso;
            this.horarioDeInicio = horarioDeInicio;
            this.horarioDeFim = horarioDeFim;
            this.assunto = assunto;
            this.local = local;

            contato = contatoselecionado;
        }

        public override string ToString()
        {
            return
                "Contato: " + contato.Nome + Environment.NewLine +
                "Data do compromisso: " + dataCompromisso + Environment.NewLine +
                "Hora de Inicio: " + horarioDeInicio + Environment.NewLine +
                "Hora de Fim: " + horarioDeFim + Environment.NewLine +
                "Assunto: " + assunto + Environment.NewLine +
                "Local: " + local + Environment.NewLine;
        }
        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(assunto))
                sb.AppendLine("Está sem assunto");
            if (string.IsNullOrEmpty(local))
                sb.AppendLine("Está sem local");
            if (dataCompromisso > DateTime.Now)
                sb.AppendLine("Data de compromisso deve ser maior ou igual a hoje");
            if (horarioDeFim > DateTime.Now)
                sb.AppendLine("Hora de fim deve ser uma horar válida");
            if (horarioDeInicio > DateTime.Now)
                sb.AppendLine("Hora de inicio deve ser uma hora válida");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

    }
}
