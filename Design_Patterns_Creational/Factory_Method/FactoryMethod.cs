using System;
using System.Buffers.Text;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Factory_Method
{
    public class FactoryMethod
    {
        //*** Real world example:

        //Consider the case of a hiring manager.It is impossible for one person to interview for each of the positions. Based on the job opening, she has to decide and delegate the interview steps to different people.

        //*** In plain words:

        //It provides a way to delegate the instantiation logic to child classes.

        //*** Wikipedia says:

        //In class-based programming, the factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object that will be created.This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.

        static void Main(string[] args)
        {
            HiringManager hiringDeveloperManager = new DevelopmentManager();
            HiringManager hiringMarketingManager = new MarketingManager();

            //Developer Interview:
            hiringDeveloperManager.TakeInterview();

            //Marketing Expert Interview:
            hiringMarketingManager.TakeInterview();
        }

        //*** Steps:

        // 1) Create the IInterviewer interface!
        // 2) Create the different types of interviewers --> e.g: Developer || Community_Executive, etc! They should implement IInterviewer.
        // 3) Create the actual base class or interface with the Factory_Method inside --> e.g: public abstract class HiringManager || public interface IHiringManager!
        // 4) Create the hiring Interviewers who implement the Hiring_Manager --> e.g: 

        //*** When to use:

        //Useful when there is some generic processing in a class but the required sub-class is dynamically decided at runtime.Or putting it in other words, when the client doesn't know what exact sub-class it might need.
    }
}
