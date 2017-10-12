using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanOpp:Player
    {
        public override string generateRoshambo()
        {
           string userChoice = Console.ReadLine();
            return userChoice;
        }
        
    }
}
