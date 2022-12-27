// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Ogre Class
 * Represents a slow ogre with strong
 * physical attacks. He has high defense,
 * is weak to magic, and has medium
 * hit points.
*/
namespace aestampaFinalProject
{
    public class Ogre : Enemy
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Ogre()
        {
            name = "Ogre";
            strength = 10;
            intelligence = 1;
            defense = 10;
            speed = 2;
            isDefending = false;
            health = 250;
            hitPoints = 45;
            skillPoints = 100;
            mySprite = Properties.Resources.Ogre;
            attack = name + " burps at ";
            powerMove = name + " does an ogre smash!";
        }
    }
}