using System;
using System.Linq;

namespace ClinicManagement
{
    public class Doctor
    {
        public Doctor(string medicalCouncilNumber) {
            MedicalCouncilNumber = medicalCouncilNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MedicalCouncilNumber { get; set; }
        public string[] Specialties { get; set; }

        public string FullSpecialties { 
            get {
                return string.Join(", ", Specialties);
            } 
        }
    }
}
