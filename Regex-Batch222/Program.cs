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
        {
            string inputFirstName = "Raj";
            bool result=RegexValidationCheck.RegexValidate(inputFirstName);
            Console.WriteLine("\n{0}", result);
        }
    }
}
