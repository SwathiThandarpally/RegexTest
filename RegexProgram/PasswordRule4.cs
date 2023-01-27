using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public  class PasswordRule4
    {
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[.,:;'!@#$%^&*_+=|(){}[?\\-\\]\\/\\\\])(?!.*[<>`]).{8}";
        public bool validatePassWord(string password4)
        {
            return Regex.IsMatch(password4, REGEX_PASSWORD);
        }
    }
}
