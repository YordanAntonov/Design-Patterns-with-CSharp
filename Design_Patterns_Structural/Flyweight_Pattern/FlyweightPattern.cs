namespace Flyweight_Pattern
{
    public class FlyweightPattern
    {
        //*** Real world example:

        //Did you ever have fresh tea from some stall? They often make more than one cup that you demanded and save the rest for any other customer so to save the resources e.g.gas etc.Flyweight pattern is all about that i.e.sharing.

        //In plain words:

        //It is used to minimize memory usage or computational expenses by sharing as much as possible with similar objects.


        //*** Wikipedia says:

        //In computer programming, flyweight is a software design pattern. A flyweight is an object that minimizes memory use by sharing as much data as possible with other similar objects; it is a way to use objects in large numbers when a simple repeated representation would use an unacceptable amount of memory.

        static void Main()
        {
            var teaMaker = new TeaMaker();
            var teaShop = new TeaShop(teaMaker);

            teaShop.TakeOrder("less sugar", 1);
            teaShop.TakeOrder("more milk", 2);
            teaShop.TakeOrder("without sugar", 5);

            teaShop.Serve();
            // Serving tea to table# 1
            // Serving tea to table# 2
            // Serving tea to table# 5
        }
    }
}