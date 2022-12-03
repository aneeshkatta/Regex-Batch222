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
        {//Test Mobile Format:91 9919819801 &:91-9919819801
            string inputMobileNo = "91 9919819801";
            bool result=RegexValidationCheck.RegexValidate(inputMobileNo);
            Console.WriteLine("\n{0}", result);
        }
    }
}
