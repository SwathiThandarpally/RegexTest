using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public  class PasswordRule2
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[a-z]{5}$";

        public bool validatePassWord(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
