using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contato : EntidadeBase,IEnumerable
    {
        public string nome{ get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string empresa { get; set; }
        public string cargo { get; set; }
        public bool temCompromisso { get; set; }



        public Contato()
        {
            
        }

        public override string ToString()
        {
            if(empresa=="" && cargo=="")
            {
                return $"ID: {id} Nome: {nome} Email: {email} Telefone: {telefone} ";
            }
            else if(cargo=="")
            {
                return $"ID: {id} Nome: {nome} Email: {email} Telefone: {telefone} Empresa: {empresa} ";
            }
            else if(empresa=="")
            {
                return $"ID: {id} Nome: {nome} Email: {email} Telefone: {telefone} Cargo: {cargo} ";
            }

            return $"ID: {id} Nome: {nome} Email: {email} Telefone: {telefone} Empresa: {empresa} " +
                $"Cargo:{cargo}";

        }
        public override string Validar()
        {
            StringBuilder sb = new StringBuilder();
            EmailAddressAttribute e = new EmailAddressAttribute();

            if (string.IsNullOrEmpty(nome))
                sb.AppendLine("O nome não pode estar vazio");
            if (string.IsNullOrEmpty(email))
                sb.AppendLine("O Email não pode estar vazio");
            if (!e.IsValid(email))
                sb.AppendLine("Email inválido");
            if (string.IsNullOrEmpty(telefone))
                sb.AppendLine("O Telefone não pode estar vazio");
            if(telefone.Length<15)
                sb.AppendLine("O Telefone não está no formato válido");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
