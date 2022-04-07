using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public interface characterClass
    {
        public UInt16 HP { get; set; }
        public UInt16 Damage { get; set; }
        public float Range { get; set; }

        public string Race { get; set; }

        public void Attack(characterClass Enemy);
        public void Defend(int Damage, float enemyRange);

        public void Heal();

        public void PrintStats();
    }
}
