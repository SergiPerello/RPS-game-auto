namespace RPS_Game_Constants
{
    using System;

    public static class Constants
    {
        public static byte Rock { get; } = 0;
        public static byte Paper { get; } = 1;
        public static byte Scissors { get; } = 2;
        public static byte Lizard { get; } = 3;
        public static byte Spoke { get; } = 4;
        public static string Draw { get; } = "It's a draw!";
        public static string PlayerOneWins { get; } = "Player 1 wins!";
        public static string PlayerTwoWins { get; } = "Player 2 wins!";
        public static string[] AvailableActions { get; } = new string[] { "Rock", "Paper", "Scissors", "Lizard", "Spoke" };
    }
}