using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.Compartilhado;
using e_Agenda.Contatos;

namespace e_Agenda.Compromisso
{
    internal class TelaCompromisso :TelaBase, ITela
    {
        private readonly TelaContato telaContato;
        private readonly RepositorioCompromisso repositorioCompromisso;
        private readonly RepositorioContato repositorioContato;
        private readonly Notificador notificador;

        public TelaCompromisso(RepositorioContato repositorioContato,RepositorioCompromisso repositorioCompromisso,
            Notificador notificador) : base("Cadastro de Compromisso")
        {
            this.repositorioContato=repositorioContato;
            this.repositorioCompromisso=repositorioCompromisso;
            this.notificador=notificador;
        }

        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo Compromisso");

            Contato contatoselecionado = ObtemContato();

            Compromisso compromisso = Obter(contatoselecionado);

            string statusValidacao = repositorioCompromisso.Inserir(compromisso);

            if (statusValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Compromisso cadastrado com sucesso!", "sucesso");
            else
                notificador.ApresentarMensagem(statusValidacao, "erro");
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando Compromisso");

            bool temCompromissoCadastrados = VisualizarRegistro("Pesquisando");

            if (temCompromissoCadastrados == false)
            {
                notificador.ApresentarMensagem("Nenhum Compromisso cadastrado para poder editar.", "atencao");
                return;
            }

            Console.WriteLine("Digite o numeros do compromisso que quer editar");
            int numeroCompromisso = Convert.ToInt32(Console.ReadLine());

            Contato contatoselecionado = ObtemContato();

            Compromisso compromissoAtualizado = Obter(contatoselecionado);

            bool conseguiuEditar = repositorioCompromisso.Editar(x => x.numero == numeroCompromisso , compromissoAtualizado);

            if (!conseguiuEditar)
                notificador.ApresentarMensagem("Não foi possível editar.", "erro");
            else
                notificador.ApresentarMensagem("Compromisso editado com sucesso", "sucesso");

        }

        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluido Compromisso");

            bool temCompromissoCadastrados = VisualizarRegistro("Pesquisando");

            if (temCompromissoCadastrados == false)
            {
                notificador.ApresentarMensagem(
                    "Nenhum amigo Compromisso para poder excluir", "atencao");
                return;
            }

            Console.WriteLine("Digite o numeros do Compromisso que quer excluir");
            int numeroCompromisso = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = repositorioCompromisso.Excluir(x => x.numero == numeroCompromisso);

            if (!conseguiuExcluir)
                notificador.ApresentarMensagem("Não foi possível excluir.", "erro");
            else
                notificador.ApresentarMensagem("Compromisso excluído com sucesso!", "sucesso");
        }

        public bool VisualizarRegistro(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualizando Compromisso");

            List<Compromisso> compromissosFuturos = repositorioCompromisso.Filtrar(x=>x.dataCompromisso>DateTime.Now);
            
            List<Compromisso> compromissosPassados = repositorioCompromisso.Filtrar(x=>x.dataCompromisso<DateTime.Now);


            if (compromissosFuturos.Count == 0 || compromissosPassados.Count==0)
            {
                notificador.ApresentarMensagem("Não há nenhum compromisso disponível.", "atencao");
                return false;
            }
            
            Console.WriteLine("Compromissos Futuros");
            foreach (Compromisso compromisso in compromissosFuturos)
                Console.WriteLine(compromisso.ToString());


            Console.WriteLine("Compromissos Passados");
            foreach (Compromisso compromisso in compromissosPassados)
                Console.WriteLine(compromisso.ToString());


            Console.ReadLine();

            return true;

        }

        private Compromisso Obter(Contato contatoselecionado)
        {

            Console.Write("Digite a data do compromisso:  (dd/mm/aaaa)");
            DateTime dataCompromisso = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite o horário de inicio do compromisso: ");
            DateTime horarioDeInicio = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite o horário de fim do compromisso: ");
            DateTime horarioDeFim = DateTime.Parse(Console.ReadLine());

            Console.Write("Digite assunto do compromisso: ");
            string assunto = Console.ReadLine();

            Console.Write("Digite o local do compromisso: ");
            string local = Console.ReadLine();

            Compromisso compromisso = new Compromisso(contatoselecionado, dataCompromisso, horarioDeInicio, horarioDeFim, assunto, local);

            return compromisso;

        }

        private Contato ObtemContato()
        {
            bool temContatoDisponiveis = telaContato.VisualizarRegistro("");

            if (!temContatoDisponiveis)
            {
                notificador.ApresentarMensagem("Não há nenhuma contatos disponível ", "atencao");
                return null;
            }

            Console.Write("Digite o número do contato que irá inserir: ");
            int numContatoSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Contato contatoselecionado = repositorioContato.SelecionarRegistro(x => x.numero == numContatoSelecionado);

            return contatoselecionado;
        }

    }
}
