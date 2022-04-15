using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;

namespace e_Agenda.Tarefas
{
    internal class TelaTarefa : TelaBase, ITela
    {
        private readonly RepositorioTarefa repositorioTarefa;
        private readonly Notificador notificador;

        public TelaTarefa(RepositorioTarefa repositorioTarefa, Notificador notificador) : base("Cadastro de tarefa")
        {
            this.repositorioTarefa = repositorioTarefa;
            this.notificador = notificador;
        }

        public override string MostrarOpcoes()
        {
            MostrarTitulo(Titulo);

            Console.WriteLine("Digite 1 para cadastrar tarefa");
            Console.WriteLine("Digite 2 para Editar tarefa");
            Console.WriteLine("Digite 3 para Excluir tarefa");
            Console.WriteLine("Digite 4 para Visualizar tarefas");
            Console.WriteLine("Digite 5 para finalizar Item da tarefa");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;

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
            {
                notificador.ApresentarMensagem("tarefa cadastrada com sucesso!", "sucesso");
                tarefa.percentual = atualizarPorcentagem(tarefa);
            }
            else
                notificador.ApresentarMensagem(statusValidacao, "erro");
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando Tarefa");

            bool temTarefaCadastrados = VisualizarRegistro("Pesquisando");

            if (temTarefaCadastrados == false)
            {
                notificador.ApresentarMensagem("Nenhuma tarefa cadastrada para poder editar.", "atencao");
                return;
            }

            Console.WriteLine("Digite o numeros da tarefa que quer editar");
            int numeroTarefa = Convert.ToInt32(Console.ReadLine());

            Tarefa antiga = repositorioTarefa.SelecionarRegistro(x=>x.numero==numeroTarefa);

            Tarefa tarefaAtualizada = ObterParaEditar(antiga);

            bool conseguiuEditar = repositorioTarefa.Editar(x => x.numero == numeroTarefa, tarefaAtualizada);

            if (!conseguiuEditar)
            {
                notificador.ApresentarMensagem("Não foi possível editar.", "erro");
                tarefaAtualizada.percentual = atualizarPorcentagem(tarefaAtualizada);
            }
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


            List<Tarefa> tarefas = new List<Tarefa>();

            Console.WriteLine("Digite 1 para visualizar tarefas diarias");
            Console.WriteLine("Digite 2 para visualizar tarefas semanais");
            Console.WriteLine("Digite 3 para visualizar tarefas Mensais");
            string opcaoDePeriodo=Console.ReadLine();

            if(opcaoDePeriodo == "1")
            {
                tarefas = repositorioTarefa.Filtrar(x => x.dataDeConclusao == DateTime.Now);
            }
            else if(opcaoDePeriodo=="2")
            {
                
            }
            else if (opcaoDePeriodo=="3")
            {

            }

            Console.WriteLine("Digite 1 para visualizar tarefas concluidas");
            Console.WriteLine("Digite 2 para visualizar tarefas incompletas");
            string opcaoVisualizar = Console.ReadLine();
           
                if (opcaoVisualizar == "1")
                {
                    tarefas = repositorioTarefa.Filtrar(x => x.concluido == true);
                }
                else if (opcaoVisualizar=="2")
                {
                    tarefas = repositorioTarefa.Filtrar(x => x.concluido == false);
                }


                AgrupadosPorPrioridade();

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

        public void ConcluirItem()
        {
            bool temTarefaCadastrados = VisualizarRegistro("Pesquisando");


            if (temTarefaCadastrados == false)
            {
                notificador.ApresentarMensagem(
                    "Nenhuma Tarefa cadastrada", "atencao");
                return;
            }

            Console.WriteLine("Digite o Id da tarefa que deseja mexer");
            int numeroDaTarefa =Convert.ToInt32(Console.ReadLine());

            Tarefa tarefaSelecionada=repositorioTarefa.SelecionarRegistro(x=>x.numero==numeroDaTarefa);

            string itensSelecionados=tarefaSelecionada.ToStringDeitens();

            Console.WriteLine(itensSelecionados);

            Console.WriteLine("Digite o Id do item que quer concluir");
            int numeroDoItem=Convert.ToInt32(Console.ReadLine());

            Item itemSelecionado=tarefaSelecionada.SelecionarItem(x=>x.numero== numeroDoItem);

            bool finalizada = tarefaSelecionada.concluirItem(itemSelecionado);
           
            if(finalizada == true)
            {
                notificador.ApresentarMensagem("item Finalizado ", "sucesso");
                tarefaSelecionada.percentual = atualizarPorcentagem(tarefaSelecionada);
            }
            else
            {
                notificador.ApresentarMensagem("item não foi finalizada","erro");
            }
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

        public void AgrupadosPorPrioridade()
        {
            repositorioTarefa.registros.Sort((a, b) => a.tipoprioridade.CompareTo(b.tipoprioridade));
        }

        private Tarefa ObterParaEditar(Tarefa antiga)
        {
            List<Item> itens=antiga.listaDeItens;

            DateTime dataDeCriacao = antiga.dataDeCriacao;

            Console.Write("Digite o titulo da tarefa: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o nivel de prioridade:\n1 - Baixa\n2 - Media\n3 - Alta ");
            int prioridade = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Digite a empresa do contato: ");
            DateTime dataDeConclusao = DateTime.Parse(Console.ReadLine());

            Tarefa tarefa = new Tarefa(titulo, prioridade, dataDeCriacao, dataDeConclusao,itens);

            return tarefa;

        }

        public decimal atualizarPorcentagem(Tarefa tarefaSelecionada)
        {
            decimal pedaçoDaPorcentagem = tarefaSelecionada.listaDeItens.Count / 100;
            decimal porcentagemDeConclusão = 0;

            foreach(Item item in tarefaSelecionada.listaDeItens)
            {
                if (item.itemConcluido)
                    porcentagemDeConclusão += pedaçoDaPorcentagem;
            }

            if(porcentagemDeConclusão >= 99.5m)
            {
                tarefaSelecionada.concluido = true;
            }

            return porcentagemDeConclusão;
        }
    }
}
