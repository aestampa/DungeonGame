// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Dragon Class
Represents the dragon with strong attacks.
It breathes fire which is a magical attack
on one hero, and it also swipes attack which
is a physical attack. Additionally, it is slow,
strong aginst both physical and magic attacks,
and has high hit points.
 */
namespace aestampaFinalProject
{
    public class Dragon : Enemy
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Dragon()
        {
            name = "Dragon";
            strength = 11;
            intelligence = 10;
            defense = 10;
            speed = 4;
            isDefending = false;
            hitPoints = 60;
            skillPoints = 100;
            health = 500;
            mySprite = Properties.Resources.Dragon;
            attack = name + " breathes fire at ";
            powerMove = name + " sweeps its spiky tail!";
        }
    }
}