using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomSharks:Player 
    {
        public override string generateRoshambo()

        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode()); //generates a new sequence each time the method is called
            int Omaha = rnd.Next(1, 3);


            if (Omaha == 1)
            {
                return "rock";
            }
            else if (Omaha == 2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }
        }   
            
    }
}
