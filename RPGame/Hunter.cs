using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public class Hunter : characterClass
    {
        public ushort HP { get; set; }
        public ushort Damage { get; set; }
        public float Range { get; set; }
        public string Race { get; set; }

        public Hunter(string _Race)
        {
            HP = 80;
            Damage = 35;
            Range = 0.7f;
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
            $"HP: {HP} / 80\n" +
            $"Damage: {Damage}\n" +
            $"Range Level: {Range}\n");
        }

        public void Heal()
        {
            Console.WriteLine("Im unable to heal as i am a Hunter, but i will try my best.\n");

            if (HP + 5 > 80)
            {
                HP = 80;
            }

            else HP += 5;
        }
    }
}
