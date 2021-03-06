using Infra;
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Repositorio<T> where T : EntidadeBase
    {
        private readonly ISerializator<T> _serializator;
        protected int contadorNumero;
        protected readonly List<T> registros;
        public Repositorio(ISerializator<T> serializator)
        {
            _serializator = serializator;
            registros = serializator.Load();
        }

        public virtual string Inserir(T entidade)
        {
            string resultado = entidade.Validar();

            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            entidade.id = ++contadorNumero;

            registros.Add(entidade);
            _serializator.Save(registros);
            return "REGISTRO_VALIDO";
        }

        public virtual string Editar(T novoRegistro, T antigoRegistro)
        {
            string resultado = novoRegistro.Validar();
            if (resultado != "REGISTRO_VALIDO")
                return resultado;

            int indice = (registros.FindIndex(x => x.id == antigoRegistro.id));
            registros[indice] = novoRegistro;
            _serializator.Save(registros);
            return "REGISTRO_VALIDO";
        }


        public bool Excluir(T entidade)
        {
            --contadorNumero;
            bool exclui = registros.Remove(entidade);
            _serializator.Save(registros);
            return exclui;
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

        public bool ExisteRegistro()
        {
            int Count = registros.Count;
            if (Count == 0)
                return false;
            else
                return true;
        }
        public void AtualizarId()
        {
            int idatualiazado = 0;
            foreach (T registro in registros)
                registro.id = ++idatualiazado;

        }
    }
}

