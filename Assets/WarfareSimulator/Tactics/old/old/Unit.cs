using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarfareSimulator.old
{
    class OldUnit
    {
        public string name;
        public int initialtive;
        public int health;
        public int armor;
        public int damage;
        public float damageFlow = 0.5f;

        public OldUnit()
        {
            name = "Unamed";
            initialtive = 100;
            health = 100;
            armor = 100;
            damage = 10;
        }

        public OldUnit(String name, int health, int armor)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
        }
    }
}
