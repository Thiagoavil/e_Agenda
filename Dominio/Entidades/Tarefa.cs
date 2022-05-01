using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tarefa : EntidadeBase
    {
        private List<Item> itens = new List<Item>();

        public decimal Percentual { get; set; }
        public int prioridade { get; set; }
        public string Prioridade { get; set; }  
        public string Titulo { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime?  DataDeConclusao { get; set; }
        public List<Item> ListaDeItens { get { return itens; } }
              

        public Tarefa()
        {
            DataDeCriacao = DateTime.Now;
        }
                        
        public override string ToString()
        {
            Percentual = CalcularPercentualConcluido();

            if (DataDeConclusao.HasValue)
            {
                return $"ID: {id}, Título: {Titulo}, Percentual: {Percentual}, " +
                    $"Concluída: {DataDeConclusao.Value.ToShortDateString()}";

            }
           
            
            return $" ID: { id}, Título: {Titulo}, Percentual: {Percentual} ";
        }
              
        public void AdicionarItem(Item item)
        {
            if (ListaDeItens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            Percentual = CalcularPercentualConcluido();

            if (Percentual == 100)
                DataDeConclusao = DateTime.Now;
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

            return Math.Round(percentualConcluido,1);
        }

        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Titulo))
                sb.AppendLine("É necessário ter um titulo!");

            if (Prioridade==null)
                sb.AppendLine("A prioridade tem que ser selecionada!");
           
            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

    }
}
