// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// UpdateScoreEventArgs
// Tells GameLogic to update stats
namespace aestampaFinalProject
{
    public class UpdateScoreEventArgs : EventArgs
    {
        bool newRound; // Indicates if round is finished
        Enemy enemyDied; // If enemy is defeated

        /// <summary>
        /// Default constructor
        /// </summary>
        public UpdateScoreEventArgs(bool roundFinished, Enemy? who)
        {
            newRound = roundFinished;
            enemyDied = who;
        }

        // Getters and setters
        public bool NewRound { get => newRound; set => newRound = value; }
        public Enemy EnemyDied { get => enemyDied; set => enemyDied = value; }
    }
}
