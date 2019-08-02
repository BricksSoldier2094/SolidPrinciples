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

            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Henrique", LastName ="Souza"},
                new ManagerModel { FirstName = "Ororo", LastName= "Monroe" },
                new ExecutiveModel { FirstName = "Jean", LastName = "Grey"}
            };

            List<EmployeeModel> Employees = new List<EmployeeModel>();            

            foreach (IApplicantModel item in applicants)
            {
                Employees.Add(item.AccountProcessor.Create(item));
            }

            foreach (EmployeeModel emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} | {emp.EmailAddress} | É gerente: {emp.isManager} | É executivo : {emp.isExecutive}");
            }

            Console.ReadLine();

        }
    }
}
