using System;
namespace SimpleRockPaperScissors
{
    public class GameFuncs
    {

        public int wins { get; set; }

        public GameFuncs()
        {
            this.wins = 0;
        }


        public void CalcWin(int ranNum, string[] options, string playerChoice, int plays)
            {
            if (playerChoice == options[ranNum])
            {
                Console.WriteLine("Hmm a draw");
            }
            else if (playerChoice == "rock")
            {
                if (ranNum == 2)
                {
                    Console.WriteLine("Ahh well played");
                    wins += 1;
                    Console.WriteLine($"You've won {wins}/{plays}");
                }
                else
                {
                    Console.WriteLine("ah unlucky this time!");
                }
            }
            else if (playerChoice == "paper")
            {
                if (ranNum == 0)
                {
                    Console.WriteLine("Ahh well played");
                    wins += 1;
                    Console.WriteLine($"You've won {wins}/{plays}");
                }
                else
                {
                    Console.WriteLine("ah unlucky this time!");
                }
            }
            else if (playerChoice == "scissors")
            {
                if (ranNum == 1)
                {
                    Console.WriteLine("Ahh well played");
                    wins += 1;
                    Console.WriteLine($"You've won {wins}/{plays}");
                }
                else
                {
                    Console.WriteLine("ah unlucky this time!");
                }
            }
        }
    }
}
