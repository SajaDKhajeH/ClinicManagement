using System;
using System.Linq;

namespace ClinicManagement
{
    public class Doctor : Person
    {
        private Doctor() : base("", "")
        {
            Id = DoctorManager.GenerateNewId();
        }
        public Doctor(string nezamPezeshki) : this()
        {
            NezamPezeshki = nezamPezeshki;

        }
        public Doctor(string firstName, string lastName) : this("")
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string NezamPezeshki { get; set; }
        public string[] Specialties { get; set; }

        public string FullSpecialties
        {
            get
            {
                return string.Join(", ", Specialties);
            }
        }
    }
}
