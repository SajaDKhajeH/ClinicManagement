using System;

namespace ClinicManagement
{
    public sealed class Patient : Person
    {
        public Patient(string firstName, string lastName)
            : base(firstName, lastName)
        {
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

            string h = Hello();

            return Result.Ok();
        }

    }
}
