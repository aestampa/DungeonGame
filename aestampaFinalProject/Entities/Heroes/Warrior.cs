// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Warrior Class
 * Does physical damage, has
 * high physical defense, and
 * is weak to magic.
*/
namespace aestampaFinalProject
{
    public class Warrior : Hero
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Warrior()
        {
            name = "Warrior";
            strength = 10;
            intelligence = 1;
            defense = 10;
            speed = 10;
            isDefending = false;
            hitPoints = 125;
            health = 100;
            skillPoints = 100;
            mySprite = Properties.Resources.Fighter;
            attack = name + " punches ";
            powerMove = name + " fly kicks everyone!";
        }
    }
}