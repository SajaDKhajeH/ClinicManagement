using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public class DoctorManagement
    {
        private static List<Doctor> _doctor=new List<Doctor>();
        public List<Doctor> GetDoctor()
        { return _doctor; }
       public Result AddDoctor(Doctor doctor)
        {
            Result result=doctor.Validation();
            if (!result.Success)
                return result;
            if(ExistsMedicalCode(doctor.MedicalCode))
            {
               
                return Result.Failed("کدپزشکی وارد شده تکراری است");
            }
            result.Success = true;
            result.Message = "دکتر ثبت شد";
            _doctor.Add(doctor);
            return result;
        }
        public bool ExistsMedicalCode(string medicalCode)
        {
            if(_doctor==null)
                return false;
            foreach (Doctor doctor in _doctor)
            {
                if(doctor.MedicalCode==medicalCode)
                    return true;
            }
            return false;
        }
        public bool DeleteDoctor(string medicalCode)
        {
            Doctor Delete = null;
        
            foreach (Doctor doctor in _doctor)
            {
                if(doctor.MedicalCode==medicalCode)
                {
                    Delete = doctor;
                    break;
                }
            }
            if(Delete!=null)
            {
                _doctor.Remove(Delete);
                return true;
            }
            return false;
        }
        public static int IdNumber()
        {
            if (_doctor.Count == 0)
                return 1;
            else
                return _doctor[_doctor.Count - 1].Id + 1;
        }
        public static Doctor GetDoctorById(int id)
        {

            foreach (Doctor doctor in _doctor)
            {
                if (doctor.Id == id)
                {
                   return doctor;
                }
            }
            return null;
        }
        
    }
}
