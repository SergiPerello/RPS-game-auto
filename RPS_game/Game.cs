namespace RPS_Game_Backend
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using RPS_Game_Constants;

    public static class Game
    {
        static string Draw = Constants.Draw;
        static string Win1 = Constants.PlayerOneWins;
        static string Win2 = Constants.PlayerTwoWins;
        private static string[,] pTableRules = new string[,]
        {
            { Draw, Win1, Win2 },
            { Win2, Draw, Win1 },
            { Win1, Win2, Draw }
        };

        public static string[,] TableRules
        {
            get { return pTableRules; }
        }

        public static string GetWinner(byte actionOne, byte actionTwo)
        {
            string result = TableRules[actionOne, actionTwo];

            return result;
        }
    }
}