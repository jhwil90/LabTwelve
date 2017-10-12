using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {    //variable
        private string name;

        //property
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        //Constructors
        public Player()
        {
            Name = "";
        }
        public Player(string n)
        {
            Name = n;
        }
        public abstract string generateRoshambo();

        }
}
