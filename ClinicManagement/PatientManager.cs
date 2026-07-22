using System.Collections.Generic;

namespace ClinicManagement
{
    internal class PatientManager
    {
        private static List<Patient> _patients = new List<Patient>();

        public List<Patient> GetPatients()
        {
            return new List<Patient>(_patients);
        }

        public Result AddPatient(Patient patient)
        {
            var vaidate = patient.Validate();
            if (!vaidate.Success)
            {
                return Result.Failed(vaidate.Message);
            }

            _patients.Add(patient);
            return Result.Ok();
        }

        public Result UpdatePatient(Patient patient)
        {
            //TODO: Implement later
            return Result.Ok();
        }
        internal static int GenerateNewId()
        {
            if (_patients.Count == 0)
                return 1;

            return _patients[_patients.Count - 1].Id + 1;
        }

    }
}
