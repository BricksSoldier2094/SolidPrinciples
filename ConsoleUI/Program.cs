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
                new PersonModel { FirstName = "Ororo", LastName= "Monroe", TypeOfEmployee = EmployeeType.Manager },
                new PersonModel { FirstName = "Jean", LastName = "Grey", TypeOfEmployee = EmployeeType.Executive}
            };

            List<EmployeeModel> Employees = new List<EmployeeModel>();
            Accounts accountsProcessor = new Accounts();

            foreach (PersonModel person in applicants)
            {
                Employees.Add(accountsProcessor.Create(person));
            }

            foreach (EmployeeModel emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} | {emp.EmailAddress} | {emp.isManager} | {emp.isExecutive}");
            }

            Console.ReadLine();

        }
    }
}
