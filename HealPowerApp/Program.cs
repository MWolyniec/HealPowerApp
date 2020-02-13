using System;

namespace HealPowerApp
{
    class Program
    {



        static void Main(string[] args)
        {
            var itemManager = new ItemManager();

            Console.WriteLine("Best HPS overall for cat:");

            var BHPS = itemManager.StrongestHPSItemSet(210, 40, 8, out float hps);
            foreach (var item in BHPS)
            {
                Console.WriteLine(item.Name + ",");
            };
            Console.WriteLine($"with total HPS of {hps}.");
            Console.WriteLine();
            Console.WriteLine("Cheapest HPS for cat:");
            var CHPS = itemManager.StrongestHPSItemSet(210, 40, 8, out float cheap, true);
            foreach (var item in CHPS)
            {
                Console.WriteLine(item.Name + ",");
            };
            Console.WriteLine($"with total HPS of {cheap}.");
        }
    }
}
