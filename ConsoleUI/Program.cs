using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPLibrary;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Henrique", LastName ="Souza"},
                new PersonModel { FirstName = "Ororo", LastName= "Monroe" },
                new PersonModel { FirstName = "Jean", LastName = "Grey"}
            };

            List<EmployeeModel> Employees = new List<EmployeeModel>();
            Accounts accountsProcessor = new Accounts();

            foreach (PersonModel person in applicants)
            {
                Employees.Add(accountsProcessor.Create(person));
            }

            foreach (EmployeeModel emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} | {emp.EmailAddress}");
            }

            Console.ReadLine();

        }
    }
}
