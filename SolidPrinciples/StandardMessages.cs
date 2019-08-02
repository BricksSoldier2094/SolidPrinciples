using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class StandardMessages
    {
        public static void WelcomeMesage()
        {
            Console.WriteLine("Bem vindo ao meu programa!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Pressione enter para fechar");
            Console.ReadLine(); 
        }

        public static void DisplayValidationError(string field)
        {
            Console.Write($"Você não informou um { field } válido!");
        }

    }
}
