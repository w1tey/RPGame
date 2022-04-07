using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public class ExoFactory : CharacterFactory
    {
        private string Race = "Exo";

        public Hunter CreateHunter()
        {
            return new Hunter(Race);
        }

        public Titan CreateTitan()
        {
            return new Titan(Race);
        }

        public Warlock CreateWarlock()
        {
            return new Warlock(Race);
        }
    }
}
