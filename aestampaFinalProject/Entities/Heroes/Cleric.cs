// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Cleric Class
 * Can heal party members, has low
 * attack, and medium defense to
 * both physical and magical attacks.
 */
namespace aestampaFinalProject
{
    public class Cleric : Hero
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Cleric()
        {
            name = "Cleric";
            strength = 2;
            intelligence = 10;
            defense = 20;
            speed = 5;
            isDefending = false;
            hitPoints = 80;
            health = 100;
            skillPoints = 100;
            mySprite = Properties.Resources.Cleric;
            attack = name + " slaps ";
            powerMove = name + " power heals everyone!";
        }
    }
}