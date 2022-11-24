namespace Regex_Email_ID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email Validation Using Regex");

            Console.Write("Enter an EMail Address: ");
            
            string email = Console.ReadLine();

            Patterns objPattern = new Patterns();
            objPattern.ValidateEMail(email);
            Console.ReadLine();
        }
    }
}