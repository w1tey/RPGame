using System;


namespace RPGame
{

    
    class Program
    {
        

        public static void Main(string[] args)
        {
            CharacterFactory ExoFac = new ExoFactory();
            var WarlockExo = ExoFac.CreateWarlock();

            CharacterFactory HumanFac = new HumanFactory();
            var TitanHuman = HumanFac.CreateWarlock();

            Battle.Crucible(WarlockExo, TitanHuman);
        }
    }
}


//Console.Write(
//    "Please Pick your Race:\n" +
//    "\t1 - Human\n" +
//    "\t2 - Exo\n" +
//    "\t3 - Awoken\n" +
//    "\tOther - Random Selection\n" +
//    "Enter:  ");

//var tempRace =  Console.ReadLine();

//if (tempRace == "1") { tempRace = "Human"; }
//else if (tempRace == "2") { tempRace = "Exo";}
//else if (tempRace == "3") { tempRace = "Awoken"; }
//else { Random rnd = new Random(); var val = rnd.Next(1, 3); if (val == 1) { tempRace = "Human"; } else if (val == 2) { tempRace = "Exo"; } else { { tempRace = "Awoken"; } }  }

//Console.Write($"You are from the {tempRace} race.\n");
//Thread.Sleep(1500);
//Console.Clear();
//Console.Write(
//    "Ghost: Guardian. Guardian? Eyes up, Guardian!\n" +
//    "\tIt worked. You're alive! You don't know how long I've been looking for you. I'm a Ghost. Actually,\n         now I'm your Ghost. And you... well, you've been dead a long time. So you're going to see a lot of things you\n          won't understand.\n" +
//    "\tThere is a reason i brought you back, we need you Guardian\n" +
//    "\t*you hear screeching in the distance*\n" +
//    "Ghost: Guardian! I will explain all the details later.\n\tWe have to go through Fallen territory, prepare yourself!\n\n");
//Thread.Sleep(3000);
//Console.Clear();
//Console.Write(
//    "Narrator: After a ruthless battle with the Fallen, you come victorious\n" +
//    "and secure a Spaceship which you use to reach the Traveller\n\n");
//Thread.Sleep(2000);
//Console.Clear();
//Console.Write(
//    "Ghost: Guardian, you must train in the Crucible against other guardians in order\n to earn experience to fight in the battle against the Fallen." +
//    "\nPlease Pick your Class:\n" +
//    "\t1 - Titan\n" +
//    "\t2 - Warlock\n" +
//    "\t3 - Hunter\n" +
//    "\tOther - Random Selection\n" +
//    "Enter:  ");

//var tempClass = Console.ReadLine();

//if (tempClass == "1") { tempClass = "Titan"; }
//else if (tempClass == "2") { tempClass = "Warlock"; }
//else if (tempClass == "3") { tempClass = "Hunter"; }
//else { Random rnd = new Random(); var val = rnd.Next(1, 3); if (val == 1) { tempClass = "Titan"; } else if (val == 2) { tempClass = "Warlock"; } else { { tempClass = "Hunter"; } } }

//Console.Write($"You are a {tempClass}.\n");
//Thread.Sleep(3000);
//Console.Clear();