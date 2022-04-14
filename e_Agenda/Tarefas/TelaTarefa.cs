using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Tarefas
{
    internal class TelaTarefa :TelaBase , ITela
    {
        private readonly RepositorioTarefa repositorioTarefa;
        private readonly Notificador notificador;

        public TelaTarefa() : base ("Cadastro de tarefa")
        {

        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo tarefa");

            Tarefa tarefa = Obter();

            Console.WriteLine("Quantos intens deseja criar?");
            int quantidadeDeItens = Convert.ToInt32(Console.ReadLine());
            int contador = 0;

            do
            {
                Item itens = ObterItens();
                tarefa.InserirItensNaTarefa(itens);
                contador++;

            } while (contador != quantidadeDeItens);
           


            string statusValidacao = repositorioTarefa.Inserir(tarefa);

            

            if (statusValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("tarefa cadastrada com sucesso!", "sucesso");
            else
                notificador.ApresentarMensagem(statusValidacao, "erro");
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando Tarefa");

            bool temContatoCadastrados = VisualizarRegistro("Pesquisando");

            if (temContatoCadastrados == false)
            {
                notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para poder editar.", "atencao");
                return;
            }

            Console.WriteLine("Digite o numeros da tarefa que quer editar");
            int numeroTarefa = Convert.ToInt32(Console.ReadLine());

            Tarefa tarefaAtualizado = Obter();

            bool conseguiuEditar = repositorioTarefa.Editar(x => x.numero == numeroTarefa, tarefaAtualizado);

            if (!conseguiuEditar)
                notificador.ApresentarMensagem("Não foi possível editar.", "erro");
            else
                notificador.ApresentarMensagem("Tarefa editada com sucesso", "sucesso");

        }

        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluido Contato");

            bool temTarefaCadastrados = VisualizarRegistro("Pesquisando");

            if (temTarefaCadastrados == false)
            {
                notificador.ApresentarMensagem(
                    "Nenhuma Tarefa cadastrada para poder excluir", "atencao");
                return;
            }

            Console.WriteLine("Digite o numeros da Tarefa que quer excluir");
            int numeroTarefa = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = repositorioTarefa.Excluir(x => x.numero == numeroTarefa);

            if (!conseguiuExcluir)
                notificador.ApresentarMensagem("Não foi possível excluir.", "erro");
            else
                notificador.ApresentarMensagem("Tarefa excluído com sucesso!", "sucesso");
        }

        public bool VisualizarRegistro(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualizando Tarefa");

            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            if (tarefas.Count == 0)
            {
                notificador.ApresentarMensagem("Não há nenhuma Tarefa disponível.", "atencao");
                return false;
            }

            foreach (Tarefa tarefa in tarefas)
                Console.WriteLine(tarefa.ToString());

            Console.ReadLine();

            return true;

        }

        private Tarefa Obter()
        {
            Console.Write("Digite o titulo da tarefa: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o nivel de prioridade:\n1 - Baixa\n2 - Media\n3 - Alta ");
            int prioridade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a data de criação da tarefa:  (dd/mm/aaaa)");
            DateTime dataDeCriacao = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite a empresa do contato: ");
            DateTime dataDeConclusao = DateTime.Parse(Console.ReadLine());

            Tarefa tarefa = new Tarefa(titulo, prioridade, dataDeCriacao, dataDeConclusao);

            return tarefa;

        }

        private Item ObterItens()
        {

            Console.Write("Digite a descrição do item: ");
            string descricao = Console.ReadLine();

            Item item = new Item(descricao);

            return item;
        }
    }
}
