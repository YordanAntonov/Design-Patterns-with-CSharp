namespace Builder_Pattern
{
    using System;
    public class BuilderPattern
    {

        //*** Real world example:

        //Imagine you are at Hardee's and you order a specific deal, lets say, "Big Hardee" and they hand it over to you without any questions; this is the example of simple factory. But there are cases when the creation logic might involve more steps. For example you want a customized Subway deal, you have several options in how your burger is made e.g what bread do you want? what types of sauces would you like? What cheese would you want? etc. In such cases builder pattern comes to the rescue.

        //*** In plain words:

        //Allows you to create different flavors of an object while avoiding constructor pollution.Useful when there could be several flavors of an object. Or when there are a lot of steps involved in creation of an object.

        //*** Wikipedia says:

        //The builder pattern is an object creation software design pattern with the intentions of finding a solution to the telescoping constructor anti-pattern.

        //*** Example of telescoping constructor anti-Pattern:

        //public Burger(int size, bool cheese, bool pepperoni, bool lettuce, bool tomato)
        //{

        //}

        //As you can see; the number of constructor parameters can quickly get out of hand and it might become difficult to understand the arrangement of parameters.Plus this parameter list could keep on growing if you would want to add more options in future.This is called telescoping constructor anti-pattern.

        static void Main(string[] args)
        {
            Burger burger = new BurgerBuilder(4).AddCheese().AddLettuce().AddPepperoni().AddTomato().Build();
            Console.WriteLine(burger.GetDescription());
        }

        //*** When to use:

        //When there could be several flavors of an object and to avoid the constructor telescoping.The key difference from the factory pattern is that; factory pattern is to be used when the creation is a one step process while builder pattern is to be used when the creation is a multi step process.
    }
}
