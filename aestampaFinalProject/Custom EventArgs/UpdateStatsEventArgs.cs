// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// UpdateStatsEventArgs
// Tells GameGUI what to update statistics with
namespace aestampaFinalProject
{
    public class UpdateStatsEventArgs : EventArgs
    {
        // Private variables
        double currentScore;
        double highScore;
        int gamesWon;
        int gamesLost;
        int numRounds;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="current"></param>
        /// <param name="high"></param>
        /// <param name="wons"></param>
        /// <param name="losses"></param>
        /// <param name="rounds"></param>
        public UpdateStatsEventArgs(double current, double high, int wons, int losses, int rounds)
        {
            currentScore = current;
            highScore = high;
            gamesWon = wons;
            gamesLost = losses;
            numRounds = rounds;
        }

        // Getters and setters
        public double CurrentScore { get => currentScore; set => currentScore = value; }
        public double HighScore { get => highScore; set => highScore = value; }
        public int GamesWon { get => gamesWon; set => gamesWon = value; }
        public int GamesLost { get => gamesLost; set => gamesLost = value; }
        public int NumRounds { get => numRounds; set => numRounds = value; }
    }
}
