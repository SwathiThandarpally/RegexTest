namespace RegexProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Lambda Expression");
            RefactorLambda refactorLambda = new RefactorLambda();
            refactorLambda.Display();
            refactorLambda.Display1();
            refactorLambda.Display2();
            refactorLambda.Display3();
            refactorLambda.Display4();
            refactorLambda.validateValidfirstName("Swathi");
            refactorLambda.validateValidLastName("Goud");
            refactorLambda.validateValidEmail("abx");
        }
    }
}