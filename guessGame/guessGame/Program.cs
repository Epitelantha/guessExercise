using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessGame
{
    class Program
    {
        //A control for the max amount of lives
        const int MaxLives = 10;
        //The Correct Answer
        const string answer = "Tommy Wiseau";

        static void Main(string[] args)
        {
            //Convert the constant of MaxLives ti an int that can be changed
            int Lives = MaxLives;
            //Tell the user what to do
            Console.WriteLine("You have " + MaxLives + " lives, what is your guess?");

            //Using a while loop to go through the code
            while (Lives > 0)
            {
                //Check the users' answer
                string checkAnswer = Console.ReadLine();
                

                //If the answer is correct, success
                if (checkAnswer == answer)
                {
                    Console.WriteLine("That, detective, is the right answer!");
                    Console.WriteLine("Press ENTER to exit application");
                    Console.ReadLine();
                    Console.WriteLine("I did not hit her. I DID NAWWWT");
                    Console.WriteLine("Oh hi Mark");
                    Environment.Exit(0);
                }
                //If not, restart the loop, with one less live
                else
                {
                    //Subtract a life before starting the loop again
                    Lives = Lives - 1;

                    Console.WriteLine("You have " + Lives + " lives left");
                    Console.WriteLine("Try Again?");
                }
            }

            //If the user is out of lives, terminate the program
            if (Lives == 0)
            {
                Console.WriteLine("You are out of lives");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
