using e_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace e_Agenda.Contatos
{
    internal class Contato : EntidadeBase
    {
        string nome, email, telefone, empresa, cargo;

        public string Nome => nome;

        public Contato(string nome,string email,string telefone,string empresa,string cargo)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;  
            this.empresa = empresa;
            this.cargo = cargo;
        }

        public override ResultadoDaValidacao Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O nome não pode estar vazio");
            if (string.IsNullOrEmpty(email))
                erros.Add("O Email não pode estar vazio");
            if (string.IsNullOrEmpty(telefone) || telefone.Length < 9)
                erros.Add("O Telefone não pode estar vazio, e deve conter pelo menos 9 DIGITOS");
            if (string.IsNullOrEmpty(empresa))
                erros.Add("O nome da Empresa não pode estar vazio");

            return new ResultadoDaValidacao(erros);
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

    }
}
