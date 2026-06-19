using System.Collections.Generic;
using System;
using System.IO;

namespace ClinicManagement
{
    internal class PatientManager
    {
        private static List<Patient> Patients;

        public List<Patient> GetPatients()
        {
            return Patients;
        }

        public void AddPatient(Patient patient)
        {
            if (Patients == null)
                Patients = new List<Patient>();

            if (IsInvalidPatientToAdd(patient.NationalCode))
                Patients.Add(patient);
            else
                throw new InvalidDataException();
        }

        public bool IsInvalidPatientToAdd(string IdCode)
        {
            Patient NCode = Patients.Find(p => p.NationalCode == IdCode);
            return NCode == null;
        }
    }
}
