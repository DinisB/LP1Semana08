using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
            Move(movement);
        }

        public void Move(int movement) {
            Console.WriteLine(movement.ToRoman());
        }
        
        public abstract float Cost();
    }
}
