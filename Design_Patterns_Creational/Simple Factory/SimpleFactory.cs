using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Simple_Factory
{
    public class SimpleFactory
    {
        //*** Real world example
        //Consider, you are building a house and you need doors. It would be a mess if every time you need a door, you put on your
        //carpenter clothes and start making a door in your house. Instead you get it made from a factory.

        //*** In plain words

        //Simple factory simply generates an instance for client without exposing any instantiation logic to the client

        //*** Wikipedia says
        //In object - oriented programming(OOP), a factory is an object for creating other objects – formally a factory is a function or method that returns objects of a varying prototype or class from some method call, which is assumed to be "new".

        //*** When to Use?
        //When creating an object is not just a few assignments and involves some logic, it makes sense to put it in a dedicated factory instead of repeating the same code everywhere.
        static void Main(string[] args)
        {

            DoorFactory doorFactory = new DoorFactory();

            IDoor door = doorFactory.MakeDoor(80, 30);
            Console.WriteLine($"This door height is: {door.GetHeight()}");
            Console.WriteLine($"This door width is: {door.GetWidth()}");

        }

        // 1)Create IDoor Interface
        // 2)Create the type of door --> e.g: WoodenDoor : IDoor
        // 3)Create the IDoorFactory --> e.g: IDoorFactory
        // 4)Create the actual DoorFactory --> e.g: DoorFactory : IDoorFactory
        // 5)Test the factory in the SimpleFactory startup!
        
    }

}