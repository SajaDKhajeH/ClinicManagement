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
        public List<Patient> Search(string national)
        {
            List<Patient> res= new List<Patient>();
            foreach (Patient patient in Patients)
            {
                if (patient.NationalCode == national)
                {
                    res.Add(patient);
                }
            }
            return res;
           
        }
    }
}
