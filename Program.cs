namespace Regex_Email_ID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email Validation Using Regex");

            Patterns objPattern = new Patterns();
            objPattern.ValidateEMail("abc");
        }
    }
}