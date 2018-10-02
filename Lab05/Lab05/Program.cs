using System;

namespace Lab05
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Input first three char of day(sun, mon, tue, wed, thu, fri or sat) : ");
            string gradeString = Console.ReadLine();
            string message;
            switch (gradeString.ToLower())
            {
                case "sun":
                    message = "Sunday, color Red";
                    break;
                case "mon":
                    message = "Monday, color Yellow";
                    break;
                case "tue":
                    message = "Tuesday, color Pink";
                    break;
                case "wed":
                    message = "Wednesday, color Green";
                    break;
                case "thu":
                    message = "Thursday, color Orange";
                    break;
                case "fri":
                    message = "Friday, color Blue";
                    break;
                case "sat":
                    message = "Saturday, color Purple";
                    break;
                default:
                    message = "Incorrect day";
                    break;
            }
            Console.WriteLine(message);

        }
    }
}
