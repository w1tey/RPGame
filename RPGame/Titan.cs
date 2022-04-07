using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public class Titan : characterClass
    {
        public ushort HP { get; set; }
        public ushort Damage { get; set; }
        public float Range { get; set; }
        public string Race { get; set; }

        public Titan(string _Race)
        {
            HP = 140;
            Damage = 15;
            Range = 0.4f;
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

        public void PrintStats()
        {
            Console.WriteLine(
                $"Race: {Race}\n" +
                $"HP: {HP} / 140\n" +
                $"Damage: {Damage}\n" +
                $"Range Level: {Range}\n");
        }

        public void Heal()
        {
            Console.WriteLine("Im unable to heal as i am a Titan, but i will try my best.\n");

            if (HP + 5 > 140)
            {
                HP = 140;
            }

            else HP += 15;
        }
    }
}
