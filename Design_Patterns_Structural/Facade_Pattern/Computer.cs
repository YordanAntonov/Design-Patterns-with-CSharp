namespace Facade_Pattern
{
    using System;
    public class Computer
    {
        public void GetElectricShock()
        {
            Console.Write("Ouch!");
        }

        public void MakeSound()
        {
            Console.Write("Beep beep!");
        }

        public void ShowLoadingScreen()
        {
            Console.Write("Loading..");
        }

        public void Bam()
        {
            Console.Write("Ready to be used!");
        }

        public void CloseEverything()
        {
            Console.Write("Bup bup bup buzzzz!");
        }

        public void Sooth()
        {
            Console.Write("Zzzzz");
        }

        public void PullCurrent()
        {
            Console.Write("Haaah!");
        }
    }
}
