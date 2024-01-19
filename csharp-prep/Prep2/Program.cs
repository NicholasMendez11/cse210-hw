using System;

class Program
{
    static void Main(string[] args)
    {
       // Core Requirements
        Console.WriteLine("Enter your grade percentage: ");
        double gradePercentage = Convert.ToDouble(Console.ReadLine());

        string letter;
   
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

     
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! You passed with {letter}!!.");
        }
        else
        {
            Console.WriteLine($"Sorry, you did not pass. Will be better next time!");
        }

        int lastDigit = (int)gradePercentage % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3 && gradePercentage != 100)
        {
            sign = "-";
        }

        if (letter == "A" && lastDigit >= 7)
        {
            letter = "A-";
            sign = "";
        }
        else if (letter == "F" && lastDigit >= 7)
        {
            letter = "F";
            sign = "";
        }
        else if (letter == "F" && lastDigit < 3 && gradePercentage != 100)
        {
            letter = "F";
            sign = "";
        }

        Console.WriteLine($"Your final grade is {letter}{sign}");
    }
}