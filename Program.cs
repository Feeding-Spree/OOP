﻿﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Mime;

namespace OOP
{
    public class Game
    {
        private static bool isGameOver;
        private static int playerHealth;
        private static int intWait;
        private static int intTeaDrink;
        static void Main()
        {
            Console.WriteLine("Welcome to the RaehTale Games!");
            while (!isGameOver == true)
            {
                    Functions.Introduction();

                while (!isGameOver)
                    {
                        Console.WriteLine("Before you is a cup of tea, prepared to you by your host, Jandel Monte.");
                        Console.WriteLine("Choose an action:");
                        Console.WriteLine("1. Drink the tea");
                        Console.WriteLine("2. Wait");
                        Console.WriteLine("3. Quit the game");

                    string input = Console.ReadLine();

                    List<string> events = new List<string> { "Drink", "Wait", "Quit Game" };
                    switch (input)
                    {
                        case "Drink":
                            Functions.DrinkTea();
                            break;
                        case "Wait":
                            Functions.Wait();
                            continue;
                        case "Quit Game":
                            Functions.QuitGame();
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            continue;
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
}