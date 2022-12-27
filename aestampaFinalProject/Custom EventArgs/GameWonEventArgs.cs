// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// EventArgs after winning game
// GameGUI tells GameLogic that the
// player has defeated all enemies
// in a game of three rounds and
// thus has won the game.
namespace aestampaFinalProject
{
    public class GameWonEventArgs : EventArgs
    {
        // Winning message
        string winMessage = "Game Won! Yay!!";

        /// <summary>
        /// Constructor
        /// </summary>
        public GameWonEventArgs()
        {

        }

        // Getter and setter for message
        public string WinMessage { get => winMessage; set => winMessage = value; }
    }
}
