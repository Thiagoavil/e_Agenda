using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    internal class RepositorioBase<T> where T : EntidadeBase 
    {
        int contadorNumero;
        public List<T> registros;
        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public virtual string Inserir(T entidade)
        {
             ResultadoDaValidacao validacao = entidade.Validar();

            if (validacao.Status == StatusValidacao.Erro)
                return validacao.ToString();
            
                entidade.numero = ++contadorNumero;

                registros.Add(entidade);
           
                

            return "REGISTRO_VALIDO";
        }

        public bool Editar(int numeroSelecionado, T novaEntidade)
        {
            foreach (T entidade in registros)
            {
                if (numeroSelecionado == entidade.numero)
                {
                    novaEntidade.numero = entidade.numero;

                    int posicaoParaEditar = registros.IndexOf(entidade);
                    registros[posicaoParaEditar] = novaEntidade;

                    return true;
                }
            }

            return false;
        }

        public bool Excluir(int numeroSelecionado)
        {
            foreach (T entidade in registros)
            {
                if (numeroSelecionado == entidade.numero)
                {
                    registros.Remove(entidade);
                    return true;
                }
            }

            return false;
        }

        public T SelecionarRegistro(Predicate<T> condicao)
        {
            foreach (T entidade in registros)
            {
                if (condicao(entidade))
                    return entidade;
            }

            return null;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public List<T> Filtrar(Predicate<T> condicao)
        {
            return registros.FindAll(condicao);
        }
    }
}
