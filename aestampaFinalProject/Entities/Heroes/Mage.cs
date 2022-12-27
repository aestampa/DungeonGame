// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Mage Class
 * Does magic damage, has low
 * physical defense, and has
 * high magic defense.
*/
namespace aestampaFinalProject
{
    public class Mage : Hero
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Mage()
        {
            name = "Mage";
            strength = 3;
            intelligence = 10;
            defense = 5;
            speed = 3;
            isDefending = false;
            hitPoints = 85;
            skillPoints = 100;
            health = 100;
            mySprite = Properties.Resources.Mage;
            attack = name + " casts a dark spell on ";
            powerMove = name + " casts an explosion spell!";
        }
    }
}