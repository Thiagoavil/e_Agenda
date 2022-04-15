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
        int prioridade;
        public decimal percentual;
        string titulo;
        public bool concluido;
        public Prioridade tipoprioridade;
        public DateTime dataDeCriacao, dataDeConclusao;
        public List<Item> listaDeItens;

        

        public enum Prioridade
        {
            Baixa = 1,
            Media = 2,
            Alta = 3,
        }

        public Tarefa(string titulo, int prioridade, DateTime datadecriacao,DateTime dataDeConclusao)
        {
            
            this.titulo = titulo;
            
            this.dataDeCriacao = datadecriacao;
            this.dataDeCriacao = dataDeConclusao;
            this.tipoprioridade = new Prioridade();
            concluido = false;
            listaDeItens = new List<Item>();
            
            if (prioridade == 1)
                this.tipoprioridade = Prioridade.Baixa;
            else if (prioridade == 2)
                this.tipoprioridade = Prioridade.Media;
            else
                this.tipoprioridade = Prioridade.Alta;


        }

        public Tarefa(string titulo, int prioridade, DateTime datadecriacao, DateTime dataDeConclusao,List<Item>itens)
        {

            this.titulo = titulo;

            this.dataDeCriacao = datadecriacao;
            this.dataDeCriacao = dataDeConclusao;
            this.tipoprioridade = new Prioridade();
            concluido = false;
            listaDeItens = itens;

            if (prioridade == 1)
                this.tipoprioridade = Prioridade.Baixa;
            else if (prioridade == 2)
                this.tipoprioridade = Prioridade.Media;
            else
                this.tipoprioridade = Prioridade.Alta;

        }

        //Testar(grande chance de erro
        public string ToStringDeitens()
        {
            StringBuilder si = new StringBuilder();

            foreach (Item item in listaDeItens)
            {
               si.AppendLine(item.descricao);
            }

            return si.ToString();
        }

        //Testar(grande chance de erro
        public override string ToString()
        {
            return 
                "Titulo: " + titulo + Environment.NewLine +
                "prioridade: " + tipoprioridade + Environment.NewLine +
                "Data de criação: " + dataDeCriacao + Environment.NewLine +
                "Data de conclusão: " + dataDeConclusao + Environment.NewLine +
                "Pecentual Completo: " + Math.Round(percentual,1) + Environment.NewLine+
                //aqui ó
                "Tarefas"+  ToStringDeitens() ;
        }
                

        public override ResultadoDaValidacao Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("É necessário ter um titulo!");

            if (prioridade <= 0 || prioridade >3)
                erros.Add("A prioridade tem que ser um numero de 1 a 3!");

            if (dataDeCriacao > DateTime.Now)
                erros.Add("A data de criação da tarefa tem que ser um dia maior que hoje!");

            return new ResultadoDaValidacao(erros);
        }

        public void InserirItensNaTarefa(Item items)
        {
            listaDeItens.Add(items);
        }

        public List<Item> SelecionarItens()
        {
            return listaDeItens;
        }

        public Item SelecionarItem(Predicate<Item> condicao)
        {
            foreach (Item item in listaDeItens)
            {
                if (condicao(item))
                    return item;
            }

            return null;
        }

        public bool concluirItem(Item itemSelecionado)
        {
            itemSelecionado.itemConcluido = true;
            
            if(itemSelecionado.itemConcluido == true)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }
    }
}
