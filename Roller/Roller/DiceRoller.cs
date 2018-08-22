using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roller
{
    public class DiceRoller
    {
        private readonly int sides;
        private Random rand;
        public DiceRoller(int sides)
        {
            this.sides = sides;
            rand = new Random(Guid.NewGuid().GetHashCode());
        }

        public int GetRoll()
        {
            return (rand.Next() % sides + 1);
        }
    }
}
