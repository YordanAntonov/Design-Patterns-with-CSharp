using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    // 3) Create the actual base class or interface with the Factory_Method inside --> e.g: public abstract class HiringManager || public interface IHiringManager!
    public abstract class HiringManager
    {
        abstract protected IInterviewer MakeInterviewer();
        // Factory method

        public void TakeInterview()
        {
            IInterviewer interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }

    }
}
