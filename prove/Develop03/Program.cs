using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Enter a quote from the scriptures:");
            string quote = Console.ReadLine();

            Reference reference = new Reference("BookName", 1, 1); // You can customize the reference details

            Scripture scripture = new Scripture(reference, quote);

            while (!scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Do you want to hide a word? (Press Enter to hide, type 'stop' to finish)");
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break;
                }

                int numberToHide;
                bool validInput = false;
                do
                {
                    Console.WriteLine("Enter the number of words you want to hide:");
                    string numberToHideInput = Console.ReadLine();

                    if (int.TryParse(numberToHideInput, out numberToHide) && numberToHide > 0 && numberToHide <= scripture.GetTotalWordsCount())
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number between 1 and the total number of words in the quote.");
                    }
                } while (!validInput);

                scripture.HideRandomWords(numberToHide);
            }

            Console.WriteLine("All words are hidden. Do you want to play again? (Type 'yes' to start again)");
            string playAgainInput = Console.ReadLine();

            if (playAgainInput.ToLower() != "yes")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thank you for playing! Goodbye!");
    }
}
