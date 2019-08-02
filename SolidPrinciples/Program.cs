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
            StandardMessages.WelcomeMesage();

            //Captura dados do usuario
            var user = PersonDataCapture.Capture();

            //Valida as informações do usuario
            if (!PersonValidator.Validate(user))
            {
                StandardMessages.EndApplication();
                return;
            }

            //Cria um novo usuario
            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }

   
}
