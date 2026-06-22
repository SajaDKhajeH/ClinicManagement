using System.Collections.Generic;

namespace ClinicManagement
{
    internal class PatientManager
    {
        private static List<Patient> Patients;

        public List<Patient> GetPatients()
        {
            return Patients;
        }

        public void AddPatient(Patient Patient)
        {
            if (Patients == null)
                Patients = new List<Patient>();

            Patients.Add(Patient);
        }

        public string[] PatientValidation(
            string firstName,
            string lastName,
            string nationalCode,
            string mobileNumber
        ){
            List<string> errors = new List<string>();

            if (firstName == null || firstName.Trim() == "")
                errors.Add("First name field is required.");

            if (lastName == null || lastName.Trim() == "")
                errors.Add("Last name field is required.");

            if (nationalCode == null || nationalCode.Trim() == "")
                errors.Add("National code field is required.");
            else
            if (nationalCode.Length != 10)
                errors.Add("National code is not valid.");

            if (mobileNumber == null || mobileNumber.Trim() == "")
                errors.Add("Mobile field is required.");
            else
            if (mobileNumber.Length != 11)
                errors.Add("Mobile number is not valid.");

            return errors.ToArray();
        }
    }
}
