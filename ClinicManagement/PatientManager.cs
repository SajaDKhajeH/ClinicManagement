using System.Collections.Generic;
using System;
using System.IO;
using System.Windows.Forms;

namespace ClinicManagement
{
    internal class PatientManager
    {
        private static List<Patient> Patients;

        public List<Patient> GetPatients()
        {
            return Patients;
        }

        public List<Patient> GetPatient(string idCode)
        {
            Patient FindPatient = Patients.Find(p => p.NationalCode == idCode);
            List<Patient> lst = new List<Patient>() { FindPatient };
            return lst;
        }

        public void AddPatient(Patient patient)
        {
            if (Patients == null)
                Patients = new List<Patient>();

            if (IsValidPatientToAdd(patient.NationalCode))
                Patients.Add(patient);
            else
                throw new InvalidDataException();
        }

        public void RemovePatient(string idCode)
        {
            Patient patientToRemove = Patients.Find(p => p.NationalCode == idCode);
            if(patientToRemove == null)
            { 
                throw new InvalidDataException();
            }
            DialogResult q = MessageBox.Show("Are you sure about delete this item?", "Remove Patient", MessageBoxButtons.YesNo);
            if(q == DialogResult.Yes)
            {
                Patients.Remove(patientToRemove);
            }
        }
        public bool IsValidPatientToAdd(string idCode)
        {
            Patient similarNationalCode = Patients.Find(p => p.NationalCode == idCode);
            return similarNationalCode == null;
        }
    }
}
