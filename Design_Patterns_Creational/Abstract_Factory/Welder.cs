using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    public class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can fit only iron doors");
        }
    }
}
