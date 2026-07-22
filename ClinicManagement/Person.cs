using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public void Hello()
        {
            var v = Validate();
        }

        public virtual Result Validate()
        {
            if (string.IsNullOrEmpty(FirstName) || FirstName.Length < 2)
            {
                return Result.Failed("نام را وارد کن");
            }
            if (string.IsNullOrEmpty(LastName) || LastName.Length < 2)
            {
                return Result.Failed("نام خانوادگی را وارد کن");
            }

            return Result.Ok();
        }
    }
}
