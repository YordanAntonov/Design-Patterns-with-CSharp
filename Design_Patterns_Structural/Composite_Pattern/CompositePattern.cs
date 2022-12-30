namespace Composite_Pattern
{
    using System;
    public class CompositePattern
    {

        static void Main(string[] args)
        {
            try
            {

                IEmployee employee = new Developer("Ivan", 10000);
                IEmployee employee2 = new Developer("Ivailo", 10000);
                IEmployee employee3 = new Developer("Yordan", 15000);
                IEmployee employee4 = new SolutionAnalyst("Kaloyan", 2500);
                IOrganization microsoft = new Organization("Microsoft");
                microsoft.Hire(employee);
                microsoft.Hire(employee2);
                microsoft.Hire(employee3);
                microsoft.Hire(employee4);
                Console.WriteLine(microsoft.Fire("Ivailo2"));
                Console.WriteLine(microsoft.GetNetSalary());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}

