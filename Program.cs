using System;

public class RaehTaleGames
{
    private static bool isGameOver;
    private static int playerHealth;
    private static int intWait;
    private static bool appearChongChingChong;    

    public RaehTaleGames()
    {
        isGameOver = false;
        playerHealth = 100;
        intWait = 1;
        appearChongChingChong = false;
    }

    static void Main()
    {
        Console.WriteLine("Welcome to the RaehTale Games!");

        while (!isGameOver)
        {
            Console.WriteLine("Before you is a cup of tea.");
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Drink the tea");
            Console.WriteLine("2. Wait");
            Console.WriteLine("3. Quit the game");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DrinkTea();
                    break;
                case "2":
                    Wait();
                    break;
                case "3":
                    QuitGame();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
            if (playerHealth > 0)
            {
                isGameOver = true;
                Console.WriteLine("You have won the game. Congratulations!");
            }
            else
            {
                isGameOver = true;
                Console.WriteLine("You have been defeated. Game over!");
            }
    }

        static void DrinkTea()
        {
        Console.WriteLine("You start to drink the tea.");

        Random random = new Random();
        int eventOutcome = random.Next(1, 3);

        switch (eventOutcome)
        {
            case 1:
                Console.WriteLine("You find that the tea bursts with a rich aroma!");
                break;
            case 2:
                Console.WriteLine("You found out that the tea contained a mild poison!");
                playerHealth -= 100;
                Console.WriteLine("You lose 100 health.");
                break;
        }
    }

    static void Wait()
    {
        Console.WriteLine("You wait, but nothing happened.");
        intWait += 1;
        if (intWait == 5)
        {
            appearChongChingChong = true;
            Console.WriteLine("Jaechongchingchong has appeared and taken your tea! Oh no!");
        }
        else
        {
            Console.WriteLine("You have won the game. Congratulations!");
        }
    }

    static void QuitGame()
    {
        isGameOver = true;
        Console.WriteLine("Thank you for playing!");
    }
}
}