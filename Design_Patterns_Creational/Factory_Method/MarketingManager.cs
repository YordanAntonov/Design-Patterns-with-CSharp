using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    // 4) Create the hiring Interviewers who implement the Hiring_Manager --> e.g: 
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
