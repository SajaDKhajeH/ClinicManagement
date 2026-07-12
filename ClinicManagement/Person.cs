using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    public abstract class Person
    {
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
        }
        public string FullName => $"{FirstName} {LastName}";
    }
}
