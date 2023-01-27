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
    }
}