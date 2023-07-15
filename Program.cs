using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Mime;

namespace OOP
{
    public class Game
    {
        public static bool isGameOver;
        public static int playerHealth;
        public static int intWait;
        public static int intTeaDrink;
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
                        Functions.DrinkTea();
                        break;
                    case "2":
                        Functions.Wait();
                        continue;
                    case "3":
                        Functions.QuitGame();
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
        }
    }
}