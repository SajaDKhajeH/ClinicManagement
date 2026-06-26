using System;
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

        public void RemovePatientByNationalCode(string nationalCode)
        {
            foreach (Patient item in Patients)
                if(item.NationalCode == nationalCode) {
                    Patients.Remove(item);
                    break;
                }
        }
    }
}
