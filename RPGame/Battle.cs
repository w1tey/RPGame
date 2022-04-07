using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public class Battle
    {

        static public void Crucible(characterClass Fighter1, characterClass Fighter2 )
        {
            Console.WriteLine("Welcome to the Crucible.");

            var roundCount = 0;
            while (Fighter1.HP > 0 && Fighter2.HP > 0)
            {
                roundCount++;
                Console.WriteLine("Round Number: " + roundCount + "\n");
                //Fight Number 1:

                if (Fighter1 is Warlock)
                {
                    Console.WriteLine(
                        "Fighter1 (Warlock), press 1 to attack and 2 to heal.");
                    var choice = Console.ReadLine();
                    if (choice == "2")
                    {
                        Fighter1.Heal();
                    }
                    else if (choice == "1")
                    {
                        Fighter1.Attack(Fighter2);
                        Console.WriteLine("Fighter 1 attacks Fighter 2, Fighter 2 Defends");
                    }
                    Console.WriteLine("Fighter 1 Stats:\n");
                    Fighter1.PrintStats();
                    Console.WriteLine("Fighter 2 Stats:\n");
                    Fighter2.PrintStats();

                }

                

                else if (Fighter2 is Titan || Fighter2 is Hunter)   
                {
                    Console.WriteLine("Fighter 1 attacks Fighter 2, Fighter 2 Defends");
                    Fighter1.Attack(Fighter2);
                }

                if (Fighter1.HP == 0 || Fighter2.HP == 0) { break; }

                //Fight Number 2:

                if (Fighter2 is Warlock)
                {
                    Console.WriteLine(
                        "Fighter2 (Warlock), press 1 to attack and 2 to heal.");
                    var choice = Console.ReadLine();
                    if (choice == "2")
                    {
                        Fighter2.Heal();
                    }
                    else if (choice == "1") 
                    {
                        Fighter2.Attack(Fighter1);
                        Console.WriteLine("Fighter 2 attacks Fighter 1, Fighter 1 Defends");
                    }
                    Console.WriteLine("Fighter 2 Stats:\n");
                    Fighter2.PrintStats();
                    Console.WriteLine("\n\nFighter 1 Stats:\n");
                    Fighter1.PrintStats();

                }

                else if (Fighter2 is Titan || Fighter2 is Hunter)
                {
                    Console.WriteLine("Fighter 2 attacks Fighter 1, Fighter 1 Defends");
                    Fighter2.Attack(Fighter1);
                }

                if (Fighter1.HP == 0 || Fighter2.HP == 0) { break; }

                Thread.Sleep(2000);
                Console.Clear();
            }

            if (Fighter1.HP == 0)
            {
                Console.WriteLine("Fighter 1 is the winner.");
            }

            else if (Fighter1.HP == 0)
            {
                Console.WriteLine("Fighter 2 is the winner.");
            }
        }

    }
}
