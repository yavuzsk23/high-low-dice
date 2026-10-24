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

            Console.WriteLine("round " + round);
            Console.WriteLine("your dice " + playerDice);
            Console.WriteLine("pc dice " + computerDice);

            if (playerDice > computerDice)
            {
                playerScore++;
                Console.WriteLine("you win this round");
            }
            else if (playerDice < computerDice)
            {
                computerScore++;
                Console.WriteLine("pc win this round");
            }
            else
            {
                Console.WriteLine("draw");
            }
        }

        Console.WriteLine("final score");
        Console.WriteLine("you " + playerScore);
        Console.WriteLine("pc " + computerScore);
    }
}
