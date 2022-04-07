using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame
{
    public interface CharacterFactory
    {
        public Titan CreateTitan();
        public Warlock CreateWarlock();
        public Hunter CreateHunter();

    }
}
