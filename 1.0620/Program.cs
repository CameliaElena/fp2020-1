
using System;
/// <summary>
/// distanta pana la stormwind
/// </summary>
/// // XML
namespace _1._0620
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            Console.WriteLine("introduceti distanta la care suntenti pe autostrada");
            string line;
            line = Console.ReadLine();

            k = int.Parse(line);
            int d;
            if (k > 60)
                d = k - 60;
            else
                d = 60 - k;
            Console.WriteLine("va aflati la {0} km de stormwind", d );
            //Console.WriteLine($"va aflati la{d} km de stormwind");

        }
    }
}
