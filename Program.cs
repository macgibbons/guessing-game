using System;

namespace GuessingGame {
    class Program {
        static void Main (string[] args) {
            Random rand = new Random ();
            int secretNumber = rand.Next (1, 11);
            
            Console.WriteLine ("Hello! What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"{userName} do you want to play a game?");
            string gamePrompt = Console.ReadLine();
            if (gamePrompt == "yes") {
            Console.WriteLine ("Guess a number between 1 and 10!");

            for(int i =0; i < 3; i++){

                string userGuess = Console.ReadLine ();
                int userGuessInt = int.Parse (userGuess);

                if (userGuessInt == secretNumber) {
                    Console.WriteLine ($"{userName}, you guessed it! it was {secretNumber}");
                    return;
                } else if (userGuessInt > secretNumber) {
                    Console.WriteLine ($"Nope! C'mon {userName}. Try Lower");

                } else if (userGuessInt < secretNumber) {
                    Console.WriteLine($"Nope! Why don't you try higher, {userName}!");
                }
            }
                
            }  else if (gamePrompt == "no") {
                Console.WriteLine("Okay, bye.");
                return;
            } else {
                Console.WriteLine("Please type yes or no");
            }

            Console.WriteLine($"Game Over {userName}! You lose! It was {secretNumber}");

        }
    }
}