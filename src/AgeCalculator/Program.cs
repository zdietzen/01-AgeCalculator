using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public class Program
    {
        public void Main(string[] args) //This is a method named "Main" it's whats called when the program starts
        {
            Console.WriteLine("Enter your birthday in MM/DD/YYYY format");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            int years = new int();
            int months = new int();
            int days = new int();
            int hours = new int();

            DateTime SlidingDate = birthdate;
            DateTime RightNow = DateTime.Now;

            while (SlidingDate < RightNow)
            {
                years++;
                SlidingDate = SlidingDate.AddYears(1);
            }
            SlidingDate = SlidingDate.AddYears(-1);
            years--;

            while (SlidingDate < RightNow)
            {
                months++;
                SlidingDate = SlidingDate.AddMonths(1);
            }
            SlidingDate = SlidingDate.AddMonths(-1);
            months--;

            while (SlidingDate < RightNow)
            {
                days++;
                SlidingDate = SlidingDate.AddDays(1);
            }
            SlidingDate = SlidingDate.AddDays(-1);
            days--;

            while (SlidingDate < RightNow)
            {
                hours++;
                SlidingDate = SlidingDate.AddHours(1);
            }
            SlidingDate = SlidingDate.AddHours(-1);
            hours--;

            Console.WriteLine(
                years.ToString() + " years, " +
                months.ToString() + " months, " +
                days.ToString() + " days," +
                hours.ToString() + " hours");
            Console.WriteLine("Press enter to close");
            string userInput = Console.ReadLine();
        }
    }
}
