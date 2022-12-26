using System;

namespace Abstract_Factory
{
    public class AbstractFactory
    {

        //*** Real world example:

        //Extending our door example from Simple Factory.Based on your needs you might get a wooden door from a wooden door shop, iron door from an iron shop or a PVC door from the relevant shop. Plus you might need a guy with different kind of specialities to fit the door, for example a carpenter for wooden door, welder for iron door etc.As you can see there is a dependency between the doors now, wooden door needs carpenter, iron door needs a welder etc.

        //*** In plain words:

        //A factory of factories; a factory that groups the individual but related/dependent factories together without specifying their concrete classes.

        //*** Wikipedia says:

        //The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes

        //*** STEPS To Follow:

        // 1) First we create the Interface for the Door => IDoor!
        // 2) Then we create the different type of Doors => e.g: IronDoor && WoodenDoor implementing IDoor Interface!
        // 3) Then we need the create the Interface for the DoorFittingExpert => IDoorFittingExpert!
        // 4) Then we implement the above interface to the different door specific experts => e.g: Welder && Carpenter  => : IDoorFittingExpert
        // 5) After these 4 steps we Create an Interface for our new DoorFactory => IDoorFactory => containing 2 methods, one for creatingDoor && one for creating doorExpert.
        // 6) Next is the creating of the specific factories => WoodenDoorFactory && IronDoorFactory => : IDoorFactory.

        // Final Step => Test in the Main method if the program returns the desired output!
        static void Main(string[] args)
        {
            WoodenDoorFactory woodenDoorFactory = new WoodenDoorFactory();
            IDoor woodenDoor = woodenDoorFactory.MakeDoor();
            IDoorFittingExpert carpenter = woodenDoorFactory.MakeDoorFittingExpert();

            woodenDoor.GetDescription();
            carpenter.GetDescription();

            IronDoorFactory ironDoorFactory = new IronDoorFactory();
            IDoor ironDoor = ironDoorFactory.MakeDoor();
            IDoorFittingExpert welder = ironDoorFactory.MakeDoorFittingExpert();

            ironDoor.GetDescription();
            welder.GetDescription();

            //As you can see the wooden door factory has encapsulated the carpenter and the wooden door also iron door factory has encapsulated the iron door and welder. And thus it had helped us make sure that for each of the created door, we do not get a wrong fitting expert.
        }

        //*** When to use:

        //When there are interrelated dependencies with not-that-simple creation logic involved
    }
}
