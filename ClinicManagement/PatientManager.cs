using System.Collections.Generic;
using System.Linq;

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

        public void DeletePatient(Patient patient)
        {
            if (Patients != null)
            {
                Patients.Remove(patient);
            }
        }

        public List<Patient> SearchPatient(string searchText)
        {
            if (Patients == null)
                return new List<Patient>();

            return Patients
                .Where(p =>
                    p.FirstName.Contains(searchText) ||
                    p.LastName.Contains(searchText) ||
                    p.NationalCode.Contains(searchText) ||
                    p.MobileNumber.Contains(searchText))
                .ToList();
        }

        public string ValidatePatient(Patient patient)
        {
            if (patient == null)
                return "اطلاعات بیمار نامعتبر است.";

            if (string.IsNullOrWhiteSpace(patient.FirstName) ||
                string.IsNullOrWhiteSpace(patient.LastName) ||
                string.IsNullOrWhiteSpace(patient.NationalCode) ||
                string.IsNullOrWhiteSpace(patient.MobileNumber))
            {
                return "وارد کردن تمامی اطلاعات الزامی است.";
            }

            if (patient.NationalCode.Length != 10 ||
                !patient.NationalCode.All(char.IsDigit))
            {
                return "کد ملی باید دقیقاً 10 رقم باشد.";
            }

            if (!patient.MobileNumber.StartsWith("09") ||
                patient.MobileNumber.Length != 11 ||
                !patient.MobileNumber.All(char.IsDigit))
            {
                return "شماره موبایل معتبر نیست.";
            }

            var patients = GetPatients();

            if (patients != null &&
                patients.Any(p => p.NationalCode == patient.NationalCode))
            {
                return "این کد ملی قبلاً ثبت شده است.";
            }

            return null; 
        }
    }
}
