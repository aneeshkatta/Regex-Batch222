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
            string inputLastName = "Kumar";
            bool result=RegexValidationCheck.RegexValidate(inputLastName);
            Console.WriteLine("\n{0}", result);
        }
    }
}
