using System;
using System.Text.RegularExpressions;

public class Patterns
{
    public void ValidateEMail(string email)
    {
        // part1: must contain abc
        // part2: must contain @ and bridgelabz
        // part3: must contain dot after bridgelabz followed by co

        var regex = new Regex(@"^([a][b][c])\@([b][r][i][d][g][e][l][a][b][z])\.([c][o])");
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