using System;

namespace TestMyTime
{
    public class TestMyTime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter hour: ");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Minute: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second: ");
            int s = Convert.ToInt32(Console.ReadLine());

            MyTime obj = new MyTime(h, m, s);
            obj.SetHour(h);
            obj.SetMinute(m);
            obj.SetSecond(s);
            Console.WriteLine("Hours are: " + obj.GetHour());
            Console.WriteLine("\nMinutes are: " + obj.GetMinute());
            Console.WriteLine("\nSeconds are: " + obj.GetSecond());
            Console.WriteLine("\nThe time is: " + obj.toString());


            MyTime next = obj.NextSecond();
            Console.WriteLine("\n\n Time at the next second will be: " + next.toString());

            next = obj.NextMinute();
            Console.WriteLine("\n Time at next minute will be: " + next.toString());

            next = obj.NextHour();
            Console.WriteLine("\n Time at next hour will be: " + next.toString());


            MyTime prev = obj.PreviousSecond();
            Console.WriteLine("\n\nTime at Previous second was: " + prev.toString());

            prev = obj.PreviousMinute();
            Console.WriteLine("\n Time at previous minute was: " + prev.toString());

            prev = obj.PreviousHour();
            Console.WriteLine("\n Time at previous hour was: " + prev.toString());


        }
    }
}