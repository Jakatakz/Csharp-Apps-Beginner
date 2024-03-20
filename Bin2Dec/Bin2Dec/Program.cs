// My solution of https://github.com/florinpop17/app-ideas/blob/master/Projects/1-Beginner/Bin2Dec-App.md
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Regex pattern = new Regex("^[01]+$");
        String userInput;
        do
        {
            Console.WriteLine("Enter up to 8 0/1's");
            userInput = Console.ReadLine();

            if (!pattern.IsMatch(userInput) || userInput.Length > 8)
            {
                Console.WriteLine("Invalid input, needs to be 8 characters and only contain 0s or 1s");
                userInput = null; // This resets userInput to indicate that it's invalid input.
            }
        }
        while (userInput == null); // This repeats until userInput is valid


        //Console.WriteLine("Don't need to convert with Parse, Valid string: " + int.Parse(userInput));
        Console.WriteLine("Binary: " + userInput + ", Decimal: " + Convert.ToInt32(userInput, 2));
    }

    
}