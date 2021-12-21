using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            Console.WriteLine($"it`s{now.Date}, {now.Hour }:{now.Minute}");
            DateTime dt = new DateTime(2021, 12, 11);
            DateTime newDT = dt.AddDays(1);
            Console.WriteLine(newDT);
            TimeSpan ts = now - dt;
            //ts=now.Substract(dt);
            Console.WriteLine(ts.Days);
        }
    }
}



