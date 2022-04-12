using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Compartilhado
{
    internal class Notificador
    {
        public void ApresentarMensagem(string mensagem, string tipoMensagem)
        {
            switch (tipoMensagem)
            {
                case "sucesso":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case "atencao":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case "erro":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                default:
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
