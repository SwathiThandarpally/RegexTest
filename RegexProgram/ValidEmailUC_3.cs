using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public  class ValidEmailUC_3
    {
        public static string REGEX_VALIDEMAIL = "^[a-z][-a-z._]+@([-a-z]+.)+[a-z]{2,5}$";


        public bool validateValidEmail(string validemail)
        {
            return Regex.IsMatch(validemail, REGEX_VALIDEMAIL);
        }
    }
}
