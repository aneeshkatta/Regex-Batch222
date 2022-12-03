using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Batch222
{
    internal class Program
    {
        public static void Main()
        {//Test mail:"abc.xyz@bl.co.in";
            string inputMail = "abc@bl.co";//test for checkig mandatory parts only
            bool result=RegexValidationCheck.RegexValidate(inputMail);
            Console.WriteLine("\n{0}", result);
        }
    }
}
