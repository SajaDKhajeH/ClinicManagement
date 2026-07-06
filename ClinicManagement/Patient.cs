using System;

namespace ClinicManagement
{
    public class Patient
    {
        public Patient(string firstName = "", string lastName = "")
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

    }
}
