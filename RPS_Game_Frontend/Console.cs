using System;
using RPS_Game_Backend;
using RPS_Game_Constants;

namespace RPS_Game_Frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            playRPS(Constants.Rock, Constants.Rock);
            playRPS(Constants.Rock, Constants.Paper);
            playRPS(Constants.Rock, Constants.Scissors);
            playRPS(Constants.Paper, Constants.Rock);
            playRPS(Constants.Paper, Constants.Paper);
            playRPS(Constants.Paper, Constants.Scissors);
            playRPS(Constants.Scissors, Constants.Rock);
            playRPS(Constants.Scissors, Constants.Paper);
            playRPS(Constants.Scissors, Constants.Scissors);
            playRPS(Constants.Rock, Constants.Rock);
        }
        public static void playRPS(byte actionOne, byte actionTwo)
        {
            Console.WriteLine(Constants.AvailableActions[actionOne] + " - " + Constants.AvailableActions[actionTwo]);
            string winnerAction = Game.GetWinner(actionOne, actionTwo);
            Console.ForegroundColor = ConsoleColor.Green; //The client didn't specified this, but it is more beautiful. 
            Console.WriteLine(winnerAction);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
