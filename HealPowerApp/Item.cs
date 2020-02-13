namespace HealPowerApp
{
    public class Item
    {
        public string Name { get; }
        public int Cost { get; }
        public int Mana { get; }
        public virtual int Ap { get; }
        public virtual int CdRed { get; }
        public int Healpower { get; }

        public Item[] ItemList { get; set; }

        public Item(string name, int cost, Item[] itemList, int mana = 0, int ap = 0, int cdRed = 0, int healpower = 0)
        {
            this.Name = name;
            this.Cost = cost;
            this.ItemList = itemList;
            this.Mana = mana;
            this.Ap = ap;
            this.CdRed = cdRed;
            this.Healpower = healpower;
        }
    }
}
