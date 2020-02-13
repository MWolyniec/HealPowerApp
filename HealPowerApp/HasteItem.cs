using System;

namespace HealPowerApp
{
    public class HasteItem : Item
    {

        private int cdRed;

        public override int CdRed { get => cdRed + HasteCDReduction(); }


        public HasteItem(string name, int cost, Item[] itemList, int mana = 0, int ap = 0, int cdRed = 0, int healpower = 0) : base(name, cost, itemList, mana, ap, cdRed, healpower)
        {
        }

        private int HasteCDReduction()
        {
            if (Array.Exists(this.ItemList, x => x is HasteItem))
                return -10;
            else
                return 0;
        }
    }
}
