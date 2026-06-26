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

            if (string.IsNullOrWhiteSpace(firstName))
                errors.Add("نام اجباری است");

            if (string.IsNullOrWhiteSpace(lastName))
                errors.Add("نام خانوادگی اجباری است");

            if (string.IsNullOrWhiteSpace(nationalCode))
                errors.Add("کد ملی اجباری است");
            else if (!int.TryParse(nationalCode, out int _))
                errors.Add("کد ملی نامعتبر است");
            else if (nationalCode.Length != 10)
                errors.Add("کد ملی باید ۱۰ رقم باشد");
            else
                foreach (Patient item in Patients)
                    if (item.NationalCode == nationalCode)
                    {
                        errors.Add("کد ملی تکراری است");
                        break;
                    }

            if (string.IsNullOrWhiteSpace(mobileNumber))
                errors.Add("شماره تلفن اجباری است");
            else if (mobileNumber.Length != 11)
                errors.Add("شماره تلفن باید ۱۱ رقم باشد");

            return errors.ToArray();
        }
    }
}
