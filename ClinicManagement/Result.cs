using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    public class Result
    {
<<<<<<< HEAD
        public bool Success { get; set; }
        public string Message { get; set; }
       public static Result Failed(string msg)
=======
        private Result()
        {

        }
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public static Result Failed(string msg)
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
        {
            Result result = new Result();
            result.Success = false;
            result.Message = msg;
<<<<<<< HEAD
            return result;
        }
        public static Result Ok()
        {
            Result res = new Result();
            res.Success = true;
            return res;
=======

            return result;
        }

        public static Result Ok()
        {
            Result result = new Result();
            result.Success = true;
            return result;
>>>>>>> 8b155cce0448b0d328e0146ea79ca62241b7f8a0
        }
    }
}
