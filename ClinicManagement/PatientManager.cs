using System.Collections.Generic;

namespace ClinicManagement
{
    internal class PatientManager
    {
        private static List<Patient> Patients;

        public List<Patient> GetPatients()
        {

            //Result r = new Result();
            //r.Success = true;
            //r.Message = "";
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
<<<<<<< HEAD
        public void AddPatient(Patient Patient)
=======

        public Result AddPatient(Patient patient)
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
        {
            if (patient.NationalCode.Length != 10)
            {
                return Result.Failed("کدملی نامعتبر");
            }
            if (Patients == null)
                Patients = new List<Patient>();
<<<<<<< HEAD
            
            Patients.Add(Patient);
        }

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
=======

            int c = Patients.Count;
            int id;
            if (Patients.Count > 0)
                id = Patients[c - 1].Id;
            else
                id = 0;

            id++;

            patient.Id = id;

            Patients.Add(patient);
            return Result.Ok();
        }

        public Result UpdatePatient(Patient patient)
        {
            var validate = patient.Validate();

            if (!validate.Success)
                return validate;


            if (Patients == null)
                Patients = new List<Patient>();

            int c = Patients.Count;
            int id;
            if (Patients.Count > 0)
                id = Patients[c - 1].Id;
            else
                id = 0;

            id++;

            patient.Id = id;

            Patients.Add(patient);
            return Result.Ok();
        }

>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
    }
}
