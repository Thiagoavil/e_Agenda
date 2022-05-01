using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Repositorio<T> where T : EntidadeBase
    {
        protected int contadorNumero;
        protected readonly List<T> registros;
        public Repositorio()
        {
            registros = new List<T>();
        }

        public virtual string Inserir(T entidade)
        {
            string resultado = entidade.Validar();
           
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            entidade.id = ++contadorNumero;

            registros.Add(entidade);
            return "REGISTRO_VALIDO";
        }

        public string Editar(T novoRegistro, T antigoRegistro)
        {
            string resultado = novoRegistro.Validar();

            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            int indice = registros.FindIndex(x => x.id == antigoRegistro.id);
            registros[indice] = novoRegistro;
            
            return "REGISTRO_VALIDO";
        }

        public bool Excluir(Predicate<T> condicao)
        {
            foreach (T entidade in registros)
            {
                if (condicao(entidade))
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

