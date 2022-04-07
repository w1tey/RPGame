using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public class AwokenFactory : CharacterFactory
    {
        private string Race = "Awoken";

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
            return new Warlock (Race);
        }
    }
}
