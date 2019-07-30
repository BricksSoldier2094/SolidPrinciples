using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mensagem de boas vindas
            WriteLine("Bem vindo ao meu programa!");

            //Captura dados do usuario
            Usuario usuario = new Usuario();
            Write("Informe o seu primeiro nome: ");
            usuario.FirstName = ReadLine();
            
            Write("Informe o seu último nome: ");
            usuario.LastName = ReadLine();

            //Valida as informações do usuario
            if (string.IsNullOrWhiteSpace(usuario.FirstName))
            {
                Write("Você não informou um primeiro nome válido!");
                return;
            }

            if (string.IsNullOrWhiteSpace(usuario.LastName))
            {
                Write("Você não informou um úlimo nome válido!");
                return;
            }

            //Cria um novo usuario
            WriteLine($"Seu nome de usuário é {usuario.FirstName.Substring(0, 3)}{usuario.LastName}" );

            ReadLine();


        }
    }

   
}
