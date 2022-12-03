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
        {//Test password 8 chars
            string inputPassword = "P1a2s3s4@5w6o7r8D9110>#";
            bool result=RegexValidationCheck.RegexValidate(inputPassword);
            if (result = true)
            { 
                Console.WriteLine("\n Valid Regex input entered"); 
            }
            else
                Console.WriteLine("\n Invalid Regex input entered");
        }
    }
}
