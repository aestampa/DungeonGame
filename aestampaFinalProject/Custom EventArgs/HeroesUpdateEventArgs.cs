// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// HeroesUpdateEventArgs
// GameLogic creates the list of heroes
// and sends that to GameGUI.
namespace aestampaFinalProject
{
    public class HeroesUpdateEventArgs : EventArgs
    {
        // List of heroes
        List<Hero> heroes = new List<Hero>();

        /// <summary>
        /// Constructor
        /// </summary>// Constructor
        public HeroesUpdateEventArgs(List<Hero> heroes)
        {
            this.heroes = heroes;
        }

        // Getter and setter for list of heroes
        public List<Hero> Heroes { get => heroes; set => heroes = value; }
    }
}
