using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class ComputerFacade
    {
        private readonly Computer mComputer;

        public ComputerFacade(Computer mComputer)
        {
            this.mComputer = mComputer;
        }

        public void TurnOn()
        {
            mComputer.GetElectricShock();
            mComputer.MakeSound();
            mComputer.ShowLoadingScreen();
            mComputer.Bam();
        }

        public void TurnOff()
        {
            mComputer.CloseEverything();
            mComputer.PullCurrent();
            mComputer.Sooth();
        }
    }
}
