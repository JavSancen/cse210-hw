using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your rate grade?: ");
        string grade = Console.ReadLine();

        int gradeNum = int.Parse(grade);
        string letter = "";
        string sign = "";
        int secondDigit = gradeNum % 10;

        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

            if (secondDigit >= 7)
            {
            sign = "+";
            }

            else if (secondDigit < 3)
            {
                sign = "-";
            }

            else if (letter == "F")
            {
            sign = "";
            }

            else
            {
                sign = "";
            }
                if (gradeNum >= 70)
                {
                    Console.WriteLine($"Congratulations you pass the class with {sign}{letter}.");
                }
                else
                {
                    Console.WriteLine($"Your grade is {sign}{letter} Keep trying you can do it the next time.");
                }
    }
}