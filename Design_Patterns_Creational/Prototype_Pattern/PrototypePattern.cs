using System;
using System.Runtime.Intrinsics.X86;

namespace Prototype_Pattern
{
    //*** Real world example:

    //    Remember dolly? The sheep that was cloned! Lets not get into the details but the key point here is that it is all about cloning

    //*** In plain words:

    //Create object based on an existing object through cloning.

    //*** Wikipedia says:

    //The prototype pattern is a creational design pattern in software development.It is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects.

    //In short, it allows you to create a copy of an existing object and modify it to your needs, instead of going through the trouble of creating an object from scratch and setting it up.

    //*** STEPS:
    // 1) Create a class
    // 2) Create Clone method inside the class
    // 3) Method should return the same object

    public class PrototypePattern
    {
        static void Main(string[] args)
        {
            var original = new Sheep("Jolly", "Mountain Sheep");
            Console.WriteLine(original.Name); 
            Console.WriteLine(original.Category); 

            var cloned = original.Clone();
            cloned.Name = "Dolly";
            Console.WriteLine(cloned.Name); 
            Console.WriteLine(cloned.Category); 
            Console.WriteLine(original.Name); 
        }
        
        //*** When to use:

        //When an object is required that is similar to existing object or when the creation would be expensive as compared to cloning.
    }
}
