namespace HealPowerApp
{
    public class Rabadon : Item
    {
        private int ap;
        private int baseAp;

        public override int Ap { get => ap + CountBonusApFromAllItems(); }

        public Rabadon(string name, int cost, Item[] itemList, int mana = 0, int ap = 0, int cdRed = 0, int healpower = 0) : base(name, cost, itemList, mana, ap, cdRed, healpower)
        {
            baseAp = ap;
        }

        private int CountBonusApFromAllItems()
        {
            var bonus = 0;
            foreach (var item in ItemList)
            {
                if (!item.Equals(this))
                {
                    bonus = bonus + item.Ap;
                }
                else
                {
                    bonus = bonus + baseAp;
                }
            }
            return (int)(bonus * 0.4);
        }
    }
}
