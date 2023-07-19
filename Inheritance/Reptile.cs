using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile() 
        {
        }
        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
        public string Habitat { get; set; }
        public string Color { get; set; }
        public bool Growtail { get; set; }
        public bool Scaly { get; set; }

    }
}
