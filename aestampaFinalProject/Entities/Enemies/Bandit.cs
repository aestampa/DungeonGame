// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Bandit Class
 * Represents a simple bandit. He
 * has low defense, low hit points,
 * physical attacks, weak to both
 * physical and magic damage, and
 * not very strong.
*/
namespace aestampaFinalProject
{
    public class Bandit : Enemy
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Bandit()
        {
            name = "Bandit";
            strength = 5;
            intelligence = 4;
            defense = 5;
            speed = 8;
            isDefending = false;
            hitPoints = 25;
            skillPoints = 100;
            health = 200;
            mySprite = Properties.Resources.Bandit;
            attack = name + " punches ";
            powerMove = name + " throws a wall of knives!";
        }
    }
}