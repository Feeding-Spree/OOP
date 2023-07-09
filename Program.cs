using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Mime;

namespace RaehTaleGames
{
public class RandomEncounter
{
    private static bool isGameOver;
    private static int playerHealth;
    private static int intWait;
    private static int intTeaDrink;

    public void RaehTaleGames()
    {
        isGameOver = false;
        playerHealth = 100;
        intWait = 1;
        intTeaDrink = 1;
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
                    continue;
                case "3":
                    QuitGame();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
            if (playerHealth <= 0)
            {
                isGameOver = true;
                Console.WriteLine("Game over!");
            }
            else
            {
                isGameOver = true;
                Console.WriteLine("You have won the game. Congratulations!");
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
                Console.WriteLine("Do you want to continue drinking the tea?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                intTeaDrink += 1;                
                string input2 = Console.ReadLine();

                switch (input2)
                {
                    case "1":
                        Console.WriteLine("You continue to drink the tea!");
                        intTeaDrink += 1; 
                        break;
                    case "2":
                        Console.WriteLine("You left the tea where it is.");
                        Console.WriteLine("The tea has gone cold and you dispose it.");
                        isGameOver = true;
                        Console.WriteLine("Thank you for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
                break;
            case 2:
                Console.WriteLine("You found out that the tea contained a mild poison!");
                Console.WriteLine("You succumb to the poison and died.");
                playerHealth -= 20;
                break;
        }
        if (intTeaDrink == 2)
        {
            Console.WriteLine("You have just drank all of Zeroan's tea! Now he's mad!");
        }
    }

    static void Wait()
    {
        Console.WriteLine("You wait, but nothing happened.");
        intWait += 1;
        if (intWait == 5)
        {
            Console.WriteLine("Oh, wait... Jaechongchingchong has appeared and taken your tea! Oh no!");
            isGameOver = true;
        }
    }

    static void QuitGame()
    {
        isGameOver = true;
        Console.WriteLine("Thank you for playing!");
    }
}
}
}