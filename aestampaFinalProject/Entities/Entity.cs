// By Abby Estampador
// CS 3020 001
// May 9, 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Entity Class
// Represents an entity, whether it is a hero or an enemy
namespace aestampaFinalProject
{
    public class Entity
    {
        // Instance variables of an entity
        protected int defense;
        protected double hitPoints;
        protected double skillPoints;
        protected double intelligence;
        protected bool isDefending;
        protected Bitmap? mySprite;
        protected string name;
        protected double speed;
        protected double strength;
        protected double health;
        protected string attack;
        protected string powerMove;

        // Getters and setters of entity
        public int Defense { get => defense; set => defense = value; }
        public double HitPoints { get => hitPoints; set => hitPoints = value; }
        public double Intelligence { get => intelligence; set => intelligence = value; }
        public bool IsDefending { get => isDefending; set => isDefending = value; }
        public Bitmap? MySprite { get => mySprite; set => mySprite = value; }
        public string Name { get => name; set => name = value; }
        public double Speed { get => speed; set => speed = value; }
        public double Strength { get => strength; set => strength = value; }
        public double Health { get => health; set => health = value; }
        public double SkillPoints { get => skillPoints; set => skillPoints = value; }
        public string Attack { get => attack; set => attack = value; }
        public string PowerMove { get => powerMove; set => powerMove = value; }
    }
}