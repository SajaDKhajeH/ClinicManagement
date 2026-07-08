using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    internal class DrManager
    {
        private static List<Doctor> doctors;
        public List<Doctor> GetDr()
        {
            return doctors;
        }
        public Result2 AddDr(Doctor doctor)
        {
            int medicalCouncilInt;
            bool isNumber = int.TryParse(doctor.MedicalCouncil, out medicalCouncilInt);
            if (doctors == null)
            {
                doctors = new List<Doctor>();
            }
            if (!isNumber)
                {
                    return Result2.Failed("لطفا شماره نظام پزشکی را به عدد وارد کن");
                }
                if (doctor.MedicalCouncil.Length != 5)
                {
                    return Result2.Failed("شماره نظام پزشکی باید 5رقمی باشد");
                }
                int id;
                if (doctors.Count > 0)
                    id = doctors[doctors.Count- 1].ID;
                else
                    id = 0;
                id++;
                doctor.ID = id;

                doctors.Add(doctor);
                return Result2.IsSuccessfol();
            

        }
        public void DeleteDr(int id)
        {
            for(int i = 0; i < doctors.Count; i++)
                    if (doctors[i].ID == id)
                {  
                    doctors.RemoveAt(i);
                    break;
                }
           
        }
    }

}
