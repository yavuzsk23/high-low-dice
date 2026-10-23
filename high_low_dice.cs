using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        int playerScore = 0;
        int computerScore = 0;

        for (int round = 1; round <= 5; round++)
        {
            int playerDice = rnd.Next(1, 7);
            int computerDice = rnd.Next(1, 7);

            Console.WriteLine("\nRound " + round);
            Console.WriteLine("Your dice: " + playerDice);
            Console.WriteLine("Computer's dice: " + computerDice);

            if (playerDice > computerDice)
            {
                playerScore++;
                Console.WriteLine("You win this round!");
            }
            else if (playerDice < computerDice)
            {
                computerScore++;
                Console.WriteLine("Computer wins this round!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }
        }

        Console.WriteLine("\nFinal Score");
        Console.WriteLine("You: " + playerScore);
        Console.WriteLine("Computer: " + computerScore);
    }
}
