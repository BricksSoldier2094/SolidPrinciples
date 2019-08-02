using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0,1)}_{person.LastName}@acme.com";

            //if (person.persontype == PersonType.Manager)
            //{
            //    output.isManager = true;
            //}

            switch (person.TypeOfEmployee)
            {
                case EmployeeType.Manager:
                    output.isManager = true;
                    break;
                case EmployeeType.Executive:
                    output.isManager = true;
                    output.isExecutive = true;
                    break;
                default:
                    break;
            }


            return output;

        }

    }
}
