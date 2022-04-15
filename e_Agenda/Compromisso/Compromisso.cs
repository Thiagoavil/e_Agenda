using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.Compartilhado;
using e_Agenda.Contatos;

namespace e_Agenda.Compromisso
{
    internal class Compromisso : EntidadeBase 
    {
        public Contato contato;
        public DateTime dataCompromisso;
        DateTime horarioDeInicio, horarioDeFim;
        string assunto, local;

        public Compromisso(Contato contatoselecionado, DateTime dataCompromisso, DateTime horarioDeInicio,DateTime horarioDeFim, 
            string assunto, string local)
        {
            this.dataCompromisso = dataCompromisso;
            this.horarioDeInicio = horarioDeInicio;
            this.horarioDeFim = horarioDeFim;
            this.assunto = assunto;
            this.local = local;

            contato = contatoselecionado;
        }

        public override ResultadoDaValidacao Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(assunto))
                erros.Add("Está sem assunto");
            if (string.IsNullOrEmpty(local))
                erros.Add("Está sem local");
            if (dataCompromisso > DateTime.Now)
                erros.Add("Data de compromisso deve ser maior ou igual a hoje");
            if (horarioDeFim > DateTime.Now)
                erros.Add("Hora de fim deve ser uma horar válida");
            if (horarioDeInicio > DateTime.Now)
                erros.Add("Hora de inicio deve ser uma hora válida");

            return new ResultadoDaValidacao(erros);
        }

        public override string ToString()
        {
            return 
                "Contato: " + contato.Nome + Environment.NewLine +
                "Data do compromisso: " + dataCompromisso+ Environment.NewLine +
                "Hora de Inicio: " + horarioDeInicio + Environment.NewLine +
                "Hora de Fim: " + horarioDeFim + Environment.NewLine +
                "Assunto: " + assunto + Environment.NewLine+
                "Local: " + local + Environment.NewLine;
        }

    }
}
