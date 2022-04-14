using e_Agenda.Compromisso;
using e_Agenda.Contatos;
using e_Agenda.Tarefas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    internal class TelaMenuPrincipal
    {
        private string opcaoSelecionada;

        //compromisso
        private TelaCompromisso telaCompromisso;
        private RepositorioCompromisso repositorioCompromisso;

        //tarefa
        private TelaTarefa telaTarefa;
        private RepositorioTarefa repositorioTarefa;

        //contato
        private TelaContato telaContato;
        private RepositorioContato repositorioContato;

        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioCompromisso= new RepositorioCompromisso();
            repositorioTarefa = new RepositorioTarefa();
            repositorioContato = new RepositorioContato();

            telaContato = new TelaContato (repositorioContato,notificador);
            
            telaTarefa = new TelaTarefa(repositorioTarefa,notificador);

            telaCompromisso = new TelaCompromisso(repositorioContato,repositorioCompromisso,notificador);
        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("E - Agenda");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Tarefa");
            Console.WriteLine("Digite 2 para Contatos");
            Console.WriteLine("Digite 3 para Compromisso");

            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaTarefa;

            else if (opcao == "2")
                tela = telaContato;

            else if (opcao == "3")
                tela = telaCompromisso;

            return tela;
        }
    }
}
