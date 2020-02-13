using System.Collections.Generic;
using System.Linq;

namespace HealPowerApp
{
    public class ItemManager
    {


        public Item[] Items { get; internal set; }
        public List<Item> AllItems { get; internal set; }

        public ItemManager()
        {
            Items = new Item[6];
            AllItems = SeedData.AllItems(this);

        }


        public Item[] StrongestHPSItemSet(int baseHeal, float apBonus, float baseCd, out float bestHPS, bool cheapest = false)
        {
            var combination = new Combination();

            bestHPS = 0;

            float bestHPScostRatio = 0;

            Item[] bestSet = new Item[1];

            foreach (IEnumerable<Item> items in combination.Combinations(AllItems, Items.Length))
            {
                var itemSet = items.ToArray();
                foreach (var item in itemSet)
                {
                    item.ItemList = itemSet;
                }

                ItemSetSums(itemSet, out int apSum, out int cdSum, out int healPowSum, out int totalCost);

                float totalHPS = HPS(baseHeal, apBonus, baseCd, apSum, cdSum, healPowSum);



                if (cheapest)
                {
                    var costRatio = totalHPS / totalCost;
                    if (costRatio > bestHPScostRatio)
                    {
                        bestHPScostRatio = costRatio;
                    }
                }

                if (totalHPS > bestHPS)
                {
                    bestHPS = totalHPS;
                    bestSet = itemSet;
                }
            }


            return bestSet;


        }



        private float HPS(int baseHeal, float apBonus, float baseCd, int ap, int cdRed, int healPow)
        {
            return ((baseHeal + ap * apBonus) * healPow / 100) / (baseCd - baseCd * cdRed / 100);
        }

        private void ItemSetSums(IEnumerable<Item> itemSet, out int apSum, out int cdSum, out int healPowSum, out int totalCost)
        {
            apSum = 0;
            cdSum = 0;
            healPowSum = 0;
            totalCost = 0;
            foreach (var item in itemSet)
            {
                apSum += item.Ap;
                cdSum += item.CdRed;
                healPowSum += item.Healpower;
                totalCost += item.Cost;
            }
            if (cdSum > 40) cdSum = 40;
        }

    }
}