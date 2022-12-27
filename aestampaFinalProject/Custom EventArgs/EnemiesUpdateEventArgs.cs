// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// EnemiesUpdateEventArgs
// GameLogic creates a random list of
// enemies and sends that to GameGUI
namespace aestampaFinalProject
{
    public class EnemiesUpdateEventArgs : EventArgs
    {
        // List of selected enemies in each round
        private List<Enemy> enemyEncounter = new List<Enemy>();

        /// <summary>
        /// Constructor
        /// </summary>
        public EnemiesUpdateEventArgs(List<Enemy> list)
        {
            enemyEncounter = list;
        }

        // Getter and setter for list
        public List<Enemy> EnemyEncounter { get => enemyEncounter; }
    }
}
