using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    internal class TelaBase
    {

        protected string Titulo { get; set; }

        protected T ObterValor<T>(string mensagem)
        {
            T valor = default(T);
            string tipo = typeof(T).Name;
            
            Console.WriteLine(mensagem);

            try
            {
                valor = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            }
            catch (FormatException)
            {
                switch (tipo)
                {
                    case "Int32":
                        Console.WriteLine("Inválido");
                        break;
                }


            }
            return valor;
        }
            
        public TelaBase(string titulo)
        {
            Titulo = titulo;
        }

        public virtual string MostrarOpcoes()
        {
            MostrarTitulo(Titulo);

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;

        }

        protected void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

    }
    
}
