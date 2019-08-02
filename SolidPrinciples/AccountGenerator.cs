using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Seu nome de usuário é {user.FirstName.Substring(0, 3)}{user.LastName}");
        }
    }
}
