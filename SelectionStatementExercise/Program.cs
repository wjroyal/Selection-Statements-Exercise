namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number guessing game
            var favoriteNumber = 42;
            int userInput;
            do
            {
                Console.WriteLine("Try to guess my favorite number.");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favoriteNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favoriteNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine($"You guessed it!");
                }
            }
            while (userInput != favoriteNumber);
        }
    }
}
