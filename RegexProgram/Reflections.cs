using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProgram
{
    public class Reflections
    {
        public Reflections()
        {
            Console.WriteLine();
        }
        public Reflections(string EmailSamples)
        {
            EmailSamples samples = new EmailSamples();
            samples.Equals(EmailSamples);
        }
        public Reflections(string Firstname, string LastName, string Email, int PhoneNumber, string Password)
        {
            ValidFirstNameUC_1 validFirstNameUC_1 = new ValidFirstNameUC_1();
            validFirstNameUC_1.validateValidfirstName("Swathi");
            ValidLastNameUC_2 validLastNameUC_2 = new ValidLastNameUC_2();
            validLastNameUC_2.validateValidLastName("Thandarpally");
            ValidEmailUC_3 validEmailUC_3 = new ValidEmailUC_3();
            validEmailUC_3.validateValidEmail("abc@gmail.com");
            MobileFormatUC_4 phoneNumber = new MobileFormatUC_4();
            phoneNumber.validatePhoneNumber("9123456789");
            PasswordRule4 rule4 = new PasswordRule4();
            rule4.validatePassWord("Swathi@134");

        }
    }
}
