using ClinicManagement.ClinicManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    internal class DoctorManager
    {
        private static List<Doctor> doctors;

        public List<Doctor> GetDoctors()
        {
            if (doctors == null)
                doctors = new List<Doctor>();

            return doctors;
        }

        public Result ValidateDoctor(Doctor doctor)
        {
            if (string.IsNullOrWhiteSpace(doctor.MedicalCouncilNumber))
                return Result.Failed("شماره نظام پزشکی نمی‌تواند خالی باشد.");

            if (doctor.MedicalCouncilNumber.Length != 5)
                return Result.Failed("شماره نظام پزشکی باید ۵ رقم باشد.");

            if (!doctor.MedicalCouncilNumber.All(char.IsDigit))
                return Result.Failed("شماره نظام پزشکی باید فقط شامل عدد باشد.");

            return Result.Ok();
        }

        public Result AddDoctor(Doctor doctor)
        {
            var validate = ValidateDoctor(doctor);
            if (!validate.Success)
                return validate;

            if (doctors == null)
                doctors = new List<Doctor>();

            doctors.Add(doctor);
            return Result.Ok();
        }

        public Result DeleteDoctor(string medicalCouncilNumber)
        {
            if (string.IsNullOrWhiteSpace(medicalCouncilNumber))
                return Result.Failed("شماره نظام پزشکی نمی‌تواند خالی باشد.");

            if (doctors == null)
                doctors = new List<Doctor>();

            Doctor doctor = doctors.FirstOrDefault(d => d.MedicalCouncilNumber == medicalCouncilNumber);

            if (doctor == null)
                return Result.Failed("پزشکی با این شماره نظام پزشکی یافت نشد.");

            doctors.Remove(doctor);
            return Result.Ok();
        }

        public Result UpdateDoctor(string medicalCouncilNumber, string firstName, string lastName, string specialty)
        {
            if (doctors == null)
                doctors = new List<Doctor>();

            Doctor doctor = doctors.FirstOrDefault(d => d.MedicalCouncilNumber == medicalCouncilNumber);

            if (doctor == null)
                return Result.Failed("پزشکی با این شماره نظام پزشکی یافت نشد.");

            if (string.IsNullOrWhiteSpace(firstName))
                return Result.Failed("نام پزشک نمی‌تواند خالی باشد.");

            if (string.IsNullOrWhiteSpace(lastName))
                return Result.Failed("نام خانوادگی پزشک نمی‌تواند خالی باشد.");

            doctor.FirstName = firstName;
            doctor.LastName = lastName;
            doctor.Specialty = specialty;

            return Result.Ok();
        }
    }
}
