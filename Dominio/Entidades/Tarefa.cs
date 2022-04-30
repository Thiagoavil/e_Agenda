using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Tarefa : EntidadeBase
    {
        private List<Item> itens = new List<Item>();


        public string titulo { get; set; }
        public DateTime dataDeCriacao { get; set; }
        public DateTime?  dataDeConclusao { get; set; }
        public List<Item> listaDeItens { get { return itens; } }

        public Tarefa(int n, string t) : this()
        {
            numero = n;
            titulo = t;
            dataDeConclusao = null;
        }

        public Tarefa()
        {
            dataDeCriacao = DateTime.Now;
        }
                        
        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (dataDeConclusao.HasValue)
            {


                return
                    "Numero: " + numero + Environment.NewLine +
                    "Titulo: " + titulo + Environment.NewLine +
                    "Pecentual: " + Math.Round(percentual, 1)+Environment.NewLine+
                    "Concluida: " + dataDeConclusao.Value.ToShortDateString();
                
            }

            return "Numero: " + numero + Environment.NewLine +
                    "Titulo: " + titulo + Environment.NewLine +
                    "Pecentual Completo: " + Math.Round(percentual, 1);
        }
              
        public void AdicionarItem(Item item)
        {
            if (listaDeItens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                dataDeConclusao = DateTime.Now;
        }

        public void MarcarPendente(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.itemConcluido);  

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }
                
    }
}
