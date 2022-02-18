using System;

namespace Project_Alpha_SR15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here i am gathering variables and welcoming the user to the game
            Console.WriteLine("Welcome to Rock, Paper, Scissors");
            Console.WriteLine("Enter a number from 1 - 3 to start");
            Console.WriteLine("-");
            Console.WriteLine("1. Paper");
            Console.WriteLine("2. Scissors");
            Console.WriteLine("3. Rock");
            string userChoice = Console.ReadLine();

            //Here is the bots code
            Random randomchoice = new Random();
            int ComChoice = randomchoice.Next(1, 4);

            switch (ComChoice)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }

            //to determine if the user has won, tied or lost against the bot
            if (ComChoice == 1)
            {
                if (userChoice == "1")
                {
                    Console.WriteLine("You chose Paper");
                    Console.WriteLine("Computer chose Paper");
                    Console.WriteLine("You have tied with the computer!");
                }

                else if (userChoice == "2")
                {
                    Console.WriteLine("You chose Scissors");
                    Console.WriteLine("Computer chose Paper");
                    Console.WriteLine("You Win!");
                }

                else if (userChoice == "3")
                {
                    Console.WriteLine("You chose Rock");
                    Console.WriteLine("Computer chose Paper");
                    Console.WriteLine("The Computer has Won!");
                }
            }
            if (ComChoice == 2)
            {
                if (userChoice == "1")
                {
                    Console.WriteLine("You chose Paper");
                    Console.WriteLine("Computer chose Scissors");
                    Console.WriteLine("The Computer has Won!");
                }

                else if (userChoice == "2")
                {
                    Console.WriteLine("You chose Scissors");
                    Console.WriteLine("Computer chose Scissors");
                    Console.WriteLine("You have tied with the computer!");
                }

                else if (userChoice == "3")
                {
                    Console.WriteLine("You chose Rock");
                    Console.WriteLine("Computer chose Scissors");
                    Console.WriteLine("You Win!");
                }
            }
            if (ComChoice == 3)
            {
                if (userChoice == "1")
                {
                    Console.WriteLine("You chose Paper");
                    Console.WriteLine("Computer chose Rock");
                    Console.WriteLine("You Win!");
                }

                else if (userChoice == "2")
                {
                    Console.WriteLine("You chose Scissors");
                    Console.WriteLine("Computer chose Rock");
                    Console.WriteLine("The Computer has Won!");
                }

                else if (userChoice == "3")
                {
                    Console.WriteLine("You chose Rock");
                    Console.WriteLine("Computer chose Rock");
                    Console.WriteLine("You have tied with the computer!");
                }
            }
        }
    }
}