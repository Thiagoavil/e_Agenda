using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Tarefas
{
    internal class Item : EntidadeBase
    {
        public string descricao;
        public bool itemConcluido;
        

        public Item(string descricao)
        {
            
            this.descricao = descricao;
            this.itemConcluido = false;
        }

        public override string ToString()
        {
            
            string Estatus = itemConcluido ? "Concluido" : "pendente";
            
            return
                "Descrição: " + descricao + Environment.NewLine+
                Estatus;
                
        }


        public override ResultadoDaValidacao Validar()
        {
            List<string> erros = new List<string>();

           
            if (string.IsNullOrEmpty(descricao))
                erros.Add("É necessário ter um titulo!");

            return new ResultadoDaValidacao(erros);
        }

    }
}
