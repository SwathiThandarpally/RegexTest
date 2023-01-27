using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public  class PasswordRule3
    {
        public static string REGEX_PASSWORD3 = "^[A-Z]{1}[a-z0-9]{9}$";
        public bool validatePassWord(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD3);
        }
    }
}
