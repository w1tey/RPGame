using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public class Warlock : characterClass
    {
        public ushort HP { get; set; }
        public ushort Damage { get; set; }
        public float Range { get; set; }
        public string Race { get; set; }

        public Warlock(string _Race)
        {
            HP = 100;
            Damage = 23;
            Range = 0.5f;
            Race = _Race;
        }

        public void Attack(characterClass Enemy)
        {
            Enemy.Defend(Damage, Range);
        }

        public void Defend(int enemyDamage, float enemyRange)
        {
            HP -= Convert.ToUInt16(enemyDamage * enemyRange);
        }

        public void Heal()
        {
            Console.WriteLine("I will seek Light from the traveller.\n");

            if (HP + 60 > 100) HP = 100;
            else { HP += 60; }
        }

        public void PrintStats()
        {
            Console.WriteLine(
            $"Race: {Race}\n" +
            $"HP: {HP} / 100\n" +
            $"Damage: {Damage}\n" +
            $"Range Level: {Range}\n");
        }
    }
}
