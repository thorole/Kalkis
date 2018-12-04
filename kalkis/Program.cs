using System;

namespace kalkis
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write(" verdien av 'x': ");
                string avbryt = Console.ReadLine();
                if (avbryt == "stopp")
                    break;
                int x = Convert.ToInt32(avbryt);
                Console.Write(" verdien av 'y': ");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x / y;
                int rest = x % y;
                Console.WriteLine("Svar: {0}",sum);
                Console.WriteLine("Trykk 'enter' for å vise restverdi");
                       Console.ReadLine();
                Console.WriteLine("Rest: {0}", rest);
            }
            while (true);

        }
    }
}
