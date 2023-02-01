using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    public  class RefactorLambda
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public int PhoneNumber { get; set; }

        public static string REGEX_VALIDFIRSTNAME = "^[A-Z]{1}[A-Z a-z ]{5}$";


        public bool validateValidfirstName(string validfirstname)
        {
            return Regex.IsMatch(validfirstname, REGEX_VALIDFIRSTNAME);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Lambda Expression");
            List<ValidFirstNameUC_1> list = new List<ValidFirstNameUC_1>();
            {
                list.Add(new ValidFirstNameUC_1());
                REGEX_VALIDFIRSTNAME = string.Empty;
            };
            Console.WriteLine();
            var FirstName = list.First(x => x.validateValidfirstName("Swathi"));
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }
        public static string REGEX_VALIDLASTNAME = "^[A-Z]{1}[a-z]{5}[' '][A-Z]{1}[a-z]{3}";


        public bool validateValidLastName(string validlastname)
        {
            return Regex.IsMatch(validlastname, REGEX_VALIDLASTNAME);
        }
        public void Display1()
        {

            List<ValidLastNameUC_2> validLastNameUC_2s = new List<ValidLastNameUC_2>();
            {
                validLastNameUC_2s.Add(new ValidLastNameUC_2());
                REGEX_VALIDLASTNAME = string.Empty;
            };
            var LastName = validLastNameUC_2s.FindLast(x => x.validateValidLastName("Goud"));
            foreach ( var x in validLastNameUC_2s)
            {
                Console.WriteLine(x);
            }
        }
        public static string REGEX_VALIDEMAIL = "^[a-z][-a-z._]+@([-a-z]+.)+[a-z]{2,5}$";


        public bool validateValidEmail(string validemail)
        {
            return Regex.IsMatch(validemail, REGEX_VALIDEMAIL);
        }
        public void Display2()
        {

            List<ValidEmailUC_3> validEmailUC_3s = new List<ValidEmailUC_3>();
            {
                validEmailUC_3s.Add(new ValidEmailUC_3());
                REGEX_VALIDEMAIL = string.Empty;
            };
            var Email = validEmailUC_3s.FindAll(x => x.validateValidEmail(REGEX_VALIDEMAIL));
            foreach (var x in validEmailUC_3s)
            {
                Console.WriteLine(x);
            }
        }
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[.,:;'!@#$%^&*_+=|(){}[?\\-\\]\\/\\\\])(?!.*[<>`]).{8}";
        public bool validatePassWord(string password4)
        {
            return Regex.IsMatch(password4, REGEX_PASSWORD);
        }
        public void Display3()
        {
            List<PasswordRule4> passwordRules = new List<PasswordRule4>();
            {
                passwordRules.Add(new PasswordRule4());
                REGEX_PASSWORD = string.Empty;
            }
            var Password = passwordRules.FindAll(x => x.validatePassWord(REGEX_PASSWORD));
            foreach(var x in passwordRules)
            {
                Console.WriteLine(x);
            }
        }
        public static string REGEX_PHONENUMBER = "^(91)?[6-9]{1}[0-9]{9}$";

        public bool validatePhoneNumber(string phonenumber)

        {
            return Regex.IsMatch(phonenumber, REGEX_PHONENUMBER);
        }
        public void Display4()
        {
           List<MobileFormatUC_4> mobileFormatUC_4s = new List<MobileFormatUC_4>();
            {
                mobileFormatUC_4s.Add(new MobileFormatUC_4());
                REGEX_PHONENUMBER = string.Empty;
            }
            var PhoneNumber = mobileFormatUC_4s.FindAll(x => x.validatePhoneNumber(REGEX_PHONENUMBER));
            foreach(var x in PhoneNumber)
            {
                Console.WriteLine(x);
            }

        }
    }
}
