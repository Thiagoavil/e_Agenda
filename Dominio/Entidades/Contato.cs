using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Contato : EntidadeBase,IEnumerable
    {
        public string nome{ get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string empresa { get; set; }
        public string cargo{ get; set; }
        

        public Contato()
        {
            
        }

        public override string ToString()
        {
            return
                "Nome: " + nome + Environment.NewLine +
                "Email: " + email + Environment.NewLine +
                "Telefone: " + telefone + Environment.NewLine +
                "Empresa: " + empresa + Environment.NewLine +
                "Cargo: " + cargo + Environment.NewLine;
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
            if (string.IsNullOrEmpty(telefone) || telefone.Length < 9)
                sb.AppendLine("O Telefone não pode estar vazio, e deve conter pelo menos 9 DIGITOS");
            if (string.IsNullOrEmpty(empresa))
                sb.AppendLine("O nome da Empresa não pode estar vazio");

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
