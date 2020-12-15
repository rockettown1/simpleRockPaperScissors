using System;

namespace SimpleRockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] options = { "rock", "paper", "scissors" };
            GameFuncs Logic = new GameFuncs();


            //Ask how many goes users wants
            Console.WriteLine("How many times do you want to play?");
            if (int.TryParse(Console.ReadLine(), out int plays))
            {
                Console.WriteLine($"Ok, let's play {plays} times");
            }
            else
            {
                Console.WriteLine("Please type a number!");
            }


            //Run the game loop for chosen number of times
            for (int i = 0; i < plays; i++)
            {

                //Ensure player chooses one of the options
                string playerChoice = "";
                bool chosen = false;
                while (!chosen)
                {
                    Console.WriteLine("Rock, Paper, or Scissors? Choose your weapon!");
                    playerChoice = Console.ReadLine().ToLower();
                    int choice = Array.IndexOf(options, playerChoice);
                    if (choice >= 0)
                    {
                        chosen = true;
                    }
                    else
                    {
                        Console.WriteLine("That's not one of the options!");
                    }

                }


                int ranNum = new Random().Next(0, 3);
                Console.WriteLine($"{playerChoice} VS {options[ranNum]}");

                //calculate win based on choices
                Logic.CalcWin(ranNum, options, playerChoice, plays);
                
            }

            Console.WriteLine($"*** You won {Logic.wins} out of {plays} ***");

            if (Logic.wins > ((plays / 2) + 1))
            {
                Console.WriteLine("You're the winner!");
            } else
            {
                Console.WriteLine("Ouch, you're not very good at this");
            }
            
        }
    }
}
