using System;

namespace TA_Student_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string name= Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page?");
            string pageNumStr = Console.ReadLine();
            short pageNum = Int16.Parse(pageNumStr);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string helpAnswer = Console.ReadLine();
            bool helpBool = bool.Parse(helpAnswer);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            short hours = Int16.Parse(studyHours);

            Console.WriteLine("Thank you for you answers. An instructor will respond shortly. Have a great day!");
            Console.Read();
        }
    }
}
