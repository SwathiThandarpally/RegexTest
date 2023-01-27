using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public  class PasswordRule1
    {
        public static string REGEX_PASSWORD = "^[a-z]{1}[a-z]{7}$";

        public bool validatePassWord(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
