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
                errors.Add("نام اجباری است");

            if (lastName == null || lastName.Trim() == "")
                errors.Add("نام خانوادگی اجباری است");

            if (nationalCode == null || nationalCode.Trim() == "")
                errors.Add("کد ملی اجباری است");
            else
            if (!int.TryParse(nationalCode, out int _))
                errors.Add("کد ملی نامعتبر است");
            else
            if (nationalCode.Length != 10)
                errors.Add("کد ملی باید ۱۰ رقم باشد");

            if (mobileNumber == null || mobileNumber.Trim() == "")
                errors.Add("شماره تلفن اجباری است");
            else
            if (mobileNumber.Length != 11)
                errors.Add("شماره تلفن باید ۱۱ رقم باشد");

            return errors.ToArray();
        }
    }
}
