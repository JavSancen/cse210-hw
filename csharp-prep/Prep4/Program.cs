using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when you finish.");

        int count = 0;
        int sum = 0;
        int newNumber = -1;

        List<int> numbers;
        numbers = new List<int>();

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        int max = int.MinValue; // Initialize max with the minimum possible integer value
        int minPositive = numbers.Count > 0 ? numbers[0] : -1; // Initialize minPositive for positive only (if list not empty)


        for (int i = 0; i < numbers.Count; i++)
        {
            int number = numbers[i];
            sum += number;
            count ++;

            if (number > max)
            {
                max = number;
            }

            else if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }

        }

        Console.Write($"The sum is: {sum} ");
        Console.Write($"The average is: {sum/count} ");
        Console.Write($"The largest number is: {max} ");
        Console.Write($"The smallest number is: {minPositive} ");

        Console.Write($"The sorted list is: ");

        List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();

        foreach (int sortedNumber in sortedNumbers) {
          // Do something with the sorted number here
          Console.WriteLine(sortedNumber); // Example: Print the sorted number
}
    }
}