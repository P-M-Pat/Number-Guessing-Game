class Program
{
    static string ValidateGuess(int guess, int answer) => (answer - guess) switch
    {
        0 => "CORRECT!",
        > 10 => "too low",
        < -10 => "too high",
        <= 10 and > 0 => "close, but a little lower",
        >= -10 and < 0 => "close, but a little higher",
    };
    
    static int Main()
    {
        int guess = 0;
        int count = 0;
        string? userInput;

        Random rand = new();
        int answer = rand.Next(0, 101); // generate an integer between 1 and 100

        // Console.WriteLine($"SPOILER!! The answer is {answer}");

        do
        {
            Console.WriteLine("Enter an integer between 1 - 100: ");

            userInput = Console.ReadLine();
            if (int.TryParse(userInput, out guess) && guess <= 100 && guess > 0)
            {
                Console.WriteLine(ValidateGuess(guess, answer));
                count++;

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        } while (guess != answer);
        Console.WriteLine($"Number of guesses: {count}");

        return 0;
    }
}
