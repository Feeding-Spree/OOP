using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace OOP
{
    public class Functions
    {
        public static bool isGameOver;
        public static int playerHealth;
        public static int intWait;
        public static int intTeaDrink;

        public void RaehTaleGames()
        {
            isGameOver = true;
            playerHealth = 100;
            intWait = 1;
            intTeaDrink = 1;
        }

        public static void Introduction()
        {
            Console.WriteLine("Press 1 to begin.");
            Console.WriteLine("Press 2 to view the sleep-deprived coder who created this program.");

            string input3 = Console.ReadLine();

            switch (input3)
            {
                case "1":
                    isGameOver = false;
                    break;
                case "2":
                    Functions.Credits();
                    Functions.Introduction();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;            
            }
        }

        public static void Credits()
        {
            Console.WriteLine("Created by Raeh Manart H.");
            Console.WriteLine("Submitted to Ms. Indaleen Quinsayas.");         
        }

        public static void DrinkTea()
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
                    case "Yes":
                        Console.WriteLine("You continue to drink the tea!");
                        intTeaDrink += 1; 
                        break;
                    case "No":
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
        public static void Wait()
        {
            Console.WriteLine("You wait, but nothing happened.");
            intWait += 1;
            if (intWait == 5)
            {
                Console.WriteLine("Oh, wait... Jaechongchingchong has appeared and taken your tea! Oh no!");
                isGameOver = true;
            }
        }
        public static void QuitGame()
        {
            isGameOver = true;
            Console.WriteLine("Thank you for playing!");
        }
    }
}