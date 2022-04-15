using e_Agenda.Compartilhado;
using e_Agenda.Tarefas;
using System;

namespace e_Agenda
{
    internal class Program
    {
        static Notificador notificador = new Notificador();
        static TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal(notificador);

        static void Main(string[] args)
        {
            TelaBase telaSelecionada = menuPrincipal.ObterTela();

            if (telaSelecionada is null)
                return;

            string opcaoSelecionada = telaSelecionada.MostrarOpcoes();

            if (telaSelecionada is ITela)
            {
                ITela telaCadastroBasico = (ITela)telaSelecionada;

                if (opcaoSelecionada == "1")
                    telaCadastroBasico.InserirRegistro();

                if (opcaoSelecionada == "2")
                    telaCadastroBasico.EditarRegistro();

                if (opcaoSelecionada == "3")
                    telaCadastroBasico.ExcluirRegistro();

                if (opcaoSelecionada == "4")
                    telaCadastroBasico.VisualizarRegistro("Tela");
            }
            else
            {
                TelaTarefa telaconta = telaSelecionada as TelaTarefa;

                if (opcaoSelecionada == "1")
                    telaconta.InserirRegistro();

                if (opcaoSelecionada == "2")
                    telaconta.EditarRegistro();

                if (opcaoSelecionada == "3")
                    telaconta.ExcluirRegistro();

                if (opcaoSelecionada == "4")
                    telaconta.VisualizarRegistro("Tela");

                if (opcaoSelecionada == "5")
                    telaconta.ConcluirItem();

            }
        }
        
    }
}
