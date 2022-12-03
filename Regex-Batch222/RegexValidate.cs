using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Batch222
{
    internal class RegexValidationCheck
    {
        public static string mobile = "^[0-9]{1}[0-9]{1}[ -][0-9]{10,}";
        public static bool RegexValidate(string inputMobileNo)
        { 
            return Regex.IsMatch(inputMobileNo, mobile);
        }
     } 
}

