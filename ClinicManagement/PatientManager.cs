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
        public void DeletePatient(int index)
        { 
            if(Patients != null && index>=0)
            {
                Patients.RemoveAt(index);
            }
        }
    }
}
