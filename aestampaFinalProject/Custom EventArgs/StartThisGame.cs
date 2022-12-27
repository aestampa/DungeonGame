// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// StartsThisGame EventArgs
// Starts a new round
namespace aestampaFinalProject
{

    public class StartThisGame : EventArgs
    {
        // Instance variables
        List<Entity> turnOrder;
        int currentRound;

        /// <summary>
        ///  Constructor
        /// </summary>
        /// <param name="order"></param>
        /// <param name="round"></param>
        public StartThisGame(List<Entity> order, int round)
        {
            turnOrder = order;
            currentRound = round;
        }

        // Getters and setters
        public List<Entity> TurnOrder { get => turnOrder; set => turnOrder = value; }
        public int CurrentRound { get => currentRound; set => currentRound = value; }
    }
}
