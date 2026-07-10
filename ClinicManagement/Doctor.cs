using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    using System;

    public class Doctor
    {
            public Doctor(string medicalCouncilNumber)
            {
            MedicalCouncilNumber = medicalCouncilNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

            public string FullName
            {
                get { return FirstName + " " + LastName; }
            }

        public string MedicalCouncilNumber { get; set; }
        public string[] Specialties { get; set; }

            public string Specialty { get; set; }
    }
}

