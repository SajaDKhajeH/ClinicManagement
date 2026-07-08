using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    internal class Result2
    {
        public bool Succsed { get;private set; }
        public string Msg { get; private set; }

        public static Result2 Failed(string msg)
        {
            
            var result = new Result2();
            result.Succsed = false;
            result.Msg = msg;
            return result;
        }
        public static Result2 IsSuccessfol()
        {
            var result= new Result2();
            result.Succsed=true;
            return result;
        }

        
    }
}
