using System;
using System.Text.RegularExpressions;

public class Patterns
{
    public void ValidateEMail(string email)
    {       
        var regex = new Regex(@"^([a][b][c])");               // abc mandatory check
        bool matchRes = regex.IsMatch(email);
        if (matchRes == true)
        {
            Console.WriteLine($"\n{email} is valid Email ID");
        }
        else
        {
            Console.WriteLine($"\n{email} is an invalid Email ID");
        }
    }
}