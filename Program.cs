using System;

namespace lab1
{
    abstract class Unit
    {
        protected Unit(){}

        protected Unit(string unitName, float health, float speed, float damage)
        {
            UnitName = unitName;
            Health = health;
            Speed = speed;
            Damage = damage;
        }

        public virtual void Attack(Unit enemyUnit)
        {
            Console.WriteLine(this.UnitName + " attacks " + enemyUnit.UnitName);
            enemyUnit.TakeDamage(this);
        }

        public virtual void Move()
        {
            
        }

        public virtual void TakeDamage(Unit enemyUnit)
        {
            Console.WriteLine(this.UnitName + " attacked by " + enemyUnit);
            this.Health -= enemyUnit.Damage;
        }

        public string UnitName { get; }

        public float Health { get; private set; }

        public float Speed { get; }

        public float Damage { get; }
    }

    class Worker : Unit
    {
        
    }

    class Warrior : Unit
    {
        
    }

    class Archer : Unit
    {
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}