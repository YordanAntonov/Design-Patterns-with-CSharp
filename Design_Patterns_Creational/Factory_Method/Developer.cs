using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    // 2) Create the different types of interviewers --> e.g: Developer || Community_Executive, etc! They should implement IInterviewer.
    public class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about design patterns!");
        }
    }
}
