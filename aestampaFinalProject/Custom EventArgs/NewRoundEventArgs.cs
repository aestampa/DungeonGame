// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NewRoundEventArgs
// GameGUI tells GameLogic that the player
// has finished a round and thus needs a
// new round with new enemies.
namespace aestampaFinalProject
{
    // EventArgs to start a new round
    public class NewRoundEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NewRoundEventArgs()
        {

        }
    }
}
