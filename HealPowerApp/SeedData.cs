using System.Collections.Generic;

namespace HealPowerApp
{
    public static class SeedData
    {
        public static List<Item> AllItems(ItemManager itemManager)
        {
            var rabadon = new Rabadon("rabadon", 3600, itemManager.Items, 0, 120, 0, 0);

            var archangel = new HasteItem("archangel", 3200, itemManager.Items, 1400, 50, 20, 0);

            var shurelya = new Item("shurelya", 2050, itemManager.Items, 0, 0, 10, 10);

            var mikaels = new Item("mikaels", 2100, itemManager.Items, 0, 0, 0, 20);

            var ardent = new Item("ardent censer", 2300, itemManager.Items, 0, 60, 10, 10);

            var roa = new Item("rod of ages", 2600, itemManager.Items, 400, 100);

            var redemption = new Item("redemption", 2100, itemManager.Items, 0, 0, 10, 10);

            var spellbinder = new Item("spellbinder", 2900, itemManager.Items, 0, 120);

            var ludens = new HasteItem("ludens", 3200, itemManager.Items, 600, 90, 20);



            return new List<Item>() { rabadon, archangel, shurelya, mikaels, ardent, roa, redemption, spellbinder, ludens };
        }
    }
}
