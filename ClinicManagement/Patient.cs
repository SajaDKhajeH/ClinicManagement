using System;

namespace ClinicManagement
{
    public class Patient:Person
    {
<<<<<<< HEAD
        
       
        public string NationalCode { get;private set; }
        public string MobileNumber { get; private set; }
        public Patient(string firstName, string lastName, string nationalCode, string mobileNumber)
            :base(firstName, lastName)
=======
        public Patient(string firstName = "", string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
        {
            NationalCode = nationalCode;
            MobileNumber = mobileNumber;
        }
<<<<<<< HEAD
=======
        private string nationalCode;

        public string NationalCode
        {
            get { return nationalCode; }
            set { nationalCode = value; }
        }

        public string MobileNumber { get; set; }

        public Result Validate()
        {
            if (NationalCode.Length != 10)
            {
                return Result.Failed("کدملی نامعتبر");
            }

            return Result.Ok();
        }

>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
    }
}
