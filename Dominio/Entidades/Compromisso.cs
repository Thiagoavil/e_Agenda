using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Compromisso : EntidadeBase
    {
        public Contato contato;
        public DateTime dataCompromisso;
        DateTime horarioDeInicio, horarioDeFim;
        string assunto, local;

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

    }
}
