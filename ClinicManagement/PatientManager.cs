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
        public bool NationalCodeExist(string nationalCode)
        {
            if (Patients == null)
            {
                return false;
            }
            foreach (Patient patient in Patients)
            {
                if (patient.NationalCode == nationalCode)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddPatient(Patient Patient)
        {
            if (Patients == null)
                Patients = new List<Patient>();
            
            Patients.Add(Patient);
        }
<<<<<<< HEAD
        
=======
        public void RemovePatient(int index)
        {
            if (Patients == null)
                return;
            if (Patients.Count >= 0)
            {
                Patients.RemoveAt(index);
                System.Windows.Forms.MessageBox.Show("حذف شد");
            }
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
>>>>>>> main
    }
}
