using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Tarefas
{
    internal class Tarefa : EntidadeBase
    {
        int prioridade,percentual;
        string titulo;
        Prioridade tipoprioridade;
        DateTime dataDeCriacao, dataDeConclusao;
        List<Item> items;
        List<Tarefa> tarefasConcluidas;
        List<Tarefa> tarefasEmAndamento;

        
        public enum Prioridade
        {
            Baixa, Media, Alta
        }

        public Tarefa(string titulo, int prioridade, DateTime datadecriacao,DateTime dataDeConclusao)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataDeCriacao = datadecriacao;
            this.dataDeCriacao = dataDeConclusao;
            
        }
        //Testar(grande chance de erro
        public string ToStringDeitens()
        {
            StringBuilder si = new StringBuilder();

            foreach (Item item in items)
            {
               si.AppendLine(item.Execucao);
            }

            return si.ToString();
        }

        //Testar(grande chance de erro
        public override string ToString()
        {
            return "Titulo: " + titulo + Environment.NewLine +
                "prioridade: " + tipoprioridade + Environment.NewLine +
                "Data de criação: " + dataDeCriacao + Environment.NewLine +
                "Data de conclusão: " + dataDeConclusao + Environment.NewLine +
                "Pecentual Completo: " + percentual + Environment.NewLine+
                //aqui ó
                "Tarefas"+  ToStringDeitens() ;
        }
                

        public override ResultadoDaValidacao Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("É necessário ter um titulo!");

            if (prioridade < 0 || prioridade >3)
                erros.Add("A prioridade tem que ser um numero de 1 a 3!");

            if (dataDeCriacao > DateTime.Now)
                erros.Add("A data de criação da tarefa tem que ser um dia maior que hoje!");

            return new ResultadoDaValidacao(erros);
        }
    }
}
