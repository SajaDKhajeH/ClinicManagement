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
        public void RemovePatient(Patient Patient)
        {
            Patients.Remove(Patient);
        }
    }
}
