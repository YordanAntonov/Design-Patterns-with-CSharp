﻿namespace Decorator_Pattern
{
    using Decorator;
    public class DecoratorPattern
    {
        //*** Real world example:

        //Imagine you run a car service shop offering multiple services.Now how do you calculate the bill to be charged? You pick one service and dynamically keep adding to it the prices for the provided services till you get the final cost.Here each type of service is a decorator.


        //*** In plain words:

        //Decorator pattern lets you dynamically change the behavior of an object at run time by wrapping them in an object of a decorator class.

        //*** Wikipedia says:

        //In object-oriented programming, the decorator pattern is a design pattern that allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class. The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern.

        static void Main()
        {
            ICoffee myCoffee = new SimpleCoffee();
            Console.WriteLine($"{myCoffee.GetCost():f2}$");
            Console.WriteLine($"{myCoffee.GetDescription()}");

            ICoffee milkCoffee = new MilkCoffee(myCoffee);
            Console.WriteLine($"{milkCoffee.GetCost():f2}$");
            Console.WriteLine($"{milkCoffee.GetDescription()}");

            ICoffee whipCoffee = new WhipCoffee(milkCoffee);
            Console.WriteLine($"{whipCoffee.GetCost():f2}$");
            Console.WriteLine($"{whipCoffee.GetDescription()}");

            ICoffee vanillaCoffee = new VanillaCoffe(whipCoffee);
            Console.WriteLine($"{vanillaCoffee.GetCost():f2}$");
            Console.WriteLine($"{vanillaCoffee.GetDescription()}");

        }
    }
}
