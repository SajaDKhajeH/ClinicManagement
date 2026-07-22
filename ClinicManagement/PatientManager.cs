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

        public Result AddPatient(Patient patient)
        {
            if (!patient.NationalCode.IsNationalCode())
            {
                return Result.Failed("کدملی نامعتبر");
            }
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

    }
}
