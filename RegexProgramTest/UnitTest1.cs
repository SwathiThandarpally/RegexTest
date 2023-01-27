using RegexProgram;

namespace RegexProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void ValidFirstName()
        {
            RegexProgram.ValidFirstNameUC_1 validFirstNameUC_1 = new RegexProgram.ValidFirstNameUC_1();

            string REGEX_VALIDFIRSTNAME = validFirstNameUC_1.ToString();

            Assert.AreEqual(REGEX_VALIDFIRSTNAME, REGEX_VALIDFIRSTNAME);
        }
        [TestMethod]

        public void ValidLastName()
        {
            ValidLastNameUC_2 validLastName = new ValidLastNameUC_2();

            string REGEX_VALIDLASTNAME = validLastName.ToString();

            Assert.AreEqual(REGEX_VALIDLASTNAME, REGEX_VALIDLASTNAME);
        }
        [TestMethod]

        public void ValidEmail()
        {
            ValidEmailUC_3 validEmail = new ValidEmailUC_3();

            string REGEX_VALIDEMAIL = validEmail.ToString();

            Assert.AreEqual(REGEX_VALIDEMAIL, REGEX_VALIDEMAIL);
        }
        [TestMethod]

        public void Predefined_MobileFormat()
        {
            MobileFormatUC_4 mobileFormat = new MobileFormatUC_4();

            string REGEX_PHONENUMBER = mobileFormat.ToString();

            Assert.AreEqual(REGEX_PHONENUMBER, REGEX_PHONENUMBER);
        }
    }
}