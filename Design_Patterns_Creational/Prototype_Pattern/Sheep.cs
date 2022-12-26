using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern
{
    public class Sheep
    {
        public Sheep(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public string Name { get; set; }
        public string Category { get; set; }

        public Sheep Clone() // This is the Prototype Pattern use case!
        {
            return MemberwiseClone() as Sheep;
        }
    }
}
