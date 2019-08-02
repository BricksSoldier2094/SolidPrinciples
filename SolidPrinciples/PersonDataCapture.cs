using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples 
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();
            Console.Write("Informe o seu primeiro nome: ");
            output.FirstName = Console.ReadLine();

            Console.Write("Informe o seu último nome: ");
            output.LastName = Console.ReadLine();

            return output;
        }

    }
}
