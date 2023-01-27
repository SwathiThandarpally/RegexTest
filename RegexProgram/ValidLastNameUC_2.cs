using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public  class ValidLastNameUC_2
    {
        public static string REGEX_VALIDLASTNAME = "^[A-Z]{1}[a-z]{5}[' '][A-Z]{1}[a-z]{3}";


        public bool validateValidLastName(string validlastname)
        {
            return Regex.IsMatch(validlastname, REGEX_VALIDLASTNAME);
        }
    }
}
